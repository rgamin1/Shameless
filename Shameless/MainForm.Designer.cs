﻿namespace Shameless
{
	partial class MainForm
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
			if (disposing && (this.components != null))
			{
				this.components.Dispose();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.statusProgressbar = new System.Windows.Forms.ToolStripProgressBar();
			this.currentTitleStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.currentActionLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.titlesCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.titlesListView = new System.Windows.Forms.ListView();
			this.titleIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.encryptedTitleKeyHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.regionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.typeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.serialHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.searchBox = new System.Windows.Forms.TextBox();
			this.allTitlesListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.generateQrCodeButton = new System.Windows.Forms.Button();
			this.delayTimer = new System.Windows.Forms.Timer(this.components);
			this.showSizeCheckbox = new System.Windows.Forms.CheckBox();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusProgressbar,
            this.currentTitleStatusLabel,
            this.currentActionLabel,
            this.titlesCountLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 429);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(824, 22);
			this.statusStrip.TabIndex = 1;
			this.statusStrip.Text = "Status";
			// 
			// statusProgressbar
			// 
			this.statusProgressbar.MarqueeAnimationSpeed = 30;
			this.statusProgressbar.Name = "statusProgressbar";
			this.statusProgressbar.Size = new System.Drawing.Size(100, 16);
			// 
			// currentTitleStatusLabel
			// 
			this.currentTitleStatusLabel.Name = "currentTitleStatusLabel";
			this.currentTitleStatusLabel.Size = new System.Drawing.Size(30, 17);
			this.currentTitleStatusLabel.Text = "Title";
			// 
			// currentActionLabel
			// 
			this.currentActionLabel.Name = "currentActionLabel";
			this.currentActionLabel.Size = new System.Drawing.Size(85, 17);
			this.currentActionLabel.Text = "Current Action";
			// 
			// titlesCountLabel
			// 
			this.titlesCountLabel.Name = "titlesCountLabel";
			this.titlesCountLabel.Size = new System.Drawing.Size(561, 17);
			this.titlesCountLabel.Spring = true;
			this.titlesCountLabel.Text = "0 titles";
			this.titlesCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// titlesListView
			// 
			this.titlesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.titlesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleIDHeader,
            this.encryptedTitleKeyHeader,
            this.nameHeader,
            this.regionHeader,
            this.typeHeader,
            this.serialHeader});
			this.titlesListView.FullRowSelect = true;
			this.titlesListView.GridLines = true;
			this.titlesListView.Location = new System.Drawing.Point(12, 41);
			this.titlesListView.Name = "titlesListView";
			this.titlesListView.Size = new System.Drawing.Size(800, 356);
			this.titlesListView.TabIndex = 2;
			this.titlesListView.UseCompatibleStateImageBehavior = false;
			this.titlesListView.View = System.Windows.Forms.View.Details;
			this.titlesListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.titlesListView_ColumnClick);
			// 
			// titleIDHeader
			// 
			this.titleIDHeader.Text = "Title ID";
			// 
			// encryptedTitleKeyHeader
			// 
			this.encryptedTitleKeyHeader.Text = "Encrypted Title Key";
			this.encryptedTitleKeyHeader.Width = 108;
			// 
			// nameHeader
			// 
			this.nameHeader.Text = "Name";
			this.nameHeader.Width = 283;
			// 
			// regionHeader
			// 
			this.regionHeader.Text = "Region";
			this.regionHeader.Width = 63;
			// 
			// typeHeader
			// 
			this.typeHeader.Text = "Type";
			this.typeHeader.Width = 69;
			// 
			// serialHeader
			// 
			this.serialHeader.Text = "Serial";
			this.serialHeader.Width = 44;
			// 
			// searchBox
			// 
			this.searchBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.searchBox.Location = new System.Drawing.Point(12, 15);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(185, 20);
			this.searchBox.TabIndex = 3;
			this.searchBox.Text = "Search...";
			this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
			this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
			// 
			// allTitlesListView
			// 
			this.allTitlesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.allTitlesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
			this.allTitlesListView.FullRowSelect = true;
			this.allTitlesListView.GridLines = true;
			this.allTitlesListView.Location = new System.Drawing.Point(800, 12);
			this.allTitlesListView.Name = "allTitlesListView";
			this.allTitlesListView.Size = new System.Drawing.Size(12, 10);
			this.allTitlesListView.TabIndex = 4;
			this.allTitlesListView.UseCompatibleStateImageBehavior = false;
			this.allTitlesListView.View = System.Windows.Forms.View.Details;
			this.allTitlesListView.Visible = false;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Title ID";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Encrypted Title Key";
			this.columnHeader2.Width = 108;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Name";
			this.columnHeader3.Width = 283;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Region";
			this.columnHeader5.Width = 63;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Type";
			this.columnHeader6.Width = 69;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Serial";
			this.columnHeader7.Width = 44;
			// 
			// generateQrCodeButton
			// 
			this.generateQrCodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.generateQrCodeButton.Location = new System.Drawing.Point(668, 403);
			this.generateQrCodeButton.Name = "generateQrCodeButton";
			this.generateQrCodeButton.Size = new System.Drawing.Size(144, 23);
			this.generateQrCodeButton.TabIndex = 6;
			this.generateQrCodeButton.Text = "Generate QR Code for FBI";
			this.generateQrCodeButton.UseVisualStyleBackColor = true;
			this.generateQrCodeButton.Click += new System.EventHandler(this.generateQrCodeButton_Click);
			// 
			// delayTimer
			// 
			this.delayTimer.Interval = 500;
			this.delayTimer.Tick += new System.EventHandler(this.delayTimer_Tick);
			// 
			// showSizeCheckbox
			// 
			this.showSizeCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.showSizeCheckbox.AutoSize = true;
			this.showSizeCheckbox.Location = new System.Drawing.Point(582, 407);
			this.showSizeCheckbox.Name = "showSizeCheckbox";
			this.showSizeCheckbox.Size = new System.Drawing.Size(80, 17);
			this.showSizeCheckbox.TabIndex = 7;
			this.showSizeCheckbox.Text = "Show size?";
			this.showSizeCheckbox.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 451);
			this.Controls.Add(this.showSizeCheckbox);
			this.Controls.Add(this.generateQrCodeButton);
			this.Controls.Add(this.allTitlesListView);
			this.Controls.Add(this.searchBox);
			this.Controls.Add(this.titlesListView);
			this.Controls.Add(this.statusStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(840, 490);
			this.Name = "MainForm";
			this.Text = " Shameless";
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel currentActionLabel;

		public System.Windows.Forms.ListView titlesListView;
		private System.Windows.Forms.ColumnHeader titleIDHeader;
		private System.Windows.Forms.ColumnHeader encryptedTitleKeyHeader;
		private System.Windows.Forms.ColumnHeader nameHeader;
		private System.Windows.Forms.ColumnHeader regionHeader;
		private System.Windows.Forms.ColumnHeader typeHeader;
		private System.Windows.Forms.ColumnHeader serialHeader;
		private System.Windows.Forms.TextBox searchBox;

		public System.Windows.Forms.ListView allTitlesListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.Button generateQrCodeButton;
		private System.Windows.Forms.Timer delayTimer;
		private System.Windows.Forms.ToolStripProgressBar statusProgressbar;
		private System.Windows.Forms.ToolStripStatusLabel currentTitleStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel titlesCountLabel;
		private System.Windows.Forms.CheckBox showSizeCheckbox;
	}
}
