
namespace Music_Manager {
	partial class NewSongForm {
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
			this.ImageLabel = new System.Windows.Forms.Label();
			this.SongLabel = new System.Windows.Forms.Label();
			this.ImageFilesPictureBox = new System.Windows.Forms.PictureBox();
			this.MusicFilesButton = new System.Windows.Forms.Button();
			this.ImagesFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.MusicFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.AcceptButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SongNameLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.ImageFilesPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// ImageLabel
			// 
			this.ImageLabel.AutoSize = true;
			this.ImageLabel.Location = new System.Drawing.Point(12, 87);
			this.ImageLabel.Name = "ImageLabel";
			this.ImageLabel.Size = new System.Drawing.Size(42, 13);
			this.ImageLabel.TabIndex = 1;
			this.ImageLabel.Text = "Imagen";
			// 
			// SongLabel
			// 
			this.SongLabel.AutoSize = true;
			this.SongLabel.Location = new System.Drawing.Point(12, 9);
			this.SongLabel.MaximumSize = new System.Drawing.Size(200, 0);
			this.SongLabel.Name = "SongLabel";
			this.SongLabel.Size = new System.Drawing.Size(69, 13);
			this.SongLabel.TabIndex = 2;
			this.SongLabel.Text = "Archivo .mp3";
			// 
			// ImageFilesPictureBox
			// 
			this.ImageFilesPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ImageFilesPictureBox.Location = new System.Drawing.Point(12, 103);
			this.ImageFilesPictureBox.MaximumSize = new System.Drawing.Size(190, 144);
			this.ImageFilesPictureBox.Name = "ImageFilesPictureBox";
			this.ImageFilesPictureBox.Size = new System.Drawing.Size(190, 144);
			this.ImageFilesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ImageFilesPictureBox.TabIndex = 5;
			this.ImageFilesPictureBox.TabStop = false;
			this.ImageFilesPictureBox.Click += new System.EventHandler(this.ImageFilesPictureBox_Click);
			// 
			// MusicFilesButton
			// 
			this.MusicFilesButton.Location = new System.Drawing.Point(11, 23);
			this.MusicFilesButton.Name = "MusicFilesButton";
			this.MusicFilesButton.Size = new System.Drawing.Size(75, 23);
			this.MusicFilesButton.TabIndex = 6;
			this.MusicFilesButton.Text = "Seleccionar";
			this.MusicFilesButton.UseVisualStyleBackColor = true;
			this.MusicFilesButton.Click += new System.EventHandler(this.MusicFilesButton_Click);
			// 
			// ImagesFileDialog
			// 
			this.ImagesFileDialog.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All files (*.*)|*.*";
			this.ImagesFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.FilesOK);
			// 
			// MusicFileDialog
			// 
			this.MusicFileDialog.Filter = "MP3 Files (*.mp3)|*.mp3";
			// 
			// AcceptButton
			// 
			this.AcceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.AcceptButton.Enabled = false;
			this.AcceptButton.Location = new System.Drawing.Point(46, 259);
			this.AcceptButton.Name = "AcceptButton";
			this.AcceptButton.Size = new System.Drawing.Size(75, 23);
			this.AcceptButton.TabIndex = 7;
			this.AcceptButton.Text = "Aceptar";
			this.AcceptButton.UseVisualStyleBackColor = true;
			this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Location = new System.Drawing.Point(127, 259);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 8;
			this.CancelButton.Text = "Cancelar";
			this.CancelButton.UseVisualStyleBackColor = true;
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
			this.SongNameLabel.TabIndex = 9;
			this.SongNameLabel.Text = "None";
			// 
			// NewSongForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(214, 291);
			this.Controls.Add(this.SongNameLabel);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.AcceptButton);
			this.Controls.Add(this.MusicFilesButton);
			this.Controls.Add(this.ImageFilesPictureBox);
			this.Controls.Add(this.SongLabel);
			this.Controls.Add(this.ImageLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "NewSongForm";
			this.Text = "Nueva Canción";
			((System.ComponentModel.ISupportInitialize)(this.ImageFilesPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label ImageLabel;
		private System.Windows.Forms.Label SongLabel;
		private System.Windows.Forms.PictureBox ImageFilesPictureBox;
		private System.Windows.Forms.Button MusicFilesButton;
		private System.Windows.Forms.OpenFileDialog ImagesFileDialog;
		private System.Windows.Forms.OpenFileDialog MusicFileDialog;
		private System.Windows.Forms.Button AcceptButton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Label SongNameLabel;
	}
}