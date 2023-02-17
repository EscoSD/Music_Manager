
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
			this.EmptyDGVLabel = new System.Windows.Forms.Label();
			this.PlaylistsDGV = new System.Windows.Forms.DataGridView();
			this.ListasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EditColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.SearchPage = new System.Windows.Forms.TabPage();
			this.SongSearchLabel = new System.Windows.Forms.Label();
			this.DatabaseAddingButton = new System.Windows.Forms.Button();
			this.SongsContainer = new System.Windows.Forms.FlowLayoutPanel();
			this.FilterTextBox = new System.Windows.Forms.TextBox();
			this.ControllerPage = new System.Windows.Forms.TabPage();
			this.ImagePanel = new System.Windows.Forms.Panel();
			this.SongImagePB = new System.Windows.Forms.PictureBox();
			this.ControllerPanel = new System.Windows.Forms.Panel();
			this.SongNameLabel = new System.Windows.Forms.Label();
			this.VolumePictureBox = new System.Windows.Forms.PictureBox();
			this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
			this.PlayButton = new System.Windows.Forms.Button();
			this.TabsController = new System.Windows.Forms.TabControl();
			this.DatabasePageButton = new System.Windows.Forms.Button();
			this.ControllerPageButton = new System.Windows.Forms.Button();
			this.NewPlaylistButton = new System.Windows.Forms.Button();
			this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
			this.PlaylistsLabel = new System.Windows.Forms.Label();
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ListsPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PlaylistsDGV)).BeginInit();
			this.SearchPage.SuspendLayout();
			this.ControllerPage.SuspendLayout();
			this.ImagePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SongImagePB)).BeginInit();
			this.ControllerPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.VolumePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
			this.TabsController.SuspendLayout();
			this.MenuStrip.SuspendLayout();
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
			this.ListsPanel.Controls.Add(this.EmptyDGVLabel);
			this.ListsPanel.Controls.Add(this.PlaylistsDGV);
			this.ListsPanel.Location = new System.Drawing.Point(13, 99);
			this.ListsPanel.Name = "ListsPanel";
			this.ListsPanel.Size = new System.Drawing.Size(276, 542);
			this.ListsPanel.TabIndex = 3;
			// 
			// EmptyDGVLabel
			// 
			this.EmptyDGVLabel.AutoSize = true;
			this.EmptyDGVLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.EmptyDGVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EmptyDGVLabel.Location = new System.Drawing.Point(13, 132);
			this.EmptyDGVLabel.MaximumSize = new System.Drawing.Size(250, 542);
			this.EmptyDGVLabel.Name = "EmptyDGVLabel";
			this.EmptyDGVLabel.Size = new System.Drawing.Size(250, 124);
			this.EmptyDGVLabel.TabIndex = 1;
			this.EmptyDGVLabel.Text = "Crea listas de reproducción con el botón de añadir de arriba.";
			// 
			// PlaylistsDGV
			// 
			this.PlaylistsDGV.AllowUserToAddRows = false;
			this.PlaylistsDGV.AllowUserToDeleteRows = false;
			this.PlaylistsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PlaylistsDGV.ColumnHeadersVisible = false;
			this.PlaylistsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ListasColumn,
            this.EditColumn,
            this.DeleteColumn});
			this.PlaylistsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PlaylistsDGV.Location = new System.Drawing.Point(0, 0);
			this.PlaylistsDGV.Name = "PlaylistsDGV";
			this.PlaylistsDGV.ReadOnly = true;
			this.PlaylistsDGV.RowHeadersVisible = false;
			this.PlaylistsDGV.Size = new System.Drawing.Size(276, 542);
			this.PlaylistsDGV.TabIndex = 0;
			this.PlaylistsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlaylistsDGV_CellContentClick);
			// 
			// ListasColumn
			// 
			this.ListasColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ListasColumn.HeaderText = "Listas";
			this.ListasColumn.Name = "ListasColumn";
			this.ListasColumn.ReadOnly = true;
			// 
			// EditColumn
			// 
			this.EditColumn.HeaderText = "Editar";
			this.EditColumn.Image = ((System.Drawing.Image)(resources.GetObject("EditColumn.Image")));
			this.EditColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.EditColumn.Name = "EditColumn";
			this.EditColumn.ReadOnly = true;
			this.EditColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.EditColumn.Width = 30;
			// 
			// DeleteColumn
			// 
			this.DeleteColumn.HeaderText = "Delete";
			this.DeleteColumn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteColumn.Image")));
			this.DeleteColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.DeleteColumn.Name = "DeleteColumn";
			this.DeleteColumn.ReadOnly = true;
			this.DeleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.DeleteColumn.Width = 30;
			// 
			// SearchPage
			// 
			this.SearchPage.BackColor = System.Drawing.SystemColors.Control;
			this.SearchPage.Controls.Add(this.SongSearchLabel);
			this.SearchPage.Controls.Add(this.DatabaseAddingButton);
			this.SearchPage.Controls.Add(this.SongsContainer);
			this.SearchPage.Controls.Add(this.FilterTextBox);
			this.SearchPage.Location = new System.Drawing.Point(4, 24);
			this.SearchPage.Name = "SearchPage";
			this.SearchPage.Padding = new System.Windows.Forms.Padding(3);
			this.SearchPage.Size = new System.Drawing.Size(618, 555);
			this.SearchPage.TabIndex = 1;
			this.SearchPage.Text = "tabPage2";
			// 
			// SongSearchLabel
			// 
			this.SongSearchLabel.AutoSize = true;
			this.SongSearchLabel.Location = new System.Drawing.Point(7, 7);
			this.SongSearchLabel.Name = "SongSearchLabel";
			this.SongSearchLabel.Size = new System.Drawing.Size(40, 13);
			this.SongSearchLabel.TabIndex = 4;
			this.SongSearchLabel.Text = "Buscar";
			// 
			// DatabaseAddingButton
			// 
			this.DatabaseAddingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DatabaseAddingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DatabaseAddingButton.BackgroundImage")));
			this.DatabaseAddingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.DatabaseAddingButton.Location = new System.Drawing.Point(567, 7);
			this.DatabaseAddingButton.Name = "DatabaseAddingButton";
			this.DatabaseAddingButton.Size = new System.Drawing.Size(40, 40);
			this.DatabaseAddingButton.TabIndex = 3;
			this.ToolTips.SetToolTip(this.DatabaseAddingButton, "Pulse para añadir una nueva canción.");
			this.DatabaseAddingButton.UseVisualStyleBackColor = true;
			this.DatabaseAddingButton.Click += new System.EventHandler(this.DatabaseAddingButton_Click);
			// 
			// SongsContainer
			// 
			this.SongsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SongsContainer.AutoScroll = true;
			this.SongsContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SongsContainer.Location = new System.Drawing.Point(3, 54);
			this.SongsContainer.Name = "SongsContainer";
			this.SongsContainer.Size = new System.Drawing.Size(612, 491);
			this.SongsContainer.TabIndex = 2;
			// 
			// FilterTextBox
			// 
			this.FilterTextBox.Location = new System.Drawing.Point(9, 27);
			this.FilterTextBox.Name = "FilterTextBox";
			this.FilterTextBox.Size = new System.Drawing.Size(100, 20);
			this.FilterTextBox.TabIndex = 0;
			this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
			// 
			// ControllerPage
			// 
			this.ControllerPage.BackColor = System.Drawing.SystemColors.Control;
			this.ControllerPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ControllerPage.Controls.Add(this.ImagePanel);
			this.ControllerPage.Controls.Add(this.ControllerPanel);
			this.ControllerPage.Location = new System.Drawing.Point(4, 5);
			this.ControllerPage.Name = "ControllerPage";
			this.ControllerPage.Padding = new System.Windows.Forms.Padding(3);
			this.ControllerPage.Size = new System.Drawing.Size(618, 574);
			this.ControllerPage.TabIndex = 0;
			this.ControllerPage.Text = "tabPage1";
			// 
			// ImagePanel
			// 
			this.ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImagePanel.BackColor = System.Drawing.Color.Silver;
			this.ImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ImagePanel.Controls.Add(this.SongImagePB);
			this.ImagePanel.Location = new System.Drawing.Point(6, 6);
			this.ImagePanel.Name = "ImagePanel";
			this.ImagePanel.Size = new System.Drawing.Size(604, 358);
			this.ImagePanel.TabIndex = 1;
			// 
			// SongImagePB
			// 
			this.SongImagePB.BackColor = System.Drawing.SystemColors.Control;
			this.SongImagePB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SongImagePB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SongImagePB.Location = new System.Drawing.Point(0, 0);
			this.SongImagePB.Name = "SongImagePB";
			this.SongImagePB.Size = new System.Drawing.Size(602, 356);
			this.SongImagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.SongImagePB.TabIndex = 0;
			this.SongImagePB.TabStop = false;
			// 
			// ControllerPanel
			// 
			this.ControllerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ControllerPanel.BackColor = System.Drawing.SystemColors.Control;
			this.ControllerPanel.Controls.Add(this.SongNameLabel);
			this.ControllerPanel.Controls.Add(this.VolumePictureBox);
			this.ControllerPanel.Controls.Add(this.VolumeTrackBar);
			this.ControllerPanel.Controls.Add(this.PlayButton);
			this.ControllerPanel.Location = new System.Drawing.Point(6, 368);
			this.ControllerPanel.Name = "ControllerPanel";
			this.ControllerPanel.Size = new System.Drawing.Size(604, 217);
			this.ControllerPanel.TabIndex = 0;
			// 
			// SongNameLabel
			// 
			this.SongNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.SongNameLabel.AutoSize = true;
			this.SongNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SongNameLabel.Location = new System.Drawing.Point(2, 12);
			this.SongNameLabel.Name = "SongNameLabel";
			this.SongNameLabel.Size = new System.Drawing.Size(63, 25);
			this.SongNameLabel.TabIndex = 11;
			this.SongNameLabel.Text = "None";
			// 
			// VolumePictureBox
			// 
			this.VolumePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.VolumePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("VolumePictureBox.Image")));
			this.VolumePictureBox.Location = new System.Drawing.Point(552, 151);
			this.VolumePictureBox.Name = "VolumePictureBox";
			this.VolumePictureBox.Size = new System.Drawing.Size(30, 30);
			this.VolumePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.VolumePictureBox.TabIndex = 10;
			this.VolumePictureBox.TabStop = false;
			// 
			// VolumeTrackBar
			// 
			this.VolumeTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.VolumeTrackBar.Location = new System.Drawing.Point(557, 52);
			this.VolumeTrackBar.Maximum = 100;
			this.VolumeTrackBar.Name = "VolumeTrackBar";
			this.VolumeTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.VolumeTrackBar.Size = new System.Drawing.Size(45, 104);
			this.VolumeTrackBar.TabIndex = 7;
			this.VolumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
			this.VolumeTrackBar.Value = 50;
			this.VolumeTrackBar.ValueChanged += new System.EventHandler(this.VolumeTrackBar_ValueChanged);
			// 
			// PlayButton
			// 
			this.PlayButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.PlayButton.ImageIndex = 0;
			this.PlayButton.ImageList = this.PlayImageList;
			this.PlayButton.Location = new System.Drawing.Point(261, 116);
			this.PlayButton.Name = "PlayButton";
			this.PlayButton.Size = new System.Drawing.Size(122, 65);
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
			this.TabsController.ItemSize = new System.Drawing.Size(0, 1);
			this.TabsController.Location = new System.Drawing.Point(295, 62);
			this.TabsController.Multiline = true;
			this.TabsController.Name = "TabsController";
			this.TabsController.SelectedIndex = 0;
			this.TabsController.Size = new System.Drawing.Size(626, 583);
			this.TabsController.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.TabsController.TabIndex = 0;
			// 
			// DatabasePageButton
			// 
			this.DatabasePageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DatabasePageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DatabasePageButton.BackgroundImage")));
			this.DatabasePageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.DatabasePageButton.Location = new System.Drawing.Point(888, 26);
			this.DatabasePageButton.Name = "DatabasePageButton";
			this.DatabasePageButton.Size = new System.Drawing.Size(30, 30);
			this.DatabasePageButton.TabIndex = 2;
			this.ToolTips.SetToolTip(this.DatabasePageButton, "Pestaña de Canciones");
			this.DatabasePageButton.UseVisualStyleBackColor = true;
			this.DatabasePageButton.Click += new System.EventHandler(this.DatabasePageButton_Click);
			// 
			// ControllerPageButton
			// 
			this.ControllerPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ControllerPageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ControllerPageButton.BackgroundImage")));
			this.ControllerPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ControllerPageButton.Enabled = false;
			this.ControllerPageButton.Location = new System.Drawing.Point(849, 26);
			this.ControllerPageButton.Name = "ControllerPageButton";
			this.ControllerPageButton.Size = new System.Drawing.Size(30, 30);
			this.ControllerPageButton.TabIndex = 1;
			this.ToolTips.SetToolTip(this.ControllerPageButton, "Pestaña de Reproducción");
			this.ControllerPageButton.UseVisualStyleBackColor = true;
			this.ControllerPageButton.Click += new System.EventHandler(this.ControllerPageButton_Click);
			// 
			// NewPlaylistButton
			// 
			this.NewPlaylistButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewPlaylistButton.BackgroundImage")));
			this.NewPlaylistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.NewPlaylistButton.Location = new System.Drawing.Point(249, 55);
			this.NewPlaylistButton.Name = "NewPlaylistButton";
			this.NewPlaylistButton.Size = new System.Drawing.Size(40, 40);
			this.NewPlaylistButton.TabIndex = 4;
			this.ToolTips.SetToolTip(this.NewPlaylistButton, "Pulse para crear una nueva lista de reproducción.");
			this.NewPlaylistButton.UseVisualStyleBackColor = true;
			this.NewPlaylistButton.Click += new System.EventHandler(this.NewPlaylistButton_Click);
			// 
			// ToolTips
			// 
			this.ToolTips.IsBalloon = true;
			// 
			// PlaylistsLabel
			// 
			this.PlaylistsLabel.AutoSize = true;
			this.PlaylistsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
			this.PlaylistsLabel.Location = new System.Drawing.Point(8, 69);
			this.PlaylistsLabel.Name = "PlaylistsLabel";
			this.PlaylistsLabel.Size = new System.Drawing.Size(230, 26);
			this.PlaylistsLabel.TabIndex = 5;
			this.PlaylistsLabel.Text = "Listas de reproducción";
			// 
			// MenuStrip
			// 
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpMenuItem});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Size = new System.Drawing.Size(933, 24);
			this.MenuStrip.TabIndex = 6;
			this.MenuStrip.Text = "menuStrip1";
			// 
			// HelpMenuItem
			// 
			this.HelpMenuItem.Name = "HelpMenuItem";
			this.HelpMenuItem.Size = new System.Drawing.Size(53, 20);
			this.HelpMenuItem.Text = "Ayuda";
			this.HelpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(933, 657);
			this.Controls.Add(this.PlaylistsLabel);
			this.Controls.Add(this.NewPlaylistButton);
			this.Controls.Add(this.ListsPanel);
			this.Controls.Add(this.DatabasePageButton);
			this.Controls.Add(this.ControllerPageButton);
			this.Controls.Add(this.TabsController);
			this.Controls.Add(this.MenuStrip);
			this.MainMenuStrip = this.MenuStrip;
			this.MinimumSize = new System.Drawing.Size(949, 572);
			this.Name = "MainForm";
			this.Text = "Octavia";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ListsPanel.ResumeLayout(false);
			this.ListsPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PlaylistsDGV)).EndInit();
			this.SearchPage.ResumeLayout(false);
			this.SearchPage.PerformLayout();
			this.ControllerPage.ResumeLayout(false);
			this.ImagePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SongImagePB)).EndInit();
			this.ControllerPanel.ResumeLayout(false);
			this.ControllerPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.VolumePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
			this.TabsController.ResumeLayout(false);
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ImageList PlayImageList;
		private System.Windows.Forms.Button ControllerPageButton;
		private System.Windows.Forms.Button DatabasePageButton;
		private System.Windows.Forms.Panel ListsPanel;
		private System.Windows.Forms.TabPage SearchPage;
		private System.Windows.Forms.TabPage ControllerPage;
		private System.Windows.Forms.Panel ImagePanel;
		private System.Windows.Forms.PictureBox SongImagePB;
		private System.Windows.Forms.Panel ControllerPanel;
		private System.Windows.Forms.TabControl TabsController;
		private System.Windows.Forms.Button PlayButton;
		private System.Windows.Forms.DataGridView PlaylistsDGV;
		private System.Windows.Forms.TextBox FilterTextBox;
		private System.Windows.Forms.FlowLayoutPanel SongsContainer;
		private System.Windows.Forms.Button DatabaseAddingButton;
		private System.Windows.Forms.TrackBar VolumeTrackBar;
		private System.Windows.Forms.PictureBox VolumePictureBox;
		private System.Windows.Forms.Label SongNameLabel;
		private System.Windows.Forms.Button NewPlaylistButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn ListasColumn;
		private System.Windows.Forms.DataGridViewImageColumn EditColumn;
		private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
		private System.Windows.Forms.Label SongSearchLabel;
		private System.Windows.Forms.ToolTip ToolTips;
		private System.Windows.Forms.Label PlaylistsLabel;
		private System.Windows.Forms.MenuStrip MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
		private System.Windows.Forms.Label EmptyDGVLabel;
	}
}

