﻿using BrightIdeasSoftware;

namespace Player
{
    partial class PlayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerForm));
            this.lstPackets = new BrightIdeasSoftware.ObjectListView();
            this.lstDevices = new BrightIdeasSoftware.ObjectListView();
            this.grpPackets = new System.Windows.Forms.GroupBox();
            this.lnkIpOptions = new System.Windows.Forms.LinkLabel();
            this.chkIpOption = new System.Windows.Forms.CheckBox();
            this.tsPackets = new System.Windows.Forms.ToolStrip();
            this.tsNum = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSendAll = new System.Windows.Forms.ToolStripButton();
            this.lnkSend = new System.Windows.Forms.ToolStripLabel();
            this.tsFilterGo = new System.Windows.Forms.ToolStripButton();
            this.tsBpf = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txtDelay = new System.Windows.Forms.ToolStripTextBox();
            this.lnkDelay = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsNumInterfaces = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtPath = new System.Windows.Forms.ToolStripTextBox();
            this.tsChoose = new System.Windows.Forms.ToolStripButton();
            this.tsWireshark = new System.Windows.Forms.ToolStripButton();
            this.tsFeedback = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tsProg = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstLog = new BrightIdeasSoftware.ObjectListView();
            ((System.ComponentModel.ISupportInitialize)(this.lstPackets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDevices)).BeginInit();
            this.grpPackets.SuspendLayout();
            this.tsPackets.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstLog)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPackets
            // 
            this.lstPackets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPackets.FullRowSelect = true;
            this.lstPackets.GridLines = true;
            this.lstPackets.HideSelection = false;
            this.lstPackets.Location = new System.Drawing.Point(0, 0);
            this.lstPackets.Name = "lstPackets";
            this.lstPackets.ShowGroups = false;
            this.lstPackets.Size = new System.Drawing.Size(574, 249);
            this.lstPackets.TabIndex = 3;
            this.lstPackets.UseCompatibleStateImageBehavior = false;
            this.lstPackets.UseExplorerTheme = true;
            this.lstPackets.View = System.Windows.Forms.View.Details;
            // 
            // lstDevices
            // 
            this.lstDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDevices.FullRowSelect = true;
            this.lstDevices.GridLines = true;
            this.lstDevices.HideSelection = false;
            this.lstDevices.Location = new System.Drawing.Point(0, 0);
            this.lstDevices.Name = "lstDevices";
            this.lstDevices.ShowGroups = false;
            this.lstDevices.Size = new System.Drawing.Size(1158, 241);
            this.lstDevices.TabIndex = 5;
            this.lstDevices.UseCompatibleStateImageBehavior = false;
            this.lstDevices.View = System.Windows.Forms.View.Details;
            // 
            // grpPackets
            // 
            this.grpPackets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPackets.Controls.Add(this.lnkIpOptions);
            this.grpPackets.Controls.Add(this.chkIpOption);
            this.grpPackets.Controls.Add(this.tsPackets);
            this.grpPackets.Controls.Add(this.panel1);
            this.grpPackets.Enabled = false;
            this.grpPackets.Location = new System.Drawing.Point(12, 41);
            this.grpPackets.Name = "grpPackets";
            this.grpPackets.Size = new System.Drawing.Size(587, 334);
            this.grpPackets.TabIndex = 7;
            this.grpPackets.TabStop = false;
            this.grpPackets.Text = "Packets";
            // 
            // lnkIpOptions
            // 
            this.lnkIpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkIpOptions.AutoSize = true;
            this.lnkIpOptions.Location = new System.Drawing.Point(134, 307);
            this.lnkIpOptions.Name = "lnkIpOptions";
            this.lnkIpOptions.Size = new System.Drawing.Size(16, 17);
            this.lnkIpOptions.TabIndex = 8;
            this.lnkIpOptions.TabStop = true;
            this.lnkIpOptions.Text = "?";
            this.lnkIpOptions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkIpOptions_LinkClicked);
            // 
            // chkIpOption
            // 
            this.chkIpOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkIpOption.AutoSize = true;
            this.chkIpOption.Location = new System.Drawing.Point(7, 307);
            this.chkIpOption.Name = "chkIpOption";
            this.chkIpOption.Size = new System.Drawing.Size(124, 21);
            this.chkIpOption.TabIndex = 7;
            this.chkIpOption.Text = "Add IP Options";
            this.chkIpOption.UseVisualStyleBackColor = true;
            // 
            // tsPackets
            // 
            this.tsPackets.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsPackets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNum,
            this.toolStripSeparator1,
            this.tsSendAll,
            this.lnkSend,
            this.tsFilterGo,
            this.tsBpf,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripLabel4,
            this.txtDelay,
            this.lnkDelay});
            this.tsPackets.Location = new System.Drawing.Point(3, 18);
            this.tsPackets.Name = "tsPackets";
            this.tsPackets.Size = new System.Drawing.Size(581, 31);
            this.tsPackets.TabIndex = 6;
            this.tsPackets.Text = "toolStrip3";
            // 
            // tsNum
            // 
            this.tsNum.Name = "tsNum";
            this.tsNum.Size = new System.Drawing.Size(44, 28);
            this.tsNum.Text = "Num:";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsSendAll
            // 
            this.tsSendAll.Image = global::Player.Properties.Resources.play;
            this.tsSendAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSendAll.Name = "tsSendAll";
            this.tsSendAll.Size = new System.Drawing.Size(88, 28);
            this.tsSendAll.Text = "Send All";
            this.tsSendAll.Click += new System.EventHandler(this.btnSendAll_Click);
            // 
            // lnkSend
            // 
            this.lnkSend.IsLink = true;
            this.lnkSend.Name = "lnkSend";
            this.lnkSend.Size = new System.Drawing.Size(16, 28);
            this.lnkSend.Text = "?";
            this.lnkSend.Click += new System.EventHandler(this.lnkSend_Click);
            // 
            // tsFilterGo
            // 
            this.tsFilterGo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsFilterGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFilterGo.Image = global::Player.Properties.Resources.go;
            this.tsFilterGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFilterGo.Name = "tsFilterGo";
            this.tsFilterGo.Size = new System.Drawing.Size(29, 28);
            this.tsFilterGo.Text = "Go";
            this.tsFilterGo.Click += new System.EventHandler(this.tsFilterGo_Click);
            // 
            // tsBpf
            // 
            this.tsBpf.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsBpf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsBpf.Name = "tsBpf";
            this.tsBpf.Size = new System.Drawing.Size(100, 31);
            this.tsBpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tsBpf_KeyDown);
            this.tsBpf.TextChanged += new System.EventHandler(this.tsBpf_TextChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(36, 28);
            this.toolStripLabel2.Text = "BPF:";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(83, 28);
            this.toolStripLabel4.Text = "Delay (ms):";
            // 
            // txtDelay
            // 
            this.txtDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDelay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(30, 31);
            // 
            // lnkDelay
            // 
            this.lnkDelay.IsLink = true;
            this.lnkDelay.Name = "lnkDelay";
            this.lnkDelay.Size = new System.Drawing.Size(16, 28);
            this.lnkDelay.Text = "?";
            this.lnkDelay.Click += new System.EventHandler(this.lnkDelay_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lstPackets);
            this.panel1.Location = new System.Drawing.Point(7, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 249);
            this.panel1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Location = new System.Drawing.Point(12, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1170, 300);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interfaces";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lstDevices);
            this.panel2.Location = new System.Drawing.Point(6, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1158, 241);
            this.panel2.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsRefresh,
            this.tsNumInterfaces});
            this.toolStrip1.Location = new System.Drawing.Point(3, 270);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1164, 27);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsRefresh
            // 
            this.tsRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsRefresh.Image")));
            this.tsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRefresh.Name = "tsRefresh";
            this.tsRefresh.Size = new System.Drawing.Size(82, 24);
            this.tsRefresh.Text = "Refresh";
            this.tsRefresh.Click += new System.EventHandler(this.BtnInterfaces_Click);
            // 
            // tsNumInterfaces
            // 
            this.tsNumInterfaces.Name = "tsNumInterfaces";
            this.tsNumInterfaces.Size = new System.Drawing.Size(88, 24);
            this.tsNumInterfaces.Text = "0 Interfaces.";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtPath,
            this.tsChoose,
            this.tsWireshark,
            this.tsFeedback,
            this.toolStripLabel3,
            this.tsProg});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1194, 32);
            this.toolStrip2.TabIndex = 13;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(70, 29);
            this.toolStripLabel1.Text = "Pcap File:";
            // 
            // txtPath
            // 
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(400, 32);
            // 
            // tsChoose
            // 
            this.tsChoose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsChoose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsChoose.ForeColor = System.Drawing.Color.Navy;
            this.tsChoose.Image = ((System.Drawing.Image)(resources.GetObject("tsChoose.Image")));
            this.tsChoose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsChoose.Name = "tsChoose";
            this.tsChoose.Size = new System.Drawing.Size(96, 29);
            this.tsChoose.Text = "... [ALT + C]";
            this.tsChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // tsWireshark
            // 
            this.tsWireshark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsWireshark.Enabled = false;
            this.tsWireshark.Image = global::Player.Properties.Resources.wireshark;
            this.tsWireshark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsWireshark.Name = "tsWireshark";
            this.tsWireshark.Size = new System.Drawing.Size(173, 29);
            this.tsWireshark.Text = "Open With &Wireshark";
            this.tsWireshark.Click += new System.EventHandler(this.tsWireshark_Click);
            // 
            // tsFeedback
            // 
            this.tsFeedback.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsFeedback.Image = global::Player.Properties.Resources.mail;
            this.tsFeedback.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFeedback.Name = "tsFeedback";
            this.tsFeedback.Size = new System.Drawing.Size(96, 29);
            this.tsFeedback.Text = "Feedback";
            this.tsFeedback.Click += new System.EventHandler(this.tsFeedback_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(114, 29);
            this.toolStripLabel3.Text = "© Inbar Rotem";
            // 
            // tsProg
            // 
            this.tsProg.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsProg.Name = "tsProg";
            this.tsProg.Size = new System.Drawing.Size(100, 29);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lstLog);
            this.groupBox3.Location = new System.Drawing.Point(605, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(577, 334);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // lstLog
            // 
            this.lstLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLog.FullRowSelect = true;
            this.lstLog.GridLines = true;
            this.lstLog.HideSelection = false;
            this.lstLog.Location = new System.Drawing.Point(3, 18);
            this.lstLog.Name = "lstLog";
            this.lstLog.ShowGroups = false;
            this.lstLog.Size = new System.Drawing.Size(571, 313);
            this.lstLog.TabIndex = 4;
            this.lstLog.UseCompatibleStateImageBehavior = false;
            this.lstLog.UseExplorerTheme = true;
            this.lstLog.View = System.Windows.Forms.View.Details;
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 695);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.grpPackets);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "PlayerForm";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.PlayerForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayerForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.lstPackets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDevices)).EndInit();
            this.grpPackets.ResumeLayout(false);
            this.grpPackets.PerformLayout();
            this.tsPackets.ResumeLayout(false);
            this.tsPackets.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ObjectListView lstPackets;
        private ObjectListView lstDevices;
        private System.Windows.Forms.GroupBox grpPackets;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsRefresh;
        private System.Windows.Forms.ToolStripLabel tsNumInterfaces;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtPath;
        private System.Windows.Forms.ToolStripButton tsChoose;
        private System.Windows.Forms.ToolStripProgressBar tsProg;
        private System.Windows.Forms.ToolStripButton tsWireshark;
        private System.Windows.Forms.ToolStrip tsPackets;
        private System.Windows.Forms.ToolStripButton tsSendAll;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tsBpf;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripButton tsFilterGo;
        private System.Windows.Forms.ToolStripLabel tsNum;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txtDelay;
        private System.Windows.Forms.CheckBox chkIpOption;
        private System.Windows.Forms.ToolStripLabel lnkDelay;
        private System.Windows.Forms.LinkLabel lnkIpOptions;
        private System.Windows.Forms.ToolStripLabel lnkSend;
        private System.Windows.Forms.ToolStripButton tsFeedback;
        private ObjectListView lstLog;
    }
}

