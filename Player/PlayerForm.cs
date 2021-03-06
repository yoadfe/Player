﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.IpV4;

namespace Player
{
    public partial class PlayerForm : Form
    {
        private PacketInfo[] _packets;
        private DeviceInfo[] _devices;

        public PlayerForm()
        {
            InitializeComponent();

            Icon = Icon.FromHandle(new Bitmap(Properties.Resources.play).GetHicon());

            InitLists();
        }

        private void InitLists()
        {
            lstPackets.Columns.AddRange(new ColumnHeader[]
            {
                new OLVColumn("#", "Num"),
                new OLVColumn("TimeStamp", "TimeStamp"),
                new OLVColumn("Length", "Length"),
                new OLVColumn("Protocol", "Protocol"),
                new OLVColumn("Kind", "Kind"),
            });

            lstDevices.Columns.AddRange(new ColumnHeader[]
            {
                new OLVColumn("Description", "Description"),
                new OLVColumn("Address", "Address"),
                new OLVColumn("Name", "Name")
            });

            lstLog.Columns.AddRange(new ColumnHeader[]
            {
                new OLVColumn("Time", "Time"),
                new OLVColumn("Message", "Message"),
            });
        }

        private async void PlayerForm_Load(object sender, EventArgs e)
        {
            try
            {
                var menu = new ContextMenuStrip();

                menu.Items.Add("Send Packet", Properties.Resources.play, SendPackets);
                menu.Items.Add("Save To Pcap", Properties.Resources.wireshark, SavePackets);

                lstDevices.UseCustomSelectionColors = true;
                lstDevices.HighlightBackgroundColor = Color.CornflowerBlue;
                lstDevices.UnfocusedHighlightBackgroundColor = Color.CornflowerBlue;

                lstPackets.ContextMenuStrip = menu;

                Text = $@"Player (Version {Properties.Settings.Default.Version})";

                await LoadDevices();
            }
            catch (Exception ex)
            {
                Log(ex);
            }
        }

        private void SavePackets(object sender, EventArgs e)
        {
            try
            {
                string path;

                if (_devices.Length == 0)
                {
                    throw new Exception("At least one interface should be found");
                }

                using (var dlg = new SaveFileDialog
                {
                    Title = @"Save Packets",
                    Filter = @"pcap files (*.pcap;*.pcapng)|*.pcap;*.pcapng",
                    RestoreDirectory = true})
                {
                    if (dlg.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    path = dlg.FileName;
                }

                var packets = lstPackets.SelectedObjects.Cast<PacketInfo>().ToArray();

                using (var communicator =
                    _devices[0].Device.Open(65536,
                        PacketDeviceOpenAttributes.Promiscuous,
                        1000))
                {
                    using (var dumpFile = communicator.OpenDump(path))
                    {
                        foreach (var packet in packets)
                        {
                            dumpFile.Dump(packet.Packet);
                        }
                    }
                }

                Log($"Saved {packets.Length} packets to {path}");
            }
            catch (Exception ex)
            {
                Log(ex);
            }
        }

        private void SendPackets(object sender, EventArgs e)
        {
            try
            {
                SendPackets(lstPackets.SelectedObjects.Cast<PacketInfo>().ToArray());
            }
            catch (Exception ex)
            {
                Log(ex);
            }
        }

        private void SendPackets(PacketInfo[] packets)
        {
            try
            {
                var devices = lstDevices.SelectedObjects;
                if (devices.Count == 0)
                {
                    throw new Exception("Select at least one interface");
                }

                if (packets.Length == 0)
                {
                    throw new Exception("Select at least one packet");
                }

                foreach (DeviceInfo device in devices)
                {
                    var msg = $"Sending {packets.Length} packets on {device.Description} ({device.Address})";
                    
                    if (chkIpOption.Checked)
                    {
                        msg = $"{msg} (with IP Options)";
                    }

                    Log(msg);

                    var currDevice = device;
                    int.TryParse(txtDelay.Text, out var delayMs);

                    ThreadPool.QueueUserWorkItem(_ => SendPackets(packets, currDevice, delayMs));
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message, true);
            }
        }

        private void ToggleBusy(bool busy)
        {
            tsProg.Style = busy ? ProgressBarStyle.Marquee : ProgressBarStyle.Continuous;
        }

        private async Task LoadDevices()
        {
            ToggleBusy(true);

            try
            {
                var allDevices = new LivePacketDevice[0];

                await Task.Run(() =>
                {
                    allDevices = LivePacketDevice.AllLocalMachine.ToArray();
                });

                _devices = allDevices.Select(d => new DeviceInfo
                {
                    Name = GetName(d.Name),
                    Description = d.Description,
                    Address = string.Join(",", d.Addresses.
                        Where(a => a.Address.Family == SocketAddressFamily.Internet).
                        Select(a => a.Address.ToString().Split(' ')[1]).
                        ToArray()),
                    Device = d
                }).OrderByDescending(a => a.Address).ToArray();

                Log($"Found {_devices.Length} interfaces");

                lstDevices.SetObjects(_devices);

                lstDevices.AutoResizeColumns();
                lstDevices.CalculateReasonableTileSize();
            }
            catch (Exception ex)
            {
                Log(ex);
            }
            finally
            {
                ToggleBusy(false);
                tsNumInterfaces.Text = $@"{_devices.Length} Interfaces.";
            }
        }

        private string GetName(string str)
        {
            try
            {
                if (!str.Contains("_"))
                {
                    return str;
                }

                return str.Split('_')[1];
            }
            catch
            {
                return str;
            }
        }

        private async Task LoadFile()
        {
            var file = txtPath.Text;
            if (!File.Exists(file))
            {
                throw new Exception("File not found - " + file);
            }

            Log("Loading packets from file " + file);

            var dumpFile = new OfflinePacketDevice(file);

            var packets = new List<Packet>();

            await Task.Run(() =>
            {
                using (var communicator =
                    dumpFile.Open(65536,
                        PacketDeviceOpenAttributes.None,
                        1000))
                {
                    while (true)
                    {
                        try
                        {
                            communicator.ReceivePacket(out var packet);
                            if (packet == null)
                            {
                                break;
                            }

                            packets.Add(packet);
                        }
                        catch (Exception e)
                        {
                            Log(e);
                        }
                    }
                }

                _packets = packets.Select((p, i) => new PacketInfo
                {
                    Num = i + 1,
                    TimeStamp = p.Timestamp,
                    Length = p.Length,
                    Kind = p.DataLink.Kind,
                    Protocol = GetPacketProto(p).ToString(),
                    Packet = p
                }).ToArray();
            });

            lstPackets.SetObjects(_packets);

            lstPackets.AutoResizeColumns();
            lstPackets.CalculateReasonableTileSize();

            SetColumnWidth("Length", 80);
        }

        private void SetColumnWidth(string title, int width)
        {
            var col = lstPackets.Columns.Cast<OLVColumn>().FirstOrDefault(c => c.Text == title);
            if (col == null)
            {
                throw new Exception("Failed to get column - " + title);
            }

            col.Width = width;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dlg = new OpenFileDialog
                {
                    Title = @"Open Pcap",
                    CheckFileExists = true,
                    CheckPathExists = true,
                    Filter = @"pcap files (*.pcap;*.pcapng)|*.pcap;*.pcapng",
                    FilterIndex = 2,
                    RestoreDirectory = true,
                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                })
                {
                    if (dlg.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    txtPath.Text = dlg.FileName;

                    OnLoadFile();
                }
            }
            catch (Exception ex)
            {
                Log(ex);
            }
        }

        private void UpdateNumPackets(int num)
        {
            tsNum.Text = $@"{num} packets";
            Log($"Showing {num} packets");
        }

        private async void OnLoadFile()
        {
            try
            {
                ToggleBusy(true);

                tsWireshark.Enabled = File.Exists(txtPath.Text);

                await LoadFile();
                UpdateNumPackets(_packets.Length);

                grpPackets.Enabled = true;
            }
            catch (Exception ex)
            {
                Log(ex);
                grpPackets.Enabled = false;
                txtPath.Text = null;
            }
            finally
            {
                ToggleBusy(false);
            }
        }

        private async void BtnInterfaces_Click(object sender, EventArgs e)
        {
            try
            {
                await LoadDevices();
            }
            catch (Exception ex)
            {
                Log(ex);
            }
        }

        private void PlayerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if (e.KeyCode == Keys.C && e.Alt)
            {
                btnChoose_Click(sender, e);
            }
        }

        private IpV4Protocol GetPacketProto(Packet packet)
        {
            switch (packet.Ethernet.EtherType)
            {
                case EthernetType.IpV6:
                    return packet.Ethernet.IpV6.NextHeader;

                case EthernetType.IpV4:
                    return packet.Ethernet.IpV4.Protocol;

                default:
                    return IpV4Protocol.EtherIp;
            }
        }

        private void SendPackets(PacketInfo[] packets, DeviceInfo device, int delayMs)
        {
            try
            {
                using (var communicator =
                    device.Device.Open(65536, 
                        PacketDeviceOpenAttributes.None,
                        1000))
                {
                    foreach (var p in packets)
                    {
                        var packet = p.Packet;
                        if (chkIpOption.Checked)
                        {
                            var proto = GetPacketProto(packet);

                            if (proto == IpV4Protocol.Tcp || proto == IpV4Protocol.Udp)
                            {
                                var ethernet = (EthernetLayer) packet.Ethernet.ExtractLayer();
                                var ipV4Layer = (IpV4Layer) packet.Ethernet.IpV4.ExtractLayer();
                                ipV4Layer.HeaderChecksum = null;

                                var packetTimestamp = packet.Timestamp;
                                var payload = (PayloadLayer) packet.Ethernet.IpV4.Payload.ExtractLayer();

                                ipV4Layer.Options = new IpV4Options(new IpV4OptionBasicSecurity());

                                packet = new PacketBuilder(ethernet, ipV4Layer, payload).Build(packetTimestamp);
                            }
                        }

                        communicator.SendPacket(packet);

                        if (delayMs > 0)
                        {
                            Thread.Sleep(delayMs);
                        }
                    }

                    Log($"Sent {packets.Length} packets on {device.Description} ({device.Address})");
                }
            }
            catch (Exception e)
            {
                Log(e);
            }
        }

        private void Log(Exception ex)
        {
            Log(ex.Message, true);
        }

        private void Log(string message, bool error = false)
        {
            try
            {
                if (InvokeRequired)
                {
                    BeginInvoke((Action)(() => Log(message, error)));
                    return;
                }

                var msg = new LogMessage
                {
                    Time = DateTime.Now.ToString("HH:mm:ss"),
                    Message = message
                };

                lstLog.AddObject(msg);

                if (error)
                {
                    lstLog.Items[lstLog.Items.Count - 1].ForeColor = Color.Red;
                }

                lstLog.AutoResizeColumns();
                lstLog.CalculateReasonableTileSize();
            }
            catch
            {
                // ignored
            }
        }

        private void btnSendAll_Click(object sender, EventArgs e)
        {
            try
            {
                SendPackets(_packets);
            }
            catch (Exception ex)
            {
                Log(ex);
            }
        }

        private void tsWireshark_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(txtPath.Text);
            }
            catch (Exception ex)
            {
                Log(ex);
            }
        }

        private bool AnswersBpf(Packet packet, string bpf)
        {
            return new BerkeleyPacketFilter(bpf, 65536, DataLinkKind.Ethernet).Test(packet);
        }
        
        private void tsFilterGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (tsBpf.TextLength == 0)
                {
                    Log("Removing BPF");
                }
                else
                {
                    Log("Setting BPF to " + tsBpf.Text);
                }

                var filtered = _packets.Where(p => AnswersBpf(p.Packet, tsBpf.Text)).ToArray();
                
                lstPackets.SetObjects(filtered);
                UpdateNumPackets(filtered.Length);

                tsBpf.BackColor = tsBpf.Text.Length > 0  ? Color.GreenYellow : Color.White;
            }
            catch (Exception ex)
            {
                Log(ex);
                tsBpf.BackColor = Color.Salmon;
            }
        }

        private void tsBpf_TextChanged(object sender, EventArgs e)
        {
            tsBpf.BackColor = Color.LightGray;
        }

        private void tsBpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            tsFilterGo_Click(sender, e);

            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        private void lnkDelay_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Add delay between packet sending (in milliseconds)", 
                @"Delay", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void lnkIpOptions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(@"Add IP Options to sent packets (Security - 3)", 
                @"IP Options", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void lnkSend_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Send all packets in pcap file.\nRight click packet(s) to send individually", 
                @"Send Packets", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private async Task SendMail()
        {
            try
            {
                await Task.Run(() =>
                {
                    Log("Sending mail..");

                    const string Subject = "Feedback from Player";
                    const string Mail = "inbar.rotem@gmail.com";
                    var mail = $"mailto:{Mail}?subject={Subject}";
                    Process.Start(mail);
                });
            }
            catch (Exception ex)
            {
                Log(ex);
            }
        }

        private async void tsFeedback_Click(object sender, EventArgs e)
        {
            await SendMail();
        }
    }

    public class PacketInfo
    {
        public int Num;
        public DateTime TimeStamp;
        public int Length;
        public DataLinkKind Kind;
        public string Protocol;
        public Packet Packet;
    }

    public class DeviceInfo
    {
        public string Description;
        public string Address;
        public string Name;
        public LivePacketDevice Device;
    }

    public class LogMessage
    {
        public string Time;
        public string Message;
    }
}
