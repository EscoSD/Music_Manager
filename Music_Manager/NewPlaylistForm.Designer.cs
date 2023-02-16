
namespace Music_Manager {
	partial class NewPlaylistForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPlaylistForm));
			this.OkButton = new System.Windows.Forms.Button();
			this.CancelationButton = new System.Windows.Forms.Button();
			this.NameLabel = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// OkButton
			// 
			resources.ApplyResources(this.OkButton, "OkButton");
			this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OkButton.Name = "OkButton";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.AcceptButton_Click);
			// 
			// CancelationButton
			// 
			resources.ApplyResources(this.CancelationButton, "CancelationButton");
			this.CancelationButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelationButton.Name = "CancelationButton";
			this.CancelationButton.UseVisualStyleBackColor = true;
			// 
			// NameLabel
			// 
			resources.ApplyResources(this.NameLabel, "NameLabel");
			this.NameLabel.Name = "NameLabel";
			// 
			// NameTextBox
			// 
			resources.ApplyResources(this.NameTextBox, "NameTextBox");
			this.NameTextBox.Name = "NameTextBox";
			// 
			// NewPlaylistForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.CancelationButton);
			this.Controls.Add(this.OkButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "NewPlaylistForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Button CancelationButton;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.TextBox NameTextBox;
	}
}