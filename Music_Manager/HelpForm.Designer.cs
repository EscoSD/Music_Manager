
namespace Music_Manager {
	partial class HelpForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
			this.TabsController = new System.Windows.Forms.TabControl();
			this.FirstViewPage = new System.Windows.Forms.TabPage();
			this.ButtonsHelpLabel = new System.Windows.Forms.Label();
			this.ButtonsPictureBox = new System.Windows.Forms.PictureBox();
			this.PlayListHelpLabel = new System.Windows.Forms.Label();
			this.PlaylistsPictureBox = new System.Windows.Forms.PictureBox();
			this.MusicViewPage = new System.Windows.Forms.TabPage();
			this.SongsHelpLabel = new System.Windows.Forms.Label();
			this.SongsPictureBox = new System.Windows.Forms.PictureBox();
			this.SongViewPage = new System.Windows.Forms.TabPage();
			this.PlaylistsLabel = new System.Windows.Forms.PictureBox();
			this.PlaylistAddingHelpLabel = new System.Windows.Forms.Label();
			this.EditHelpLabel = new System.Windows.Forms.Label();
			this.SongPictureBox = new System.Windows.Forms.PictureBox();
			this.EditPictureBox = new System.Windows.Forms.PictureBox();
			this.OkButton = new System.Windows.Forms.Button();
			this.TabsController.SuspendLayout();
			this.FirstViewPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ButtonsPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PlaylistsPictureBox)).BeginInit();
			this.MusicViewPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SongsPictureBox)).BeginInit();
			this.SongViewPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PlaylistsLabel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SongPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EditPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// TabsController
			// 
			this.TabsController.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TabsController.Controls.Add(this.FirstViewPage);
			this.TabsController.Controls.Add(this.MusicViewPage);
			this.TabsController.Controls.Add(this.SongViewPage);
			this.TabsController.Location = new System.Drawing.Point(12, 12);
			this.TabsController.Name = "TabsController";
			this.TabsController.SelectedIndex = 0;
			this.TabsController.Size = new System.Drawing.Size(581, 441);
			this.TabsController.TabIndex = 4;
			// 
			// FirstViewPage
			// 
			this.FirstViewPage.Controls.Add(this.ButtonsHelpLabel);
			this.FirstViewPage.Controls.Add(this.ButtonsPictureBox);
			this.FirstViewPage.Controls.Add(this.PlayListHelpLabel);
			this.FirstViewPage.Controls.Add(this.PlaylistsPictureBox);
			this.FirstViewPage.Location = new System.Drawing.Point(4, 22);
			this.FirstViewPage.Name = "FirstViewPage";
			this.FirstViewPage.Padding = new System.Windows.Forms.Padding(3);
			this.FirstViewPage.Size = new System.Drawing.Size(573, 415);
			this.FirstViewPage.TabIndex = 0;
			this.FirstViewPage.Text = "Página 1";
			this.FirstViewPage.UseVisualStyleBackColor = true;
			// 
			// ButtonsHelpLabel
			// 
			this.ButtonsHelpLabel.AutoSize = true;
			this.ButtonsHelpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonsHelpLabel.Location = new System.Drawing.Point(47, 249);
			this.ButtonsHelpLabel.Name = "ButtonsHelpLabel";
			this.ButtonsHelpLabel.Size = new System.Drawing.Size(489, 25);
			this.ButtonsHelpLabel.TabIndex = 7;
			this.ButtonsHelpLabel.Text = "Usa estos botones para navegar entre los menús.";
			// 
			// ButtonsPictureBox
			// 
			this.ButtonsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ButtonsPictureBox.Image")));
			this.ButtonsPictureBox.Location = new System.Drawing.Point(52, 291);
			this.ButtonsPictureBox.Name = "ButtonsPictureBox";
			this.ButtonsPictureBox.Size = new System.Drawing.Size(176, 89);
			this.ButtonsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ButtonsPictureBox.TabIndex = 6;
			this.ButtonsPictureBox.TabStop = false;
			// 
			// PlayListHelpLabel
			// 
			this.PlayListHelpLabel.AutoSize = true;
			this.PlayListHelpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlayListHelpLabel.Location = new System.Drawing.Point(47, 22);
			this.PlayListHelpLabel.Name = "PlayListHelpLabel";
			this.PlayListHelpLabel.Size = new System.Drawing.Size(375, 25);
			this.PlayListHelpLabel.TabIndex = 5;
			this.PlayListHelpLabel.Text = "Para añadir una lista pulsa el botón +.";
			// 
			// PlaylistsPictureBox
			// 
			this.PlaylistsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PlaylistsPictureBox.Image")));
			this.PlaylistsPictureBox.Location = new System.Drawing.Point(52, 65);
			this.PlaylistsPictureBox.Name = "PlaylistsPictureBox";
			this.PlaylistsPictureBox.Size = new System.Drawing.Size(286, 158);
			this.PlaylistsPictureBox.TabIndex = 4;
			this.PlaylistsPictureBox.TabStop = false;
			// 
			// MusicViewPage
			// 
			this.MusicViewPage.Controls.Add(this.SongsHelpLabel);
			this.MusicViewPage.Controls.Add(this.SongsPictureBox);
			this.MusicViewPage.Location = new System.Drawing.Point(4, 22);
			this.MusicViewPage.Name = "MusicViewPage";
			this.MusicViewPage.Padding = new System.Windows.Forms.Padding(3);
			this.MusicViewPage.Size = new System.Drawing.Size(573, 415);
			this.MusicViewPage.TabIndex = 1;
			this.MusicViewPage.Text = "Página 2";
			this.MusicViewPage.UseVisualStyleBackColor = true;
			// 
			// SongsHelpLabel
			// 
			this.SongsHelpLabel.AutoSize = true;
			this.SongsHelpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SongsHelpLabel.Location = new System.Drawing.Point(73, 20);
			this.SongsHelpLabel.Name = "SongsHelpLabel";
			this.SongsHelpLabel.Size = new System.Drawing.Size(411, 25);
			this.SongsHelpLabel.TabIndex = 7;
			this.SongsHelpLabel.Text = "Para añadir una canción pulsa el botón +.";
			// 
			// SongsPictureBox
			// 
			this.SongsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SongsPictureBox.Image")));
			this.SongsPictureBox.Location = new System.Drawing.Point(78, 48);
			this.SongsPictureBox.Name = "SongsPictureBox";
			this.SongsPictureBox.Size = new System.Drawing.Size(396, 351);
			this.SongsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.SongsPictureBox.TabIndex = 6;
			this.SongsPictureBox.TabStop = false;
			// 
			// SongViewPage
			// 
			this.SongViewPage.Controls.Add(this.PlaylistsLabel);
			this.SongViewPage.Controls.Add(this.PlaylistAddingHelpLabel);
			this.SongViewPage.Controls.Add(this.EditHelpLabel);
			this.SongViewPage.Controls.Add(this.SongPictureBox);
			this.SongViewPage.Controls.Add(this.EditPictureBox);
			this.SongViewPage.Location = new System.Drawing.Point(4, 22);
			this.SongViewPage.Name = "SongViewPage";
			this.SongViewPage.Padding = new System.Windows.Forms.Padding(3);
			this.SongViewPage.Size = new System.Drawing.Size(573, 415);
			this.SongViewPage.TabIndex = 2;
			this.SongViewPage.Text = "Página 3";
			this.SongViewPage.UseVisualStyleBackColor = true;
			// 
			// PlaylistsLabel
			// 
			this.PlaylistsLabel.Image = ((System.Drawing.Image)(resources.GetObject("PlaylistsLabel.Image")));
			this.PlaylistsLabel.Location = new System.Drawing.Point(334, 229);
			this.PlaylistsLabel.Name = "PlaylistsLabel";
			this.PlaylistsLabel.Size = new System.Drawing.Size(168, 170);
			this.PlaylistsLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PlaylistsLabel.TabIndex = 10;
			this.PlaylistsLabel.TabStop = false;
			// 
			// PlaylistAddingHelpLabel
			// 
			this.PlaylistAddingHelpLabel.AutoSize = true;
			this.PlaylistAddingHelpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlaylistAddingHelpLabel.Location = new System.Drawing.Point(6, 273);
			this.PlaylistAddingHelpLabel.MaximumSize = new System.Drawing.Size(300, 500);
			this.PlaylistAddingHelpLabel.Name = "PlaylistAddingHelpLabel";
			this.PlaylistAddingHelpLabel.Size = new System.Drawing.Size(267, 50);
			this.PlaylistAddingHelpLabel.TabIndex = 9;
			this.PlaylistAddingHelpLabel.Text = "También puedes añadir la canción a una Playlist.";
			// 
			// EditHelpLabel
			// 
			this.EditHelpLabel.AutoSize = true;
			this.EditHelpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EditHelpLabel.Location = new System.Drawing.Point(6, 19);
			this.EditHelpLabel.Name = "EditHelpLabel";
			this.EditHelpLabel.Size = new System.Drawing.Size(518, 25);
			this.EditHelpLabel.TabIndex = 8;
			this.EditHelpLabel.Text = "Con el botón de editar se podrán modificar los datos.";
			// 
			// SongPictureBox
			// 
			this.SongPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SongPictureBox.Image")));
			this.SongPictureBox.Location = new System.Drawing.Point(11, 57);
			this.SongPictureBox.Name = "SongPictureBox";
			this.SongPictureBox.Size = new System.Drawing.Size(215, 163);
			this.SongPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.SongPictureBox.TabIndex = 1;
			this.SongPictureBox.TabStop = false;
			// 
			// EditPictureBox
			// 
			this.EditPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("EditPictureBox.Image")));
			this.EditPictureBox.Location = new System.Drawing.Point(265, 129);
			this.EditPictureBox.Name = "EditPictureBox";
			this.EditPictureBox.Size = new System.Drawing.Size(93, 91);
			this.EditPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.EditPictureBox.TabIndex = 0;
			this.EditPictureBox.TabStop = false;
			// 
			// OkButton
			// 
			this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OkButton.Location = new System.Drawing.Point(514, 468);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(75, 23);
			this.OkButton.TabIndex = 5;
			this.OkButton.Text = "Aceptar";
			this.OkButton.UseVisualStyleBackColor = true;
			// 
			// HelpForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(605, 503);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.TabsController);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "HelpForm";
			this.Text = "Ayuda";
			this.TabsController.ResumeLayout(false);
			this.FirstViewPage.ResumeLayout(false);
			this.FirstViewPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ButtonsPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PlaylistsPictureBox)).EndInit();
			this.MusicViewPage.ResumeLayout(false);
			this.MusicViewPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SongsPictureBox)).EndInit();
			this.SongViewPage.ResumeLayout(false);
			this.SongViewPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PlaylistsLabel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SongPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EditPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl TabsController;
		private System.Windows.Forms.TabPage FirstViewPage;
		private System.Windows.Forms.Label ButtonsHelpLabel;
		private System.Windows.Forms.PictureBox ButtonsPictureBox;
		private System.Windows.Forms.Label PlayListHelpLabel;
		private System.Windows.Forms.PictureBox PlaylistsPictureBox;
		private System.Windows.Forms.TabPage MusicViewPage;
		private System.Windows.Forms.Label SongsHelpLabel;
		private System.Windows.Forms.PictureBox SongsPictureBox;
		private System.Windows.Forms.TabPage SongViewPage;
		private System.Windows.Forms.PictureBox EditPictureBox;
		private System.Windows.Forms.Label EditHelpLabel;
		private System.Windows.Forms.PictureBox SongPictureBox;
		private System.Windows.Forms.Label PlaylistAddingHelpLabel;
		private System.Windows.Forms.PictureBox PlaylistsLabel;
		private System.Windows.Forms.Button OkButton;
	}
}