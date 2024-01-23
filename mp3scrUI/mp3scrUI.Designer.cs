using System.Windows.Forms;
using System;

namespace mp3scrUI
{
    partial class mp3scrUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scrapesDataGridView = new System.Windows.Forms.DataGridView();
            this.Enabled_ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrlPrefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestFolderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExistingFeedFolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuidPrefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mp3Filter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndirectFilter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indirect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ChannelTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChannelNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SortDescending = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RetainOrphans = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.StripBaseName = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PrependRelative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefreshDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FtpPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FtpUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FtpPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermissionRevoked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllowHttps = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Wraparound = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaxWebRequests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaintenanceA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaintenanceB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaintenanceC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configFileNameTextBox = new System.Windows.Forms.TextBox();
            this.configFileLabel = new System.Windows.Forms.Label();
            this.testIndexLabel = new System.Windows.Forms.Label();
            this.testIndexTextBox = new System.Windows.Forms.TextBox();
            this.intListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scrapesDataGridView)).BeginInit();
            this.rowContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1180, 54);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(80, 50);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(275, 48);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(275, 48);
            this.saveToolStripMenuItem.Text = "Save As...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(275, 48);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDFLinkToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(95, 50);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // pDFLinkToolStripMenuItem
            // 
            this.pDFLinkToolStripMenuItem.Name = "pDFLinkToolStripMenuItem";
            this.pDFLinkToolStripMenuItem.Size = new System.Drawing.Size(360, 48);
            this.pDFLinkToolStripMenuItem.Text = "mp3scraper PDF";
            this.pDFLinkToolStripMenuItem.Click += new System.EventHandler(this.pdfLinkToolStripMenuItem_Click);
            // 
            // scrapesDataGridView
            // 
            this.scrapesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrapesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scrapesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Enabled_,
            this.Index,
            this.Url,
            this.UrlPrefix,
            this.DestBase,
            this.DestFolderName,
            this.ExistingFeedFolder,
            this.GuidPrefix,
            this.Mp3Filter,
            this.IndirectFilter,
            this.Indirect,
            this.ChannelTitle,
            this.ChannelNotes,
            this.SortDescending,
            this.RetainOrphans,
            this.StripBaseName,
            this.PrependRelative,
            this.RefreshDays,
            this.FtpPath,
            this.FtpUserName,
            this.FtpPassword,
            this.PermissionRevoked,
            this.AllowHttps,
            this.Wraparound,
            this.MaxWebRequests,
            this.MaintenanceA,
            this.MaintenanceB,
            this.MaintenanceC});
            this.scrapesDataGridView.ContextMenuStrip = this.rowContextMenuStrip;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.scrapesDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.scrapesDataGridView.Location = new System.Drawing.Point(12, 169);
            this.scrapesDataGridView.MultiSelect = false;
            this.scrapesDataGridView.Name = "scrapesDataGridView";
            this.scrapesDataGridView.RowHeadersWidth = 92;
            this.scrapesDataGridView.RowTemplate.Height = 37;
            this.scrapesDataGridView.Size = new System.Drawing.Size(1156, 767);
            this.scrapesDataGridView.TabIndex = 2;
            this.scrapesDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.scrapesDataGridView_CellMouseDown);
            this.scrapesDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.scrapesDataGridView_CellValidating);
            this.scrapesDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.scrapesDataGridView_CellValueChanged);
            this.scrapesDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.scrapesDataGridView_CurrentCellDirtyStateChanged);
            this.scrapesDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.scrapesDataGridView_DefaultValuesNeeded);
            // 
            // Enabled_
            // 
            this.Enabled_.HeaderText = "Enabled";
            this.Enabled_.MinimumWidth = 50;
            this.Enabled_.Name = "Enabled_";
            this.Enabled_.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Enabled_.ToolTipText = "Enabled";
            this.Enabled_.Width = 50;
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.MaxInputLength = 4;
            this.Index.MinimumWidth = 90;
            this.Index.Name = "Index";
            this.Index.ToolTipText = "Index";
            this.Index.Width = 90;
            // 
            // Url
            // 
            this.Url.HeaderText = "Url";
            this.Url.MaxInputLength = 256;
            this.Url.MinimumWidth = 11;
            this.Url.Name = "Url";
            this.Url.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Url.ToolTipText = "Url";
            this.Url.Width = 225;
            // 
            // UrlPrefix
            // 
            this.UrlPrefix.HeaderText = "UrlPrefix";
            this.UrlPrefix.MaxInputLength = 256;
            this.UrlPrefix.MinimumWidth = 80;
            this.UrlPrefix.Name = "UrlPrefix";
            this.UrlPrefix.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UrlPrefix.ToolTipText = "UrlPrefix";
            this.UrlPrefix.Width = 80;
            // 
            // DestBase
            // 
            this.DestBase.HeaderText = "DestBase";
            this.DestBase.MaxInputLength = 256;
            this.DestBase.MinimumWidth = 120;
            this.DestBase.Name = "DestBase";
            this.DestBase.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DestBase.ToolTipText = "DestBase";
            this.DestBase.Width = 120;
            // 
            // DestFolderName
            // 
            this.DestFolderName.HeaderText = "DestFolderName";
            this.DestFolderName.MaxInputLength = 256;
            this.DestFolderName.MinimumWidth = 11;
            this.DestFolderName.Name = "DestFolderName";
            this.DestFolderName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DestFolderName.ToolTipText = "DestFolderName";
            this.DestFolderName.Width = 225;
            // 
            // ExistingFeedFolder
            // 
            this.ExistingFeedFolder.HeaderText = "ExistingFeedFolder";
            this.ExistingFeedFolder.MaxInputLength = 256;
            this.ExistingFeedFolder.MinimumWidth = 11;
            this.ExistingFeedFolder.Name = "ExistingFeedFolder";
            this.ExistingFeedFolder.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ExistingFeedFolder.ToolTipText = "ExistingFeedFolder";
            this.ExistingFeedFolder.Width = 225;
            // 
            // GuidPrefix
            // 
            this.GuidPrefix.HeaderText = "GuidPrefix";
            this.GuidPrefix.MaxInputLength = 256;
            this.GuidPrefix.MinimumWidth = 120;
            this.GuidPrefix.Name = "GuidPrefix";
            this.GuidPrefix.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GuidPrefix.ToolTipText = "GuidPrefix";
            this.GuidPrefix.Width = 120;
            // 
            // Mp3Filter
            // 
            this.Mp3Filter.HeaderText = "Mp3Filter";
            this.Mp3Filter.MaxInputLength = 256;
            this.Mp3Filter.MinimumWidth = 80;
            this.Mp3Filter.Name = "Mp3Filter";
            this.Mp3Filter.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Mp3Filter.ToolTipText = "Mp3Filter";
            this.Mp3Filter.Width = 80;
            // 
            // IndirectFilter
            // 
            this.IndirectFilter.HeaderText = "IndirectFilter";
            this.IndirectFilter.MaxInputLength = 256;
            this.IndirectFilter.MinimumWidth = 50;
            this.IndirectFilter.Name = "IndirectFilter";
            this.IndirectFilter.ReadOnly = true;
            this.IndirectFilter.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IndirectFilter.ToolTipText = "IndirectFilter";
            this.IndirectFilter.Width = 50;
            // 
            // Indirect
            // 
            this.Indirect.HeaderText = "Indirect";
            this.Indirect.MinimumWidth = 50;
            this.Indirect.Name = "Indirect";
            this.Indirect.ReadOnly = true;
            this.Indirect.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Indirect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Indirect.ToolTipText = "Indirect";
            this.Indirect.Width = 50;
            // 
            // ChannelTitle
            // 
            this.ChannelTitle.HeaderText = "ChannelTitle";
            this.ChannelTitle.MaxInputLength = 256;
            this.ChannelTitle.MinimumWidth = 11;
            this.ChannelTitle.Name = "ChannelTitle";
            this.ChannelTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ChannelTitle.ToolTipText = "ChannelTitle";
            this.ChannelTitle.Width = 225;
            // 
            // ChannelNotes
            // 
            this.ChannelNotes.HeaderText = "ChannelNotes";
            this.ChannelNotes.MaxInputLength = 256;
            this.ChannelNotes.MinimumWidth = 11;
            this.ChannelNotes.Name = "ChannelNotes";
            this.ChannelNotes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ChannelNotes.ToolTipText = "ChannelNotes";
            this.ChannelNotes.Width = 225;
            // 
            // SortDescending
            // 
            this.SortDescending.HeaderText = "SortDescending";
            this.SortDescending.MinimumWidth = 90;
            this.SortDescending.Name = "SortDescending";
            this.SortDescending.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SortDescending.ToolTipText = "SortDescending";
            this.SortDescending.Width = 90;
            // 
            // RetainOrphans
            // 
            this.RetainOrphans.HeaderText = "RetainOrphans";
            this.RetainOrphans.MinimumWidth = 90;
            this.RetainOrphans.Name = "RetainOrphans";
            this.RetainOrphans.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RetainOrphans.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RetainOrphans.ToolTipText = "RetainOrphans";
            this.RetainOrphans.Width = 90;
            // 
            // StripBaseName
            // 
            this.StripBaseName.HeaderText = "StripBaseName";
            this.StripBaseName.MinimumWidth = 90;
            this.StripBaseName.Name = "StripBaseName";
            this.StripBaseName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StripBaseName.ToolTipText = "StripBaseName";
            this.StripBaseName.Width = 90;
            // 
            // PrependRelative
            // 
            this.PrependRelative.HeaderText = "PrependRelative";
            this.PrependRelative.MaxInputLength = 256;
            this.PrependRelative.MinimumWidth = 11;
            this.PrependRelative.Name = "PrependRelative";
            this.PrependRelative.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrependRelative.ToolTipText = "PrependRelative";
            this.PrependRelative.Width = 225;
            // 
            // RefreshDays
            // 
            this.RefreshDays.HeaderText = "RefreshDays";
            this.RefreshDays.MaxInputLength = 3;
            this.RefreshDays.MinimumWidth = 90;
            this.RefreshDays.Name = "RefreshDays";
            this.RefreshDays.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RefreshDays.ToolTipText = "RefreshDays";
            this.RefreshDays.Width = 90;
            // 
            // FtpPath
            // 
            this.FtpPath.HeaderText = "FtpPath";
            this.FtpPath.MaxInputLength = 256;
            this.FtpPath.MinimumWidth = 11;
            this.FtpPath.Name = "FtpPath";
            this.FtpPath.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FtpPath.ToolTipText = "FtpPath";
            this.FtpPath.Width = 225;
            // 
            // FtpUserName
            // 
            this.FtpUserName.HeaderText = "FtpUserName";
            this.FtpUserName.MaxInputLength = 256;
            this.FtpUserName.MinimumWidth = 100;
            this.FtpUserName.Name = "FtpUserName";
            this.FtpUserName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FtpUserName.ToolTipText = "FtpUserName";
            this.FtpUserName.Width = 225;
            // 
            // FtpPassword
            // 
            this.FtpPassword.HeaderText = "FtpPassword";
            this.FtpPassword.MaxInputLength = 256;
            this.FtpPassword.MinimumWidth = 100;
            this.FtpPassword.Name = "FtpPassword";
            this.FtpPassword.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FtpPassword.ToolTipText = "FtpPassword";
            this.FtpPassword.Width = 225;
            // 
            // PermissionRevoked
            // 
            this.PermissionRevoked.HeaderText = "PermissionRevoked";
            this.PermissionRevoked.MaxInputLength = 256;
            this.PermissionRevoked.MinimumWidth = 100;
            this.PermissionRevoked.Name = "PermissionRevoked";
            this.PermissionRevoked.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PermissionRevoked.ToolTipText = "PermissionRevoked";
            this.PermissionRevoked.Width = 225;
            // 
            // AllowHttps
            // 
            this.AllowHttps.HeaderText = "AllowHttps";
            this.AllowHttps.MinimumWidth = 80;
            this.AllowHttps.Name = "AllowHttps";
            this.AllowHttps.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AllowHttps.ToolTipText = "AllowHttps";
            this.AllowHttps.Width = 80;
            // 
            // Wraparound
            // 
            this.Wraparound.HeaderText = "Wraparound";
            this.Wraparound.MinimumWidth = 80;
            this.Wraparound.Name = "Wraparound";
            this.Wraparound.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Wraparound.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Wraparound.ToolTipText = "Wraparound";
            this.Wraparound.Width = 80;
            // 
            // MaxWebRequests
            // 
            this.MaxWebRequests.HeaderText = "MaxWebRequests";
            this.MaxWebRequests.MaxInputLength = 3;
            this.MaxWebRequests.MinimumWidth = 90;
            this.MaxWebRequests.Name = "MaxWebRequests";
            this.MaxWebRequests.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MaxWebRequests.ToolTipText = "MaxWebRequests";
            this.MaxWebRequests.Width = 90;
            // 
            // MaintenanceA
            // 
            this.MaintenanceA.HeaderText = "MaintenanceA";
            this.MaintenanceA.MaxInputLength = 256;
            this.MaintenanceA.MinimumWidth = 11;
            this.MaintenanceA.Name = "MaintenanceA";
            this.MaintenanceA.Width = 225;
            // 
            // MaintenanceB
            // 
            this.MaintenanceB.HeaderText = "MaintenanceB";
            this.MaintenanceB.MaxInputLength = 256;
            this.MaintenanceB.MinimumWidth = 11;
            this.MaintenanceB.Name = "MaintenanceB";
            this.MaintenanceB.Width = 225;
            // 
            // MaintenanceC
            // 
            this.MaintenanceC.HeaderText = "MaintenanceC";
            this.MaintenanceC.MaxInputLength = 256;
            this.MaintenanceC.MinimumWidth = 11;
            this.MaintenanceC.Name = "MaintenanceC";
            this.MaintenanceC.Width = 225;
            // 
            // rowContextMenuStrip
            // 
            this.rowContextMenuStrip.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.rowContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeRowToolStripMenuItem});
            this.rowContextMenuStrip.Name = "rowContextMenuStrip";
            this.rowContextMenuStrip.Size = new System.Drawing.Size(248, 48);
            // 
            // removeRowToolStripMenuItem
            // 
            this.removeRowToolStripMenuItem.Name = "removeRowToolStripMenuItem";
            this.removeRowToolStripMenuItem.Size = new System.Drawing.Size(247, 44);
            this.removeRowToolStripMenuItem.Text = "Remove Row";
            this.removeRowToolStripMenuItem.Click += new System.EventHandler(this.removeRowToolStripMenuItem_Click);
            // 
            // configFileNameTextBox
            // 
            this.configFileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configFileNameTextBox.Location = new System.Drawing.Point(145, 57);
            this.configFileNameTextBox.Name = "configFileNameTextBox";
            this.configFileNameTextBox.ReadOnly = true;
            this.configFileNameTextBox.Size = new System.Drawing.Size(1023, 35);
            this.configFileNameTextBox.TabIndex = 3;
            // 
            // configFileLabel
            // 
            this.configFileLabel.AutoSize = true;
            this.configFileLabel.Location = new System.Drawing.Point(12, 57);
            this.configFileLabel.Name = "configFileLabel";
            this.configFileLabel.Size = new System.Drawing.Size(127, 29);
            this.configFileLabel.TabIndex = 4;
            this.configFileLabel.Text = "Config file:";
            // 
            // testIndexLabel
            // 
            this.testIndexLabel.AutoSize = true;
            this.testIndexLabel.Location = new System.Drawing.Point(12, 114);
            this.testIndexLabel.Name = "testIndexLabel";
            this.testIndexLabel.Size = new System.Drawing.Size(131, 29);
            this.testIndexLabel.TabIndex = 5;
            this.testIndexLabel.Text = "Test index:";
            // 
            // testIndexTextBox
            // 
            this.testIndexTextBox.Location = new System.Drawing.Point(145, 114);
            this.testIndexTextBox.MaxLength = 4;
            this.testIndexTextBox.Name = "testIndexTextBox";
            this.testIndexTextBox.Size = new System.Drawing.Size(170, 35);
            this.testIndexTextBox.TabIndex = 6;
            this.testIndexTextBox.TextChanged += new System.EventHandler(this.testIndexTextBox_TextChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(457, 114);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(210, 35);
            this.searchTextBox.TabIndex = 8;
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(690, 117);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(284, 29);
            this.searchLabel.TabIndex = 9;
            this.searchLabel.Text = "Type search text, ENTER";
            // 
            // mp3scrUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 948);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.testIndexTextBox);
            this.Controls.Add(this.testIndexLabel);
            this.Controls.Add(this.configFileLabel);
            this.Controls.Add(this.configFileNameTextBox);
            this.Controls.Add(this.scrapesDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mp3scrUI";
            this.Text = "mp3scrUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mp3scrUI_FormClosing);
            this.Load += new System.EventHandler(this.mp3scrUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scrapesDataGridView)).EndInit();
            this.rowContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.intListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.DataGridView scrapesDataGridView;
        private System.Windows.Forms.TextBox configFileNameTextBox;
        private System.Windows.Forms.Label configFileLabel;
        private System.Windows.Forms.Label testIndexLabel;
        private System.Windows.Forms.TextBox testIndexTextBox;
        private System.Windows.Forms.ContextMenuStrip rowContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem removeRowToolStripMenuItem;
        private System.Windows.Forms.BindingSource intListBindingSource;
        private DataGridViewCheckBoxColumn Enabled_;
        private DataGridViewTextBoxColumn Index;
        private DataGridViewTextBoxColumn Url;
        private DataGridViewTextBoxColumn UrlPrefix;
        private DataGridViewTextBoxColumn DestBase;
        private DataGridViewTextBoxColumn DestFolderName;
        private DataGridViewTextBoxColumn ExistingFeedFolder;
        private DataGridViewTextBoxColumn GuidPrefix;
        private DataGridViewTextBoxColumn Mp3Filter;
        private DataGridViewTextBoxColumn IndirectFilter;
        private DataGridViewCheckBoxColumn Indirect;
        private DataGridViewTextBoxColumn ChannelTitle;
        private DataGridViewTextBoxColumn ChannelNotes;
        private DataGridViewCheckBoxColumn SortDescending;
        private DataGridViewCheckBoxColumn RetainOrphans;
        private DataGridViewCheckBoxColumn StripBaseName;
        private DataGridViewTextBoxColumn PrependRelative;
        private DataGridViewTextBoxColumn RefreshDays;
        private DataGridViewTextBoxColumn FtpPath;
        private DataGridViewTextBoxColumn FtpUserName;
        private DataGridViewTextBoxColumn FtpPassword;
        private DataGridViewTextBoxColumn PermissionRevoked;
        private DataGridViewCheckBoxColumn AllowHttps;
        private DataGridViewCheckBoxColumn Wraparound;
        private DataGridViewTextBoxColumn MaxWebRequests;
        private DataGridViewTextBoxColumn MaintenanceA;
        private DataGridViewTextBoxColumn MaintenanceB;
        private DataGridViewTextBoxColumn MaintenanceC;
        private TextBox searchTextBox;
        private Label searchLabel;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem pDFLinkToolStripMenuItem;
    }
}

