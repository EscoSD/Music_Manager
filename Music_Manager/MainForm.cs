using System;
using System.Windows.Forms;
using WPFLib;

namespace Music_Manager {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		private void PlayBtn_Click(object sender, EventArgs e) {
			/*WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
			

			wplayer.URL = "My MP3 file.mp3";
			wplayer.Controls.Play();*/
			// Añadir de la woolbox el WindowsMediaPlayer para ir testeando.
		}
	}
}
