
namespace Music_Manager {
	partial class EditSongForm {
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
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.NameLabel = new System.Windows.Forms.Label();
			this.SongNameLabel = new System.Windows.Forms.Label();
			this.OkButton = new System.Windows.Forms.Button();
			this.MusicFilesButton = new System.Windows.Forms.Button();
			this.ImageFilesPictureBox = new System.Windows.Forms.PictureBox();
			this.SongLabel = new System.Windows.Forms.Label();
			this.ImageLabel = new System.Windows.Forms.Label();
			this.PlaylistListBox = new System.Windows.Forms.ListBox();
			this.ImagesFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.MusicFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
			this.EnableEditButton = new System.Windows.Forms.Button();
			this.PlaylistLabel = new System.Windows.Forms.Label();
			this.CancelEditButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ImageFilesPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// NameTextBox
			// 
			this.NameTextBox.Enabled = false;
			this.NameTextBox.Location = new System.Drawing.Point(102, 24);
			this.NameTextBox.MinimumSize = new System.Drawing.Size(100, 20);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(100, 20);
			this.NameTextBox.TabIndex = 20;
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(100, 9);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(44, 13);
			this.NameLabel.TabIndex = 19;
			this.NameLabel.Text = "Nombre";
			// 
			// SongNameLabel
			// 
			this.SongNameLabel.AutoSize = true;
			this.SongNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SongNameLabel.Location = new System.Drawing.Point(13, 53);
			this.SongNameLabel.MaximumSize = new System.Drawing.Size(200, 100);
			this.SongNameLabel.MinimumSize = new System.Drawing.Size(35, 15);
			this.SongNameLabel.Name = "SongNameLabel";
			this.SongNameLabel.Size = new System.Drawing.Size(35, 15);
			this.SongNameLabel.TabIndex = 18;
			this.SongNameLabel.Visible = false;
			// 
			// OkButton
			// 
			this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OkButton.Location = new System.Drawing.Point(309, 258);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(75, 23);
			this.OkButton.TabIndex = 16;
			this.OkButton.Text = "Aceptar";
			this.OkButton.UseVisualStyleBackColor = true;
			// 
			// MusicFilesButton
			// 
			this.MusicFilesButton.Enabled = false;
			this.MusicFilesButton.Location = new System.Drawing.Point(11, 23);
			this.MusicFilesButton.Name = "MusicFilesButton";
			this.MusicFilesButton.Size = new System.Drawing.Size(75, 23);
			this.MusicFilesButton.TabIndex = 15;
			this.MusicFilesButton.Text = "Seleccionar";
			this.MusicFilesButton.UseVisualStyleBackColor = true;
			this.MusicFilesButton.Click += new System.EventHandler(this.MusicFilesButton_Click);
			// 
			// ImageFilesPictureBox
			// 
			this.ImageFilesPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ImageFilesPictureBox.Enabled = false;
			this.ImageFilesPictureBox.Location = new System.Drawing.Point(12, 103);
			this.ImageFilesPictureBox.MaximumSize = new System.Drawing.Size(190, 144);
			this.ImageFilesPictureBox.Name = "ImageFilesPictureBox";
			this.ImageFilesPictureBox.Size = new System.Drawing.Size(190, 144);
			this.ImageFilesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ImageFilesPictureBox.TabIndex = 14;
			this.ImageFilesPictureBox.TabStop = false;
			this.ImageFilesPictureBox.Click += new System.EventHandler(this.ImageFilesPictureBox_Click);
			// 
			// SongLabel
			// 
			this.SongLabel.AutoSize = true;
			this.SongLabel.Location = new System.Drawing.Point(12, 9);
			this.SongLabel.MaximumSize = new System.Drawing.Size(200, 0);
			this.SongLabel.Name = "SongLabel";
			this.SongLabel.Size = new System.Drawing.Size(69, 13);
			this.SongLabel.TabIndex = 13;
			this.SongLabel.Text = "Archivo .mp3";
			// 
			// ImageLabel
			// 
			this.ImageLabel.AutoSize = true;
			this.ImageLabel.Location = new System.Drawing.Point(12, 87);
			this.ImageLabel.Name = "ImageLabel";
			this.ImageLabel.Size = new System.Drawing.Size(42, 13);
			this.ImageLabel.TabIndex = 12;
			this.ImageLabel.Text = "Imagen";
			// 
			// PlaylistListBox
			// 
			this.PlaylistListBox.FormattingEnabled = true;
			this.PlaylistListBox.Location = new System.Drawing.Point(230, 98);
			this.PlaylistListBox.Name = "PlaylistListBox";
			this.PlaylistListBox.Size = new System.Drawing.Size(145, 147);
			this.PlaylistListBox.TabIndex = 21;
			this.ToolTips.SetToolTip(this.PlaylistListBox, "Selecciona las listas de reproducción.");
			// 
			// ImagesFileDialog
			// 
			this.ImagesFileDialog.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All files (*.*)|*.*";
			// 
			// MusicFileDialog
			// 
			this.MusicFileDialog.Filter = "MP3 Files (*.mp3)|*.mp3";
			// 
			// EnableEditButton
			// 
			this.EnableEditButton.Location = new System.Drawing.Point(13, 258);
			this.EnableEditButton.Name = "EnableEditButton";
			this.EnableEditButton.Size = new System.Drawing.Size(75, 23);
			this.EnableEditButton.TabIndex = 22;
			this.EnableEditButton.Text = "Editar";
			this.EnableEditButton.UseVisualStyleBackColor = true;
			this.EnableEditButton.Click += new System.EventHandler(this.EnableEditButton_Click);
			// 
			// PlaylistLabel
			// 
			this.PlaylistLabel.AutoSize = true;
			this.PlaylistLabel.Location = new System.Drawing.Point(230, 79);
			this.PlaylistLabel.Name = "PlaylistLabel";
			this.PlaylistLabel.Size = new System.Drawing.Size(119, 13);
			this.PlaylistLabel.TabIndex = 23;
			this.PlaylistLabel.Text = "Listas de Reproducción";
			// 
			// CancelEditButton
			// 
			this.CancelEditButton.Enabled = false;
			this.CancelEditButton.Location = new System.Drawing.Point(102, 258);
			this.CancelEditButton.Name = "CancelEditButton";
			this.CancelEditButton.Size = new System.Drawing.Size(75, 23);
			this.CancelEditButton.TabIndex = 24;
			this.CancelEditButton.Text = "Cancelar";
			this.CancelEditButton.UseVisualStyleBackColor = true;
			this.CancelEditButton.Click += new System.EventHandler(this.CancelEditButton_Click);
			// 
			// EditSongForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(396, 293);
			this.Controls.Add(this.CancelEditButton);
			this.Controls.Add(this.PlaylistLabel);
			this.Controls.Add(this.EnableEditButton);
			this.Controls.Add(this.PlaylistListBox);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.SongNameLabel);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.MusicFilesButton);
			this.Controls.Add(this.ImageFilesPictureBox);
			this.Controls.Add(this.SongLabel);
			this.Controls.Add(this.ImageLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "EditSongForm";
			this.Text = "Propiedades de la Canción";
			((System.ComponentModel.ISupportInitialize)(this.ImageFilesPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label SongNameLabel;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Button MusicFilesButton;
		private System.Windows.Forms.PictureBox ImageFilesPictureBox;
		private System.Windows.Forms.Label SongLabel;
		private System.Windows.Forms.Label ImageLabel;
		private System.Windows.Forms.ListBox PlaylistListBox;
		private System.Windows.Forms.OpenFileDialog ImagesFileDialog;
		private System.Windows.Forms.OpenFileDialog MusicFileDialog;
		private System.Windows.Forms.ToolTip ToolTips;
		private System.Windows.Forms.Button EnableEditButton;
		private System.Windows.Forms.Label PlaylistLabel;
		private System.Windows.Forms.Button CancelEditButton;
	}
}