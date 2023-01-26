using System;
using System.Windows.Forms;
using WMPLib;

namespace Music_Manager {
	public partial class MainForm : Form {

		WindowsMediaPlayer musicControl = new WindowsMediaPlayer();

		public MainForm() {
			InitializeComponent();
			
		}

		/*private void PlayBtn_Click(object sender, EventArgs e) {

			Console.WriteLine(musicControl.playState);
			switch (musicControl.playState) {
				case WMPPlayState.wmppsPlaying:
					musicControl.controls.pause();
					PlayBtn.ImageIndex = 0;
					break;

				case WMPPlayState.wmppsPaused:
					musicControl.controls.play();
					PlayBtn.ImageIndex = 1;
					break;

				case WMPPlayState.wmppsReady:
					musicControl.controls.play();
					PlayBtn.ImageIndex = 1;
					break;

				case WMPPlayState.wmppsUndefined:
					musicControl.URL = @"C:\Users\ciclosm\Downloads\What is wrong with.mp3";
					musicControl.controls.play();
					PlayBtn.ImageIndex = 1;
					break;
			}

			Console.WriteLine(musicControl.status);
		}

		private void PreviousBtn_Click(object sender, EventArgs e) {
			Console.WriteLine(musicControl.status);
		}

		private void NextBtn_Click(object sender, EventArgs e) {
			Console.WriteLine(musicControl.settings.volume);
		}

		private void LoopBtn_Click(object sender, EventArgs e) {

		}

		private void ShuffleBtn_Click(object sender, EventArgs e) {

		}*/
	}
}
