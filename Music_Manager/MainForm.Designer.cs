
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
			this.SongPanel = new System.Windows.Forms.Panel();
			this.ControlsPanel = new System.Windows.Forms.Panel();
			this.ShuffleBtn = new System.Windows.Forms.Button();
			this.LoopBtn = new System.Windows.Forms.Button();
			this.NextBtn = new System.Windows.Forms.Button();
			this.PreviousBtn = new System.Windows.Forms.Button();
			this.PlayBtn = new System.Windows.Forms.Button();
			this.PlayImageList = new System.Windows.Forms.ImageList(this.components);
			this.ControlsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// SongPanel
			// 
			this.SongPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SongPanel.Location = new System.Drawing.Point(341, 12);
			this.SongPanel.Name = "SongPanel";
			this.SongPanel.Size = new System.Drawing.Size(447, 195);
			this.SongPanel.TabIndex = 0;
			// 
			// ControlsPanel
			// 
			this.ControlsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ControlsPanel.Controls.Add(this.ShuffleBtn);
			this.ControlsPanel.Controls.Add(this.LoopBtn);
			this.ControlsPanel.Controls.Add(this.NextBtn);
			this.ControlsPanel.Controls.Add(this.PreviousBtn);
			this.ControlsPanel.Controls.Add(this.PlayBtn);
			this.ControlsPanel.Location = new System.Drawing.Point(341, 213);
			this.ControlsPanel.Name = "ControlsPanel";
			this.ControlsPanel.Size = new System.Drawing.Size(447, 225);
			this.ControlsPanel.TabIndex = 1;
			// 
			// ShuffleBtn
			// 
			this.ShuffleBtn.Image = global::Music_Manager.Properties.Resources.shuffle_FILL0_wght400_GRAD0_opsz48;
			this.ShuffleBtn.Location = new System.Drawing.Point(51, 129);
			this.ShuffleBtn.Name = "ShuffleBtn";
			this.ShuffleBtn.Size = new System.Drawing.Size(64, 61);
			this.ShuffleBtn.TabIndex = 4;
			this.ShuffleBtn.UseVisualStyleBackColor = true;
			this.ShuffleBtn.Click += new System.EventHandler(this.ShuffleBtn_Click);
			// 
			// LoopBtn
			// 
			this.LoopBtn.Image = global::Music_Manager.Properties.Resources.repeat_FILL0_wght400_GRAD0_opsz48;
			this.LoopBtn.Location = new System.Drawing.Point(331, 129);
			this.LoopBtn.Name = "LoopBtn";
			this.LoopBtn.Size = new System.Drawing.Size(64, 61);
			this.LoopBtn.TabIndex = 3;
			this.LoopBtn.UseVisualStyleBackColor = true;
			this.LoopBtn.Click += new System.EventHandler(this.LoopBtn_Click);
			// 
			// NextBtn
			// 
			this.NextBtn.Image = global::Music_Manager.Properties.Resources.skip_next_FILL0_wght400_GRAD0_opsz48;
			this.NextBtn.Location = new System.Drawing.Point(261, 129);
			this.NextBtn.Name = "NextBtn";
			this.NextBtn.Size = new System.Drawing.Size(64, 61);
			this.NextBtn.TabIndex = 2;
			this.NextBtn.UseVisualStyleBackColor = true;
			this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
			// 
			// PreviousBtn
			// 
			this.PreviousBtn.Image = global::Music_Manager.Properties.Resources.skip_previous_FILL0_wght400_GRAD0_opsz48;
			this.PreviousBtn.Location = new System.Drawing.Point(121, 129);
			this.PreviousBtn.Name = "PreviousBtn";
			this.PreviousBtn.Size = new System.Drawing.Size(64, 61);
			this.PreviousBtn.TabIndex = 1;
			this.PreviousBtn.UseVisualStyleBackColor = true;
			this.PreviousBtn.Click += new System.EventHandler(this.PreviousBtn_Click);
			// 
			// PlayBtn
			// 
			this.PlayBtn.ImageIndex = 0;
			this.PlayBtn.ImageList = this.PlayImageList;
			this.PlayBtn.Location = new System.Drawing.Point(191, 129);
			this.PlayBtn.Name = "PlayBtn";
			this.PlayBtn.Size = new System.Drawing.Size(64, 61);
			this.PlayBtn.TabIndex = 0;
			this.PlayBtn.UseVisualStyleBackColor = true;
			this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
			// 
			// PlayImageList
			// 
			this.PlayImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("PlayImageList.ImageStream")));
			this.PlayImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.PlayImageList.Images.SetKeyName(0, "play_arrow_FILL0_wght400_GRAD0_opsz48.png");
			this.PlayImageList.Images.SetKeyName(1, "pause_FILL0_wght400_GRAD0_opsz48.png");
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ControlsPanel);
			this.Controls.Add(this.SongPanel);
			this.Name = "MainForm";
			this.Text = "Octavia";
			this.ControlsPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel SongPanel;
		private System.Windows.Forms.Panel ControlsPanel;
		private System.Windows.Forms.Button ShuffleBtn;
		private System.Windows.Forms.Button LoopBtn;
		private System.Windows.Forms.Button NextBtn;
		private System.Windows.Forms.Button PreviousBtn;
		private System.Windows.Forms.Button PlayBtn;
		private System.Windows.Forms.ImageList PlayImageList;
	}
}

