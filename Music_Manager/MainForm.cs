using System;
using System.Windows.Forms;
using WMPLib;
using MySql.Data.MySqlClient;
using System.IO;

namespace Music_Manager {
	public partial class MainForm : Form {

		public WindowsMediaPlayer musicPlayer = new WindowsMediaPlayer();
		private readonly MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
		private MySqlConnection conn;

		public MainForm() {
			InitializeComponent();

			musicPlayer.PlayStateChange += MusicStateController;
			musicPlayer.settings.volume = VolumeTrackBar.Value;
			//musicControl.DurationUnitChange += new WMPLib._WMPOCXEvents_DurationUnitChangeEventHandler(DurationTracker);

			builder.Server = "localhost";
			builder.UserID = "root";
			builder.Password = "";
			builder.Database= "DINT_DATABASE";

			ChargeFlowLayout();
		}

		private void PlayButton_Click(object sender, EventArgs e) {
			switch (musicPlayer.playState) {
				case WMPPlayState.wmppsPlaying:
					musicPlayer.controls.pause();
					break;
				case WMPPlayState.wmppsPaused:
					musicPlayer.controls.play();
					break;
			}

			Console.WriteLine(musicPlayer.playState);
		}

		private void PreviousButton_Click(object sender, EventArgs e) {
			Console.WriteLine(musicPlayer.status);
		}

		private void NextButton_Click(object sender, EventArgs e) {
			Console.WriteLine(musicPlayer.settings.volume);
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

		private void DatabaseAddingButton_Click(object sender, EventArgs e) {
			using (NewSongForm songForm = new NewSongForm())
				if (songForm.ShowDialog() == DialogResult.OK) {
					songForm.SongBoxControl.PlayButtonClickHandler += new System.EventHandler(this.SongBoxPlayButton_Click);
					songForm.SongBoxControl.OptionsButtonClickHandler += new System.EventHandler(this.OptionsBoxPlayButton_Click);
					SongsContainer.Controls.Add(songForm.SongBoxControl);
				}
		}

		private void SongBoxPlayButton_Click(object sender, EventArgs e) {
			MusicReproduction(((SongBox) sender).Music, ((SongBox)sender).Image, ((SongBox)sender).SongName);
		}

		private void OptionsBoxPlayButton_Click(object sender, EventArgs e) {
		}

		private void ChargeFlowLayout() {
			using (conn = new MySqlConnection(builder.ToString())) {
				conn.Open();

				string query = "SELECT * FROM Song";
				using (MySqlCommand command = new MySqlCommand(query, conn))
				using (MySqlDataReader reader = command.ExecuteReader()) {
					SongBox songBox;

					while (reader.Read()) {
						songBox = new SongBox (
								Convert.ToInt32(reader["id"]),
								Convert.ToString(reader["name"]),
								(byte[])reader["image"],
								(byte[])reader["music"]
						);
						songBox.PlayButtonClickHandler += new System.EventHandler(this.SongBoxPlayButton_Click);
						songBox.OptionsButtonClickHandler += new System.EventHandler(this.OptionsBoxPlayButton_Click);
						SongsContainer.Controls.Add(songBox);
					}
				}
			}
		}

		private void MusicStateController(int newState) {

			Console.WriteLine(musicPlayer.playState);
			switch (musicPlayer.playState) {
				case WMPPlayState.wmppsPlaying:
					PlayButton.ImageIndex = 1;
					break;

				case WMPPlayState.wmppsPaused:
					PlayButton.ImageIndex = 0;
					break;

				case WMPPlayState.wmppsReady:
					PlayButton.ImageIndex = 0;
					break;

				case WMPPlayState.wmppsUndefined:
					PlayButton.ImageIndex = 0;
					break;
			}

			Console.WriteLine(musicPlayer.status);
		}

		private void MusicReproduction(byte[] music, byte[] image, String name) {

			Console.WriteLine("Reproduction");

			//string tempFile = @"..\..\Resources\tempFile.mp3";
			string tempFile = Path.GetTempFileName();

			SongImagePB.Image = SongBox.ByteToImage(image);
			SongNameLabel.Text = name;

			//File.Move(tempFile, Path.ChangeExtension(tempFile, ".mp3"));
			Console.WriteLine(tempFile);
			File.WriteAllBytes(tempFile, music);

			// Reproducir el archivo temporal
			//musicPlayer.currentPlaylist.appendItem(musicPlayer.newMedia(tempFile));
			musicPlayer.URL = tempFile;
			musicPlayer.controls.play();

			DurationTrackBar.Maximum = (int)musicPlayer.currentMedia.duration;
			Console.WriteLine(DurationTrackBar.Maximum);

			Console.WriteLine(tempFile);
		}

		private void VolumeTrackBar_ValueChanged(object sender, EventArgs e) {
			musicPlayer.settings.volume = VolumeTrackBar.Value;
		}

		/*private void DurationTracker(int newDurationUnit) {
			Console.WriteLine(newDurationUnit + " pos");
			DurationTrackBar.Value = newDurationUnit;
		}*/

		private void FilterTextBox_TextChanged(object sender, EventArgs e) {
			if (!String.IsNullOrEmpty(FilterTextBox.Text))
				foreach (SongBox songBox in SongsContainer.Controls)
					songBox.Visible = songBox.SongName.ToLower().Contains(FilterTextBox.Text.ToLower());

			else
				foreach (SongBox songBox in SongsContainer.Controls)
					songBox.Visible = true;
		}
	}
}
