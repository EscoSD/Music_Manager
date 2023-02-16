
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
			this.components = new System.ComponentModel.Container();
			this.ImageLabel = new System.Windows.Forms.Label();
			this.SongLabel = new System.Windows.Forms.Label();
			this.ImageFilesPictureBox = new System.Windows.Forms.PictureBox();
			this.MusicFilesButton = new System.Windows.Forms.Button();
			this.ImagesFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.MusicFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.OkButton = new System.Windows.Forms.Button();
			this.CancelationButton = new System.Windows.Forms.Button();
			this.SongNameLabel = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
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
			this.ToolTips.SetToolTip(this.ImageFilesPictureBox, "Pulse para añadir una imagen a la foto.");
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
			this.MusicFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.FilesOK);
			// 
			// OkButton
			// 
			this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OkButton.Enabled = false;
			this.OkButton.Location = new System.Drawing.Point(46, 259);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(75, 23);
			this.OkButton.TabIndex = 7;
			this.OkButton.Text = "Aceptar";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.AcceptButton_Click);
			// 
			// CancelationButton
			// 
			this.CancelationButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelationButton.Location = new System.Drawing.Point(127, 259);
			this.CancelationButton.Name = "CancelationButton";
			this.CancelationButton.Size = new System.Drawing.Size(75, 23);
			this.CancelationButton.TabIndex = 8;
			this.CancelationButton.Text = "Cancelar";
			this.CancelationButton.UseVisualStyleBackColor = true;
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
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(158, 9);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(44, 13);
			this.NameLabel.TabIndex = 10;
			this.NameLabel.Text = "Nombre";
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(102, 24);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(100, 20);
			this.NameTextBox.TabIndex = 11;
			this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
			// 
			// NewSongForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(214, 291);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.SongNameLabel);
			this.Controls.Add(this.CancelationButton);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.MusicFilesButton);
			this.Controls.Add(this.ImageFilesPictureBox);
			this.Controls.Add(this.SongLabel);
			this.Controls.Add(this.ImageLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "NewSongForm";
			this.Text = "Nueva Canción";
			this.Load += new System.EventHandler(this.NewSongForm_Load);
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
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Button CancelationButton;
		private System.Windows.Forms.Label SongNameLabel;
		private System.Windows.Forms.ToolTip ToolTips;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.TextBox NameTextBox;
	}
}