
namespace Music_Manager {
	partial class SongBox {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongBox));
			this.VideoImageBox = new System.Windows.Forms.PictureBox();
			this.PlayButton = new System.Windows.Forms.Button();
			this.OptionsButton = new System.Windows.Forms.Button();
			this.SongNameLabel = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.VideoImageBox)).BeginInit();
			this.SuspendLayout();
			// 
			// VideoImageBox
			// 
			this.VideoImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoImageBox.Image = ((System.Drawing.Image)(resources.GetObject("VideoImageBox.Image")));
			this.VideoImageBox.Location = new System.Drawing.Point(0, 0);
			this.VideoImageBox.Name = "VideoImageBox";
			this.VideoImageBox.Size = new System.Drawing.Size(190, 144);
			this.VideoImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.VideoImageBox.TabIndex = 0;
			this.VideoImageBox.TabStop = false;
			// 
			// PlayButton
			// 
			this.PlayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayButton.BackgroundImage")));
			this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.PlayButton.Location = new System.Drawing.Point(3, 104);
			this.PlayButton.Name = "PlayButton";
			this.PlayButton.Size = new System.Drawing.Size(37, 37);
			this.PlayButton.TabIndex = 1;
			this.PlayButton.UseVisualStyleBackColor = true;
			this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
			// 
			// OptionsButton
			// 
			this.OptionsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OptionsButton.BackgroundImage")));
			this.OptionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.OptionsButton.Location = new System.Drawing.Point(150, 104);
			this.OptionsButton.Name = "OptionsButton";
			this.OptionsButton.Size = new System.Drawing.Size(37, 37);
			this.OptionsButton.TabIndex = 2;
			this.OptionsButton.UseVisualStyleBackColor = true;
			this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
			// 
			// SongNameLabel
			// 
			this.SongNameLabel.AutoSize = true;
			this.SongNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SongNameLabel.Location = new System.Drawing.Point(-3, 0);
			this.SongNameLabel.Name = "SongNameLabel";
			this.SongNameLabel.Size = new System.Drawing.Size(23, 16);
			this.SongNameLabel.TabIndex = 3;
			this.SongNameLabel.Text = "Ex";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// SongBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.SongNameLabel);
			this.Controls.Add(this.OptionsButton);
			this.Controls.Add(this.PlayButton);
			this.Controls.Add(this.VideoImageBox);
			this.Name = "SongBox";
			this.Size = new System.Drawing.Size(190, 144);
			((System.ComponentModel.ISupportInitialize)(this.VideoImageBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox VideoImageBox;
		private System.Windows.Forms.Button PlayButton;
		private System.Windows.Forms.Button OptionsButton;
		private System.Windows.Forms.Label SongNameLabel;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
	}
}
