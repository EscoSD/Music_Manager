using System;
using System.Windows.Forms;

namespace Music_Manager {
	public partial class NewPlaylistForm : Form {

		public String PlaylistName { get; set; }

		public NewPlaylistForm() {
			InitializeComponent();
		}

		private void AcceptButton_Click(object sender, EventArgs e) {
			PlaylistName = NameTextBox.Text;
		}
	}
}
