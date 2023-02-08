
namespace Music_Manager {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.PlayImageList = new System.Windows.Forms.ImageList(this.components);
			this.ListsPanel = new System.Windows.Forms.Panel();
			this.ReproListsDGV = new System.Windows.Forms.DataGridView();
			this.SearchPage = new System.Windows.Forms.TabPage();
			this.DatabaseAddingButton = new System.Windows.Forms.Button();
			this.SongsContainer = new System.Windows.Forms.FlowLayoutPanel();
			this.FilterTextBox = new System.Windows.Forms.TextBox();
			this.ControllerPage = new System.Windows.Forms.TabPage();
			this.ImagePanel = new System.Windows.Forms.Panel();
			this.SongImagePB = new System.Windows.Forms.PictureBox();
			this.ControllerPanel = new System.Windows.Forms.Panel();
			this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
			this.DurationTrackBar = new System.Windows.Forms.TrackBar();
			this.ShuffleButton = new System.Windows.Forms.Button();
			this.LoopButton = new System.Windows.Forms.Button();
			this.PreviousButton = new System.Windows.Forms.Button();
			this.NextButton = new System.Windows.Forms.Button();
			this.PlayButton = new System.Windows.Forms.Button();
			this.TabsController = new System.Windows.Forms.TabControl();
			this.SearchPageButton = new System.Windows.Forms.Button();
			this.ControllerPageButton = new System.Windows.Forms.Button();
			this.ListsPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ReproListsDGV)).BeginInit();
			this.SearchPage.SuspendLayout();
			this.ControllerPage.SuspendLayout();
			this.ImagePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SongImagePB)).BeginInit();
			this.ControllerPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DurationTrackBar)).BeginInit();
			this.TabsController.SuspendLayout();
			this.SuspendLayout();
			// 
			// PlayImageList
			// 
			this.PlayImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("PlayImageList.ImageStream")));
			this.PlayImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.PlayImageList.Images.SetKeyName(0, "play_arrow_FILL0_wght400_GRAD0_opsz48.png");
			this.PlayImageList.Images.SetKeyName(1, "pause_FILL0_wght400_GRAD0_opsz48.png");
			// 
			// ListsPanel
			// 
			this.ListsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.ListsPanel.Controls.Add(this.ReproListsDGV);
			this.ListsPanel.Location = new System.Drawing.Point(13, 36);
			this.ListsPanel.Name = "ListsPanel";
			this.ListsPanel.Size = new System.Drawing.Size(276, 589);
			this.ListsPanel.TabIndex = 3;
			// 
			// ReproListsDGV
			// 
			this.ReproListsDGV.AllowUserToAddRows = false;
			this.ReproListsDGV.AllowUserToDeleteRows = false;
			this.ReproListsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ReproListsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ReproListsDGV.Location = new System.Drawing.Point(0, 0);
			this.ReproListsDGV.Name = "ReproListsDGV";
			this.ReproListsDGV.ReadOnly = true;
			this.ReproListsDGV.Size = new System.Drawing.Size(276, 589);
			this.ReproListsDGV.TabIndex = 0;
			// 
			// SearchPage
			// 
			this.SearchPage.BackColor = System.Drawing.SystemColors.Control;
			this.SearchPage.Controls.Add(this.DatabaseAddingButton);
			this.SearchPage.Controls.Add(this.SongsContainer);
			this.SearchPage.Controls.Add(this.FilterTextBox);
			this.SearchPage.Location = new System.Drawing.Point(4, 24);
			this.SearchPage.Name = "SearchPage";
			this.SearchPage.Padding = new System.Windows.Forms.Padding(3);
			this.SearchPage.Size = new System.Drawing.Size(618, 570);
			this.SearchPage.TabIndex = 1;
			this.SearchPage.Text = "tabPage2";
			// 
			// DatabaseAddingButton
			// 
			this.DatabaseAddingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DatabaseAddingButton.Location = new System.Drawing.Point(546, 7);
			this.DatabaseAddingButton.Name = "DatabaseAddingButton";
			this.DatabaseAddingButton.Size = new System.Drawing.Size(65, 41);
			this.DatabaseAddingButton.TabIndex = 3;
			this.DatabaseAddingButton.Text = "Añadir";
			this.DatabaseAddingButton.UseVisualStyleBackColor = true;
			this.DatabaseAddingButton.Click += new System.EventHandler(this.DatabaseAddingButton_Click);
			// 
			// SongsContainer
			// 
			this.SongsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SongsContainer.AutoScroll = true;
			this.SongsContainer.Location = new System.Drawing.Point(6, 54);
			this.SongsContainer.Name = "SongsContainer";
			this.SongsContainer.Size = new System.Drawing.Size(606, 510);
			this.SongsContainer.TabIndex = 2;
			// 
			// FilterTextBox
			// 
			this.FilterTextBox.Location = new System.Drawing.Point(6, 6);
			this.FilterTextBox.Name = "FilterTextBox";
			this.FilterTextBox.Size = new System.Drawing.Size(100, 20);
			this.FilterTextBox.TabIndex = 0;
			this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
			// 
			// ControllerPage
			// 
			this.ControllerPage.BackColor = System.Drawing.SystemColors.Control;
			this.ControllerPage.Controls.Add(this.ImagePanel);
			this.ControllerPage.Controls.Add(this.ControllerPanel);
			this.ControllerPage.Location = new System.Drawing.Point(4, 24);
			this.ControllerPage.Name = "ControllerPage";
			this.ControllerPage.Padding = new System.Windows.Forms.Padding(3);
			this.ControllerPage.Size = new System.Drawing.Size(618, 570);
			this.ControllerPage.TabIndex = 0;
			this.ControllerPage.Text = "tabPage1";
			// 
			// ImagePanel
			// 
			this.ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImagePanel.BackColor = System.Drawing.Color.Transparent;
			this.ImagePanel.Controls.Add(this.SongImagePB);
			this.ImagePanel.Location = new System.Drawing.Point(6, 6);
			this.ImagePanel.Name = "ImagePanel";
			this.ImagePanel.Size = new System.Drawing.Size(606, 335);
			this.ImagePanel.TabIndex = 1;
			// 
			// SongImagePB
			// 
			this.SongImagePB.BackColor = System.Drawing.SystemColors.Control;
			this.SongImagePB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SongImagePB.Location = new System.Drawing.Point(0, 0);
			this.SongImagePB.Name = "SongImagePB";
			this.SongImagePB.Size = new System.Drawing.Size(606, 335);
			this.SongImagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.SongImagePB.TabIndex = 0;
			this.SongImagePB.TabStop = false;
			// 
			// ControllerPanel
			// 
			this.ControllerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ControllerPanel.BackColor = System.Drawing.SystemColors.Control;
			this.ControllerPanel.Controls.Add(this.VolumeTrackBar);
			this.ControllerPanel.Controls.Add(this.DurationTrackBar);
			this.ControllerPanel.Controls.Add(this.ShuffleButton);
			this.ControllerPanel.Controls.Add(this.LoopButton);
			this.ControllerPanel.Controls.Add(this.PreviousButton);
			this.ControllerPanel.Controls.Add(this.NextButton);
			this.ControllerPanel.Controls.Add(this.PlayButton);
			this.ControllerPanel.Location = new System.Drawing.Point(6, 347);
			this.ControllerPanel.Name = "ControllerPanel";
			this.ControllerPanel.Size = new System.Drawing.Size(606, 217);
			this.ControllerPanel.TabIndex = 0;
			// 
			// VolumeTrackBar
			// 
			this.VolumeTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.VolumeTrackBar.Location = new System.Drawing.Point(558, 86);
			this.VolumeTrackBar.Maximum = 100;
			this.VolumeTrackBar.Name = "VolumeTrackBar";
			this.VolumeTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.VolumeTrackBar.Size = new System.Drawing.Size(45, 104);
			this.VolumeTrackBar.TabIndex = 7;
			this.VolumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
			this.VolumeTrackBar.Value = 50;
			this.VolumeTrackBar.ValueChanged += new System.EventHandler(this.VolumeTrackBar_ValueChanged);
			// 
			// DurationTrackBar
			// 
			this.DurationTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.DurationTrackBar.Location = new System.Drawing.Point(137, 59);
			this.DurationTrackBar.Name = "DurationTrackBar";
			this.DurationTrackBar.Size = new System.Drawing.Size(323, 45);
			this.DurationTrackBar.TabIndex = 6;
			this.DurationTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
			// 
			// ShuffleButton
			// 
			this.ShuffleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.ShuffleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShuffleButton.BackgroundImage")));
			this.ShuffleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ShuffleButton.Location = new System.Drawing.Point(146, 122);
			this.ShuffleButton.Name = "ShuffleButton";
			this.ShuffleButton.Size = new System.Drawing.Size(50, 50);
			this.ShuffleButton.TabIndex = 4;
			this.ShuffleButton.UseVisualStyleBackColor = true;
			this.ShuffleButton.Click += new System.EventHandler(this.ShuffleButton_Click);
			// 
			// LoopButton
			// 
			this.LoopButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.LoopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoopButton.BackgroundImage")));
			this.LoopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.LoopButton.Location = new System.Drawing.Point(410, 122);
			this.LoopButton.Name = "LoopButton";
			this.LoopButton.Size = new System.Drawing.Size(50, 50);
			this.LoopButton.TabIndex = 3;
			this.LoopButton.UseVisualStyleBackColor = true;
			this.LoopButton.Click += new System.EventHandler(this.LoopButton_Click);
			// 
			// PreviousButton
			// 
			this.PreviousButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.PreviousButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PreviousButton.BackgroundImage")));
			this.PreviousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.PreviousButton.Location = new System.Drawing.Point(212, 122);
			this.PreviousButton.Name = "PreviousButton";
			this.PreviousButton.Size = new System.Drawing.Size(50, 50);
			this.PreviousButton.TabIndex = 2;
			this.PreviousButton.UseVisualStyleBackColor = true;
			this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
			// 
			// NextButton
			// 
			this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.NextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NextButton.BackgroundImage")));
			this.NextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.NextButton.Location = new System.Drawing.Point(344, 122);
			this.NextButton.Name = "NextButton";
			this.NextButton.Size = new System.Drawing.Size(50, 50);
			this.NextButton.TabIndex = 1;
			this.NextButton.UseVisualStyleBackColor = true;
			this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
			// 
			// PlayButton
			// 
			this.PlayButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.PlayButton.ImageIndex = 0;
			this.PlayButton.ImageList = this.PlayImageList;
			this.PlayButton.Location = new System.Drawing.Point(278, 122);
			this.PlayButton.Name = "PlayButton";
			this.PlayButton.Size = new System.Drawing.Size(50, 50);
			this.PlayButton.TabIndex = 0;
			this.PlayButton.UseVisualStyleBackColor = true;
			this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
			// 
			// TabsController
			// 
			this.TabsController.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TabsController.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.TabsController.Controls.Add(this.ControllerPage);
			this.TabsController.Controls.Add(this.SearchPage);
			this.TabsController.ItemSize = new System.Drawing.Size(20, 20);
			this.TabsController.Location = new System.Drawing.Point(295, 31);
			this.TabsController.Multiline = true;
			this.TabsController.Name = "TabsController";
			this.TabsController.SelectedIndex = 0;
			this.TabsController.Size = new System.Drawing.Size(626, 598);
			this.TabsController.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.TabsController.TabIndex = 0;
			// 
			// SearchPageButton
			// 
			this.SearchPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchPageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchPageButton.BackgroundImage")));
			this.SearchPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.SearchPageButton.Location = new System.Drawing.Point(881, 6);
			this.SearchPageButton.Name = "SearchPageButton";
			this.SearchPageButton.Size = new System.Drawing.Size(30, 30);
			this.SearchPageButton.TabIndex = 2;
			this.SearchPageButton.UseVisualStyleBackColor = true;
			this.SearchPageButton.Click += new System.EventHandler(this.SearchPageButton_Click);
			// 
			// ControllerPageButton
			// 
			this.ControllerPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ControllerPageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ControllerPageButton.BackgroundImage")));
			this.ControllerPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ControllerPageButton.Enabled = false;
			this.ControllerPageButton.Location = new System.Drawing.Point(845, 6);
			this.ControllerPageButton.Name = "ControllerPageButton";
			this.ControllerPageButton.Size = new System.Drawing.Size(30, 30);
			this.ControllerPageButton.TabIndex = 1;
			this.ControllerPageButton.UseVisualStyleBackColor = true;
			this.ControllerPageButton.Click += new System.EventHandler(this.ControllerPageButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(933, 641);
			this.Controls.Add(this.ListsPanel);
			this.Controls.Add(this.SearchPageButton);
			this.Controls.Add(this.ControllerPageButton);
			this.Controls.Add(this.TabsController);
			this.MinimumSize = new System.Drawing.Size(949, 572);
			this.Name = "MainForm";
			this.Text = "Octavia";
			this.ListsPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ReproListsDGV)).EndInit();
			this.SearchPage.ResumeLayout(false);
			this.SearchPage.PerformLayout();
			this.ControllerPage.ResumeLayout(false);
			this.ImagePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SongImagePB)).EndInit();
			this.ControllerPanel.ResumeLayout(false);
			this.ControllerPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DurationTrackBar)).EndInit();
			this.TabsController.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ImageList PlayImageList;
		private System.Windows.Forms.Button ControllerPageButton;
		private System.Windows.Forms.Button SearchPageButton;
		private System.Windows.Forms.Panel ListsPanel;
		private System.Windows.Forms.TabPage SearchPage;
		private System.Windows.Forms.TabPage ControllerPage;
		private System.Windows.Forms.Panel ImagePanel;
		private System.Windows.Forms.PictureBox SongImagePB;
		private System.Windows.Forms.Panel ControllerPanel;
		private System.Windows.Forms.Button ShuffleButton;
		private System.Windows.Forms.Button LoopButton;
		private System.Windows.Forms.Button PreviousButton;
		private System.Windows.Forms.Button NextButton;
		private System.Windows.Forms.TabControl TabsController;
		private System.Windows.Forms.Button PlayButton;
		private System.Windows.Forms.DataGridView ReproListsDGV;
		private System.Windows.Forms.TrackBar DurationTrackBar;
		private System.Windows.Forms.TextBox FilterTextBox;
		private System.Windows.Forms.FlowLayoutPanel SongsContainer;
		private System.Windows.Forms.Button DatabaseAddingButton;
		private System.Windows.Forms.TrackBar VolumeTrackBar;
	}
}

