using System;
using System.Windows.Forms;
using WMPLib;
using MySql.Data.MySqlClient;
using System.IO;

namespace Music_Manager {
	public partial class MainForm : Form {

		public WindowsMediaPlayer musicControl = new WindowsMediaPlayer();
		private readonly MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
		private MySqlConnection conn;

		public MainForm() {
			InitializeComponent();

			musicControl.PlayStateChange += MusicStateController;
			musicControl.settings.volume = VolumeTrackBar.Value;

			builder.Server = "192.168.1.22";
			builder.UserID = "esco";
			builder.Password = "lalimonada47";
			builder.Database= "DINT_DATABASE";

			ChargeFlowLayout();
		}

		private void PlayButton_Click(object sender, EventArgs e) {

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

		private void DatabaseAddingButton_Click(object sender, EventArgs e) {
			SongBox songBox = new SongBox();
			songBox.PlayButtonClickHandler += new System.EventHandler(this.SongBoxPlayButton_Click);
			songBox.OptionsButtonClickHandler += new System.EventHandler(this.OptionsBoxPlayButton_Click);
			SongsContainer.Controls.Add(songBox);
		}

		private void SongBoxPlayButton_Click(object sender, EventArgs e) {
			//sender = (SongBox)sender;
			MusicReproduction(((SongBox) sender).Music);
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

			Console.WriteLine(musicControl.playState);
			switch (musicControl.playState) {
				case WMPPlayState.wmppsPlaying:
					PlayButton.ImageIndex = 0;
					break;

				case WMPPlayState.wmppsPaused:
					PlayButton.ImageIndex = 1;
					break;

				case WMPPlayState.wmppsReady:
					PlayButton.ImageIndex = 1;
					break;

				case WMPPlayState.wmppsUndefined:
					PlayButton.ImageIndex = 1;
					break;
			}

			Console.WriteLine(musicControl.status);
		}

		private void MusicReproduction(byte[] music) {

			//if (musicControl.playState != WMPPlayState.)
			// ASEGURARASE DE QUE NO SE ESTÁ REPRODUCIENDO NADA PARA PODER INICIAR UNA SEGUNDA CANCIÓN

			Console.WriteLine("Reproooo");

			string tempFile = "tempFile.mp3";
			File.WriteAllBytes(tempFile, music);
			File.Move(tempFile, Path.ChangeExtension(tempFile, ".mp3"));

			// Reproducir el archivo temporal
			musicControl.URL = tempFile;
			musicControl.controls.play();
		}

		private void VolumeTrackBar_ValueChanged(object sender, EventArgs e) {
			musicControl.settings.volume = VolumeTrackBar.Value;
		}
	}


}
