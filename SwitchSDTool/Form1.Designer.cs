﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SwitchSDTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("American English");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("British English");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Japanese");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("French");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("German");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Latin American Spanish");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Spanish");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Italian");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Dutch");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Canadian French");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Portuguese");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Russian");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Korean");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Taiwanese");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Chinese");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPackNSP = new System.Windows.Forms.Button();
            this.btnDecryptNCA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoadRSAKEK = new System.Windows.Forms.Button();
            this.txtRSAKEK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectSystemPath = new System.Windows.Forms.Button();
            this.btnFindSDKey = new System.Windows.Forms.Button();
            this.btdDecryption = new System.Windows.Forms.Button();
            this.btnSelectSD = new System.Windows.Forms.Button();
            this.txtSDKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fbdSDCard = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdDecryptionPath = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tsProgressText = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSelectNSPPath = new System.Windows.Forms.Button();
            this.listStatus = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainerTop = new System.Windows.Forms.SplitContainer();
            this.btnParseNCA = new System.Windows.Forms.Button();
            this.pbGameIcon = new System.Windows.Forms.PictureBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.tpLog = new System.Windows.Forms.TabPage();
            this.tpGames = new System.Windows.Forms.TabPage();
            this.scGames = new System.Windows.Forms.SplitContainer();
            this.btnDeleteFromSD = new System.Windows.Forms.Button();
            this.btnPackSelectedNSP = new System.Windows.Forms.Button();
            this.btnLargerIcons = new System.Windows.Forms.Button();
            this.btnSmallerIcon = new System.Windows.Forms.Button();
            this.tvGames = new System.Windows.Forms.TreeView();
            this.ilGames = new System.Windows.Forms.ImageList(this.components);
            this.tpPreferedLanguage = new System.Windows.Forms.TabPage();
            this.scLanguage = new System.Windows.Forms.SplitContainer();
            this.btnLanguageDown = new System.Windows.Forms.Button();
            this.btnLanguageUp = new System.Windows.Forms.Button();
            this.tvLanguage = new System.Windows.Forms.TreeView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ilGamesExtraSmall = new System.Windows.Forms.ImageList(this.components);
            this.ilGamesSmall = new System.Windows.Forms.ImageList(this.components);
            this.ilGamesLarge = new System.Windows.Forms.ImageList(this.components);
            this.ilGamesExtraLarge = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).BeginInit();
            this.splitContainerTop.Panel1.SuspendLayout();
            this.splitContainerTop.Panel2.SuspendLayout();
            this.splitContainerTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameIcon)).BeginInit();
            this.tcTabs.SuspendLayout();
            this.tpLog.SuspendLayout();
            this.tpGames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scGames)).BeginInit();
            this.scGames.Panel1.SuspendLayout();
            this.scGames.Panel2.SuspendLayout();
            this.scGames.SuspendLayout();
            this.tpPreferedLanguage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scLanguage)).BeginInit();
            this.scLanguage.Panel1.SuspendLayout();
            this.scLanguage.Panel2.SuspendLayout();
            this.scLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPackNSP
            // 
            this.btnPackNSP.Location = new System.Drawing.Point(366, 112);
            this.btnPackNSP.Name = "btnPackNSP";
            this.btnPackNSP.Size = new System.Drawing.Size(115, 31);
            this.btnPackNSP.TabIndex = 11;
            this.btnPackNSP.Text = "Pack ALL NSPs";
            this.btnPackNSP.UseVisualStyleBackColor = true;
            this.btnPackNSP.Click += new System.EventHandler(this.btnPackNSP_Click);
            // 
            // btnDecryptNCA
            // 
            this.btnDecryptNCA.Location = new System.Drawing.Point(124, 112);
            this.btnDecryptNCA.Name = "btnDecryptNCA";
            this.btnDecryptNCA.Size = new System.Drawing.Size(115, 31);
            this.btnDecryptNCA.TabIndex = 10;
            this.btnDecryptNCA.Text = "Decrypt NCAs";
            this.btnDecryptNCA.UseVisualStyleBackColor = true;
            this.btnDecryptNCA.Click += new System.EventHandler(this.btnDecryptNCA_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Extract Tickets";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoadRSAKEK
            // 
            this.btnLoadRSAKEK.Location = new System.Drawing.Point(139, 40);
            this.btnLoadRSAKEK.Name = "btnLoadRSAKEK";
            this.btnLoadRSAKEK.Size = new System.Drawing.Size(130, 31);
            this.btnLoadRSAKEK.TabIndex = 8;
            this.btnLoadRSAKEK.Text = "Load RSA KEK";
            this.btnLoadRSAKEK.UseVisualStyleBackColor = true;
            this.btnLoadRSAKEK.Click += new System.EventHandler(this.btnLoadRSAKEK_Click);
            // 
            // txtRSAKEK
            // 
            this.txtRSAKEK.Location = new System.Drawing.Point(110, 77);
            this.txtRSAKEK.MaxLength = 32;
            this.txtRSAKEK.Name = "txtRSAKEK";
            this.txtRSAKEK.Size = new System.Drawing.Size(246, 20);
            this.txtRSAKEK.TabIndex = 7;
            this.txtRSAKEK.Text = "Replace me with the actual eticket_rsa_kek.";
            this.txtRSAKEK.TextChanged += new System.EventHandler(this.txtRSAKEK_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ETICKET RSA KEK";
            // 
            // btnSelectSystemPath
            // 
            this.btnSelectSystemPath.Location = new System.Drawing.Point(139, 3);
            this.btnSelectSystemPath.Name = "btnSelectSystemPath";
            this.btnSelectSystemPath.Size = new System.Drawing.Size(130, 31);
            this.btnSelectSystemPath.TabIndex = 5;
            this.btnSelectSystemPath.Text = "Select System Path";
            this.btnSelectSystemPath.UseVisualStyleBackColor = true;
            this.btnSelectSystemPath.Click += new System.EventHandler(this.btnSelectSystemPath_Click);
            // 
            // btnFindSDKey
            // 
            this.btnFindSDKey.Location = new System.Drawing.Point(3, 40);
            this.btnFindSDKey.Name = "btnFindSDKey";
            this.btnFindSDKey.Size = new System.Drawing.Size(130, 31);
            this.btnFindSDKey.TabIndex = 4;
            this.btnFindSDKey.Text = "Find SD Key";
            this.btnFindSDKey.UseVisualStyleBackColor = true;
            this.btnFindSDKey.Click += new System.EventHandler(this.btnFindSDKey_Click);
            // 
            // btdDecryption
            // 
            this.btdDecryption.Location = new System.Drawing.Point(275, 3);
            this.btdDecryption.Name = "btdDecryption";
            this.btdDecryption.Size = new System.Drawing.Size(130, 31);
            this.btdDecryption.TabIndex = 3;
            this.btdDecryption.Text = "Select Decryption Path";
            this.btdDecryption.UseVisualStyleBackColor = true;
            this.btdDecryption.Click += new System.EventHandler(this.btdDecryption_Click);
            // 
            // btnSelectSD
            // 
            this.btnSelectSD.Location = new System.Drawing.Point(3, 3);
            this.btnSelectSD.Name = "btnSelectSD";
            this.btnSelectSD.Size = new System.Drawing.Size(130, 31);
            this.btnSelectSD.TabIndex = 2;
            this.btnSelectSD.Text = "Select SD Folder";
            this.btnSelectSD.UseVisualStyleBackColor = true;
            this.btnSelectSD.Click += new System.EventHandler(this.btnSelectSD_Click);
            // 
            // txtSDKey
            // 
            this.txtSDKey.Location = new System.Drawing.Point(206, 46);
            this.txtSDKey.MaxLength = 32;
            this.txtSDKey.Name = "txtSDKey";
            this.txtSDKey.Size = new System.Drawing.Size(256, 20);
            this.txtSDKey.TabIndex = 1;
            this.txtSDKey.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SD Key";
            this.label1.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgress,
            this.tsProgressText,
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 534);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(916, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsProgress
            // 
            this.tsProgress.Name = "tsProgress";
            this.tsProgress.Size = new System.Drawing.Size(100, 16);
            this.tsProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.tsProgress.Visible = false;
            // 
            // tsProgressText
            // 
            this.tsProgressText.Name = "tsProgressText";
            this.tsProgressText.Size = new System.Drawing.Size(55, 17);
            this.tsProgressText.Text = "100.0% - ";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(118, 17);
            this.lblStatus.Text = "toolStripStatusLabel1";
            // 
            // btnSelectNSPPath
            // 
            this.btnSelectNSPPath.Location = new System.Drawing.Point(411, 3);
            this.btnSelectNSPPath.Name = "btnSelectNSPPath";
            this.btnSelectNSPPath.Size = new System.Drawing.Size(130, 31);
            this.btnSelectNSPPath.TabIndex = 12;
            this.btnSelectNSPPath.Text = "Select NSP Output Path";
            this.btnSelectNSPPath.UseVisualStyleBackColor = true;
            this.btnSelectNSPPath.Click += new System.EventHandler(this.btnSelectNSPPath_Click);
            // 
            // listStatus
            // 
            this.listStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listStatus.FormattingEnabled = true;
            this.listStatus.Location = new System.Drawing.Point(3, 3);
            this.listStatus.Name = "listStatus";
            this.listStatus.ScrollAlwaysVisible = true;
            this.listStatus.Size = new System.Drawing.Size(902, 306);
            this.listStatus.TabIndex = 13;
            this.listStatus.SelectedIndexChanged += new System.EventHandler(this.listStatus_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainerTop);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tcTabs);
            this.splitContainer1.Size = new System.Drawing.Size(916, 534);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.TabIndex = 14;
            // 
            // splitContainerTop
            // 
            this.splitContainerTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTop.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerTop.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTop.Name = "splitContainerTop";
            // 
            // splitContainerTop.Panel1
            // 
            this.splitContainerTop.Panel1.Controls.Add(this.btnParseNCA);
            this.splitContainerTop.Panel1.Controls.Add(this.btnSelectSD);
            this.splitContainerTop.Panel1.Controls.Add(this.btnPackNSP);
            this.splitContainerTop.Panel1.Controls.Add(this.label2);
            this.splitContainerTop.Panel1.Controls.Add(this.btnSelectNSPPath);
            this.splitContainerTop.Panel1.Controls.Add(this.txtRSAKEK);
            this.splitContainerTop.Panel1.Controls.Add(this.btnSelectSystemPath);
            this.splitContainerTop.Panel1.Controls.Add(this.label1);
            this.splitContainerTop.Panel1.Controls.Add(this.btnDecryptNCA);
            this.splitContainerTop.Panel1.Controls.Add(this.btnLoadRSAKEK);
            this.splitContainerTop.Panel1.Controls.Add(this.btdDecryption);
            this.splitContainerTop.Panel1.Controls.Add(this.btnFindSDKey);
            this.splitContainerTop.Panel1.Controls.Add(this.button1);
            this.splitContainerTop.Panel1.Controls.Add(this.txtSDKey);
            // 
            // splitContainerTop.Panel2
            // 
            this.splitContainerTop.Panel2.Controls.Add(this.pbGameIcon);
            this.splitContainerTop.Panel2.Controls.Add(this.txtMessage);
            this.splitContainerTop.Size = new System.Drawing.Size(916, 192);
            this.splitContainerTop.SplitterDistance = 549;
            this.splitContainerTop.TabIndex = 14;
            // 
            // btnParseNCA
            // 
            this.btnParseNCA.Location = new System.Drawing.Point(245, 112);
            this.btnParseNCA.Name = "btnParseNCA";
            this.btnParseNCA.Size = new System.Drawing.Size(115, 31);
            this.btnParseNCA.TabIndex = 13;
            this.btnParseNCA.Text = "Parse NCAs";
            this.btnParseNCA.UseVisualStyleBackColor = true;
            this.btnParseNCA.Click += new System.EventHandler(this.btnParseNCA_Click);
            // 
            // pbGameIcon
            // 
            this.pbGameIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGameIcon.Image = global::SwitchSDTool.Properties.Resources.Ultra_microSDXC_UHS_I_A1_front;
            this.pbGameIcon.InitialImage = global::SwitchSDTool.Properties.Resources.Ultra_microSDXC_UHS_I_A1_front;
            this.pbGameIcon.Location = new System.Drawing.Point(0, 0);
            this.pbGameIcon.Name = "pbGameIcon";
            this.pbGameIcon.Size = new System.Drawing.Size(363, 192);
            this.pbGameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGameIcon.TabIndex = 14;
            this.pbGameIcon.TabStop = false;
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Location = new System.Drawing.Point(0, 0);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(363, 192);
            this.txtMessage.TabIndex = 13;
            this.txtMessage.Visible = false;
            // 
            // tcTabs
            // 
            this.tcTabs.Controls.Add(this.tpLog);
            this.tcTabs.Controls.Add(this.tpGames);
            this.tcTabs.Controls.Add(this.tpPreferedLanguage);
            this.tcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabs.Location = new System.Drawing.Point(0, 0);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(916, 338);
            this.tcTabs.TabIndex = 0;
            this.tcTabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcTabs_Selected);
            // 
            // tpLog
            // 
            this.tpLog.Controls.Add(this.listStatus);
            this.tpLog.Location = new System.Drawing.Point(4, 22);
            this.tpLog.Name = "tpLog";
            this.tpLog.Padding = new System.Windows.Forms.Padding(3);
            this.tpLog.Size = new System.Drawing.Size(908, 312);
            this.tpLog.TabIndex = 0;
            this.tpLog.Text = "Log";
            this.tpLog.UseVisualStyleBackColor = true;
            // 
            // tpGames
            // 
            this.tpGames.Controls.Add(this.scGames);
            this.tpGames.Location = new System.Drawing.Point(4, 22);
            this.tpGames.Name = "tpGames";
            this.tpGames.Padding = new System.Windows.Forms.Padding(3);
            this.tpGames.Size = new System.Drawing.Size(908, 312);
            this.tpGames.TabIndex = 1;
            this.tpGames.Text = "Games";
            this.tpGames.UseVisualStyleBackColor = true;
            // 
            // scGames
            // 
            this.scGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scGames.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scGames.Location = new System.Drawing.Point(3, 3);
            this.scGames.Name = "scGames";
            // 
            // scGames.Panel1
            // 
            this.scGames.Panel1.Controls.Add(this.btnDeleteFromSD);
            this.scGames.Panel1.Controls.Add(this.btnPackSelectedNSP);
            this.scGames.Panel1.Controls.Add(this.btnLargerIcons);
            this.scGames.Panel1.Controls.Add(this.btnSmallerIcon);
            // 
            // scGames.Panel2
            // 
            this.scGames.Panel2.Controls.Add(this.tvGames);
            this.scGames.Size = new System.Drawing.Size(902, 306);
            this.scGames.SplitterDistance = 125;
            this.scGames.TabIndex = 1;
            // 
            // btnDeleteFromSD
            // 
            this.btnDeleteFromSD.Location = new System.Drawing.Point(3, 114);
            this.btnDeleteFromSD.Name = "btnDeleteFromSD";
            this.btnDeleteFromSD.Size = new System.Drawing.Size(115, 38);
            this.btnDeleteFromSD.TabIndex = 15;
            this.btnDeleteFromSD.Text = "Delete Selected from\r\nSD Card";
            this.btnDeleteFromSD.UseVisualStyleBackColor = true;
            this.btnDeleteFromSD.Click += new System.EventHandler(this.btnDeleteFromSD_Click);
            // 
            // btnPackSelectedNSP
            // 
            this.btnPackSelectedNSP.Location = new System.Drawing.Point(3, 3);
            this.btnPackSelectedNSP.Name = "btnPackSelectedNSP";
            this.btnPackSelectedNSP.Size = new System.Drawing.Size(115, 31);
            this.btnPackSelectedNSP.TabIndex = 14;
            this.btnPackSelectedNSP.Text = "Pack Selected NSP";
            this.btnPackSelectedNSP.UseVisualStyleBackColor = true;
            this.btnPackSelectedNSP.Click += new System.EventHandler(this.btnPackSelectedNSP_Click);
            // 
            // btnLargerIcons
            // 
            this.btnLargerIcons.Location = new System.Drawing.Point(3, 77);
            this.btnLargerIcons.Name = "btnLargerIcons";
            this.btnLargerIcons.Size = new System.Drawing.Size(115, 31);
            this.btnLargerIcons.TabIndex = 13;
            this.btnLargerIcons.Text = "128x128 Icons";
            this.btnLargerIcons.UseVisualStyleBackColor = true;
            this.btnLargerIcons.Click += new System.EventHandler(this.btnLargerIcons_Click);
            // 
            // btnSmallerIcon
            // 
            this.btnSmallerIcon.Location = new System.Drawing.Point(3, 40);
            this.btnSmallerIcon.Name = "btnSmallerIcon";
            this.btnSmallerIcon.Size = new System.Drawing.Size(115, 31);
            this.btnSmallerIcon.TabIndex = 12;
            this.btnSmallerIcon.Text = "32x32 Icons";
            this.btnSmallerIcon.UseVisualStyleBackColor = true;
            this.btnSmallerIcon.Click += new System.EventHandler(this.btnSmallerIcon_Click);
            // 
            // tvGames
            // 
            this.tvGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvGames.ImageIndex = 0;
            this.tvGames.ImageList = this.ilGames;
            this.tvGames.Location = new System.Drawing.Point(0, 0);
            this.tvGames.Name = "tvGames";
            this.tvGames.SelectedImageIndex = 0;
            this.tvGames.Size = new System.Drawing.Size(773, 306);
            this.tvGames.TabIndex = 0;
            this.tvGames.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvGames_AfterSelect);
            this.tvGames.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvGames_NodeMouseClick);
            this.tvGames.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvGames_NodeMouseDoubleClick);
            // 
            // ilGames
            // 
            this.ilGames.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.ilGames.ImageSize = new System.Drawing.Size(64, 64);
            this.ilGames.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tpPreferedLanguage
            // 
            this.tpPreferedLanguage.Controls.Add(this.scLanguage);
            this.tpPreferedLanguage.Location = new System.Drawing.Point(4, 22);
            this.tpPreferedLanguage.Name = "tpPreferedLanguage";
            this.tpPreferedLanguage.Size = new System.Drawing.Size(908, 312);
            this.tpPreferedLanguage.TabIndex = 2;
            this.tpPreferedLanguage.Text = "Language";
            this.tpPreferedLanguage.UseVisualStyleBackColor = true;
            // 
            // scLanguage
            // 
            this.scLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scLanguage.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scLanguage.Location = new System.Drawing.Point(0, 0);
            this.scLanguage.Name = "scLanguage";
            // 
            // scLanguage.Panel1
            // 
            this.scLanguage.Panel1.Controls.Add(this.btnLanguageDown);
            this.scLanguage.Panel1.Controls.Add(this.btnLanguageUp);
            // 
            // scLanguage.Panel2
            // 
            this.scLanguage.Panel2.Controls.Add(this.tvLanguage);
            this.scLanguage.Size = new System.Drawing.Size(908, 312);
            this.scLanguage.SplitterDistance = 115;
            this.scLanguage.TabIndex = 2;
            // 
            // btnLanguageDown
            // 
            this.btnLanguageDown.Location = new System.Drawing.Point(8, 46);
            this.btnLanguageDown.Name = "btnLanguageDown";
            this.btnLanguageDown.Size = new System.Drawing.Size(100, 26);
            this.btnLanguageDown.TabIndex = 2;
            this.btnLanguageDown.Text = "Move Down";
            this.btnLanguageDown.UseVisualStyleBackColor = true;
            this.btnLanguageDown.Click += new System.EventHandler(this.btnLanguageDown_Click);
            // 
            // btnLanguageUp
            // 
            this.btnLanguageUp.Location = new System.Drawing.Point(8, 14);
            this.btnLanguageUp.Name = "btnLanguageUp";
            this.btnLanguageUp.Size = new System.Drawing.Size(100, 26);
            this.btnLanguageUp.TabIndex = 1;
            this.btnLanguageUp.Text = "Move Up";
            this.btnLanguageUp.UseVisualStyleBackColor = true;
            this.btnLanguageUp.Click += new System.EventHandler(this.btnLanguageUp_Click);
            // 
            // tvLanguage
            // 
            this.tvLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvLanguage.HideSelection = false;
            this.tvLanguage.Location = new System.Drawing.Point(0, 0);
            this.tvLanguage.Name = "tvLanguage";
            treeNode1.Name = "nodeAmericanEnglish";
            treeNode1.Tag = "0";
            treeNode1.Text = "American English";
            treeNode2.Name = "nodeBritishEnglish";
            treeNode2.Tag = "1";
            treeNode2.Text = "British English";
            treeNode3.Name = "nodeJapanese";
            treeNode3.Tag = "2";
            treeNode3.Text = "Japanese";
            treeNode4.Name = "nodeFrench";
            treeNode4.Tag = "3";
            treeNode4.Text = "French";
            treeNode5.Name = "nodeGerman";
            treeNode5.Tag = "4";
            treeNode5.Text = "German";
            treeNode6.Name = "nodeLatinAmericanSpanish";
            treeNode6.Tag = "5";
            treeNode6.Text = "Latin American Spanish";
            treeNode7.Name = "nodeSpanish";
            treeNode7.Tag = "6";
            treeNode7.Text = "Spanish";
            treeNode8.Name = "nodeItalian";
            treeNode8.Tag = "7";
            treeNode8.Text = "Italian";
            treeNode9.Name = "nodeDutch";
            treeNode9.Tag = "8";
            treeNode9.Text = "Dutch";
            treeNode10.Name = "nodeCanadianFrench";
            treeNode10.Tag = "9";
            treeNode10.Text = "Canadian French";
            treeNode11.Name = "nodePortuguese";
            treeNode11.Tag = "10";
            treeNode11.Text = "Portuguese";
            treeNode12.Name = "nodeRussian";
            treeNode12.Tag = "11";
            treeNode12.Text = "Russian";
            treeNode13.Name = "nodeKorean";
            treeNode13.Tag = "12";
            treeNode13.Text = "Korean";
            treeNode14.Name = "nodeTaiwanese";
            treeNode14.Tag = "13";
            treeNode14.Text = "Taiwanese";
            treeNode15.Name = "nodeChinese";
            treeNode15.Tag = "14";
            treeNode15.Text = "Chinese";
            this.tvLanguage.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            this.tvLanguage.Size = new System.Drawing.Size(789, 312);
            this.tvLanguage.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ilGamesExtraSmall
            // 
            this.ilGamesExtraSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.ilGamesExtraSmall.ImageSize = new System.Drawing.Size(16, 16);
            this.ilGamesExtraSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ilGamesSmall
            // 
            this.ilGamesSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.ilGamesSmall.ImageSize = new System.Drawing.Size(32, 32);
            this.ilGamesSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ilGamesLarge
            // 
            this.ilGamesLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.ilGamesLarge.ImageSize = new System.Drawing.Size(128, 128);
            this.ilGamesLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ilGamesExtraLarge
            // 
            this.ilGamesExtraLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.ilGamesExtraLarge.ImageSize = new System.Drawing.Size(256, 256);
            this.ilGamesExtraLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 556);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Nintendo Switch SD to NSP Dumper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainerTop.Panel1.ResumeLayout(false);
            this.splitContainerTop.Panel1.PerformLayout();
            this.splitContainerTop.Panel2.ResumeLayout(false);
            this.splitContainerTop.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).EndInit();
            this.splitContainerTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGameIcon)).EndInit();
            this.tcTabs.ResumeLayout(false);
            this.tpLog.ResumeLayout(false);
            this.tpGames.ResumeLayout(false);
            this.scGames.Panel1.ResumeLayout(false);
            this.scGames.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scGames)).EndInit();
            this.scGames.ResumeLayout(false);
            this.tpPreferedLanguage.ResumeLayout(false);
            this.scLanguage.Panel1.ResumeLayout(false);
            this.scLanguage.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scLanguage)).EndInit();
            this.scLanguage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnSelectSD;
        private TextBox txtSDKey;
        private Label label1;
        private FolderBrowserDialog fbdSDCard;
        private Button btdDecryption;
        private FolderBrowserDialog fbdDecryptionPath;
        private Button btnFindSDKey;
        private Button btnSelectSystemPath;
        private Button btnLoadRSAKEK;
        private TextBox txtRSAKEK;
        private Label label2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private Button button1;
        private Button btnDecryptNCA;
        private Button btnPackNSP;
        private Button btnSelectNSPPath;
        private ListBox listStatus;
        private SplitContainer splitContainer1;
        private ToolStripProgressBar tsProgress;
        private TextBox txtMessage;
        private SplitContainer splitContainerTop;
        private ToolStripStatusLabel tsProgressText;
        private Timer timer1;
        private Button btnParseNCA;
        private TabControl tcTabs;
        private TabPage tpLog;
        private TabPage tpGames;
        private TreeView tvGames;
        private TabPage tpPreferedLanguage;
        private SplitContainer scLanguage;
        private Button btnLanguageDown;
        private Button btnLanguageUp;
        private TreeView tvLanguage;
        private ImageList ilGames;
        private SplitContainer scGames;
        private Button btnLargerIcons;
        private Button btnSmallerIcon;
        private ImageList ilGamesExtraSmall;
        private ImageList ilGamesSmall;
        private ImageList ilGamesLarge;
        private ImageList ilGamesExtraLarge;
        private Button btnPackSelectedNSP;
        private Button btnDeleteFromSD;
        private PictureBox pbGameIcon;
    }
}

