using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace Music_Manager {
	public partial class MainForm : Form {

		public WindowsMediaPlayer musicPlayer = new WindowsMediaPlayer();

		public MainForm() {
			InitializeComponent();
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
			MusicReproduction(((SongBox)sender).Music, ((SongBox)sender).Image, ((SongBox)sender).SongName);
		}

		private void OptionsBoxPlayButton_Click(object sender, EventArgs e) {
			using (EditSongForm editSongForm = new EditSongForm((SongBox)sender)) {
				editSongForm.ShowDialog();
			}
		}

		private void ChargeFlowLayout() {
			using (MySqlConnection conn = DataUtilities.GetConnection()) {
				conn.Open();

				string query = "SELECT * FROM Song";
				using (MySqlCommand command = new MySqlCommand(query, conn))
				using (MySqlDataReader reader = command.ExecuteReader()) {
					SongBox songBox;

					while (reader.Read()) {
						songBox = new SongBox(
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

		private void ChargePlaylistsDGV() {
			using (MySqlConnection conn = DataUtilities.GetConnection()) {
				conn.Open();
				string query = "SELECT * FROM Playlist";

				using (MySqlCommand command = new MySqlCommand(query, conn))
				using (MySqlDataReader reader = command.ExecuteReader())
					while (reader.Read())
						PlaylistsDGV.Rows.Add(reader["name"]);

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

			SongImagePB.Image = DataUtilities.ByteToImage(image);
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

		private void NewPlaylistButton_Click(object sender, EventArgs e) {
			try {
				ListInsertion();
			} catch (MySqlException) {
				String message = "Por favor, conecta la base de datos.";
				String caption = "Aviso!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;

				// Reproducción de sonido de aviso
				System.Media.SystemSounds.Exclamation.Play();

				MessageBox.Show(message, caption, buttons);
			}
		}

		private void ListInsertion() {
			using (NewPlaylistForm playlistForm = new NewPlaylistForm()) {
				if (playlistForm.ShowDialog() == DialogResult.OK) {
					PlaylistsDGV.Rows.Add(
						playlistForm.PlaylistName
					);

					using (MySqlConnection conn = DataUtilities.GetConnection()) {
						conn.Open();
						string sql = "INSERT INTO Playlist (name) values(@name);";

						using (MySqlCommand command = new MySqlCommand(sql, conn)) {
							command.Parameters.Add("@name", MySqlDbType.Text).Value = playlistForm.PlaylistName;
							command.ExecuteNonQuery();
						}
					}
				}
			}
		}

		private void PlaylistsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e) {
			// CREAR UNA LISTA DE REPRODUCCION PARA EL WINDOWSMEDIAPLAYER

			// Se comprueba que la celda clicada no pertenezca al encabezado
			if (e.RowIndex > -1) {
				try {
					DGVCellEvents(e);
				} catch(MySqlException) {
					String message = "Por favor, conecta la base de datos.";
					String caption = "Aviso!";
					MessageBoxButtons buttons = MessageBoxButtons.OK;

					// Reproducción de sonido de aviso
					System.Media.SystemSounds.Exclamation.Play();

					MessageBox.Show(message, caption, buttons);
				}
			}
		}

		private void DGVCellEvents(DataGridViewCellEventArgs e) {
			// Columna de nombre seleccionada
			if (e.ColumnIndex == 0) {

			}
			// Columna de editar seleccionada
			else if (e.ColumnIndex == 1) {

				String oldName = PlaylistsDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
				using (NewPlaylistForm playlistForm = new NewPlaylistForm()) {

					playlistForm.Text = "Editar Playlist";

					if (playlistForm.ShowDialog() == DialogResult.OK) {
						PlaylistsDGV.Rows[e.RowIndex].Cells[0].Value = playlistForm.PlaylistName;

						using (MySqlConnection conn = DataUtilities.GetConnection()) {
							conn.Open();
							string sql = "UPDATE Playlist SET name = @NewName WHERE name = @name;";

							using (MySqlCommand command = new MySqlCommand(sql, conn)) {
								command.Parameters.Add("@name", MySqlDbType.Text).Value = oldName;
								command.Parameters.Add("@NewName", MySqlDbType.Text).Value = playlistForm.PlaylistName;
								command.ExecuteNonQuery();
							}
						}
					}
				}
			}
			// Columna de borrar seleccionada
			else if (e.ColumnIndex == 2) {
				// Creación de variables necesarias para la creación del mensaje
				String message = "¿Eliminar la lista seleccionada?";
				String caption = "Aviso!";
				MessageBoxButtons buttons = MessageBoxButtons.OKCancel;

				// Reproducción de sonido de aviso
				System.Media.SystemSounds.Exclamation.Play();

				// Muestra el mensaje y recoge la salida
				if (MessageBox.Show(message, caption, buttons) == DialogResult.OK) {
					using (MySqlConnection conn = DataUtilities.GetConnection()) {
						conn.Open();
						string sql = "DELETE FROM Playlist WHERE name = @name";

						using (MySqlCommand command = new MySqlCommand(sql, conn)) {
							command.Parameters.Add("@name", MySqlDbType.Text).Value = PlaylistsDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
							command.ExecuteNonQuery();
						}
					}
					// En caso de aceptar, se eliminan los índices seleccionados
					PlaylistsDGV.Rows.RemoveAt(e.RowIndex);
				}
			}
		}

		private void MainForm_Load(object sender, EventArgs e) {
			musicPlayer.PlayStateChange += MusicStateController;
			musicPlayer.settings.volume = VolumeTrackBar.Value;
			//musicControl.DurationUnitChange += new WMPLib._WMPOCXEvents_DurationUnitChangeEventHandler(DurationTracker);

			try {
				ChargeFlowLayout();
				ChargePlaylistsDGV();
			} catch (MySqlException) {
				String message = "Por favor, conecta la base de datos.";
				String caption = "Aviso!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;

				// Reproducción de sonido de aviso
				System.Media.SystemSounds.Exclamation.Play();

				MessageBox.Show(message, caption, buttons);
			}

		}
	}
}
