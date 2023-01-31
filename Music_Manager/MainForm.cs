using System;
using System.Windows.Forms;
using WMPLib;

namespace Music_Manager {
	public partial class MainForm : Form {

		WindowsMediaPlayer musicControl = new WindowsMediaPlayer();

		public MainForm() {
			InitializeComponent();
		}

		private void PlayButton_Click(object sender, EventArgs e) {

			Console.WriteLine(musicControl.playState);
			switch (musicControl.playState) {
				case WMPPlayState.wmppsPlaying:
					musicControl.controls.pause();
					PlayButton.ImageIndex = 0;
					break;

				case WMPPlayState.wmppsPaused:
					musicControl.controls.play();
					PlayButton.ImageIndex = 1;
					break;

				case WMPPlayState.wmppsReady:
					musicControl.controls.play();
					PlayButton.ImageIndex = 1;
					break;

				case WMPPlayState.wmppsUndefined:
					musicControl.URL = @"C:\Users\ciclosm\Downloads\What is wrong with.mp3";
					musicControl.controls.play();
					PlayButton.ImageIndex = 1;
					break;
			}

			Console.WriteLine(musicControl.status);
		}

		private void PreviousButton_Click(object sender, EventArgs e) {
			Console.WriteLine(musicControl.status);
		}

		private void NextButton_Click(object sender, EventArgs e) {
			Console.WriteLine(musicControl.settings.volume);
		}

		private void LoopButton_Click(object sender, EventArgs e) {

		}

		private void ShuffleButton_Click(object sender, EventArgs e) {

		}

		private void SearchPageButton_Click(object sender, EventArgs e) {
			TabsController.SelectTab(1);
			SearchPageButton.Enabled = false;
			ControllerPageButton.Enabled = true;
		}

		private void ControllerPageButton_Click(object sender, EventArgs e) {
			TabsController.SelectTab(0);
			SearchPageButton.Enabled = true;
			ControllerPageButton.Enabled = false;
		}
	}
}
