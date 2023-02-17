using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace Music_Manager {

	/// <summary>
	/// Clase que incluye el formulario principal.
	/// Incluye las vistas de reproducción y la vista contenedora de música.
	/// </summary>
	public partial class MainForm : Form {

		/// <summary>
		/// Objeto que controla todo lo relacionado con la música.
		/// </summary>
		public WindowsMediaPlayer musicPlayer = new WindowsMediaPlayer();

		/// <summary>
		/// Constructor por defecto.
		/// </summary>
		public MainForm() {
			InitializeComponent();
		}

		/// <summary>
		/// Método que se ejecuta al cargarse el formulario.
		/// </summary>
		/// <param name="sender">El emisor del evento.</param>
		/// <param name="e">Los argumentos del evento.</param>
		private void MainForm_Load(object sender, EventArgs e) {
			musicPlayer.PlayStateChange += MusicStateController;
			musicPlayer.settings.volume = VolumeTrackBar.Value;

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

			if (PlaylistsDGV.RowCount > 0)
				EmptyDGVLabel.Visible = false;
		}

		/// <summary>
		/// Evento de clicado del botón de reproducción.
		/// </summary>
		/// <param name="sender">El emisor del evento.</param>
		/// <param name="e">Los argumentos del evento.</param>
		private void PlayButton_Click(object sender, EventArgs e) {
			switch (musicPlayer.playState) {
				case WMPPlayState.wmppsPlaying:
					musicPlayer.controls.pause();
					break;
				case WMPPlayState.wmppsPaused:
					musicPlayer.controls.play();
					break;
			}
		}

		/// <summary>
		/// Evento de clicado del botón de la página donde se encuentran las canciones.
		/// Cambia la página actual.
		/// </summary>
		/// <param name="sender">El emisor del evento.</param>
		/// <param name="e">Los argumentos del evento.</param>
		private void DatabasePageButton_Click(object sender, EventArgs e) {
			TabsController.SelectTab(1);
			DatabasePageButton.Enabled = false;
			ControllerPageButton.Enabled = true;
		}

		/// <summary>
		/// Evento de clicado del botón de la página donde se encuentran los controles de la música.
		/// Cambia la página actual.
		/// </summary>
		/// <param name="sender">El emisor del evento.</param>
		/// <param name="e">Los argumentos del evento.</param>
		private void ControllerPageButton_Click(object sender, EventArgs e) {
			TabsController.SelectTab(0);
			DatabasePageButton.Enabled = true;
			ControllerPageButton.Enabled = false;
		}

		/// <summary>
		/// Evento de clicado del botón de añadir una canción.
		/// Abre un formulario de creación de canción.
		/// </summary>
		/// <param name="sender">El emisor del evento.</param>
		/// <param name="e">Los argumentos del evento.</param>
		private void DatabaseAddingButton_Click(object sender, EventArgs e) {
			using (NewSongForm songForm = new NewSongForm())
				if (songForm.ShowDialog() == DialogResult.OK) {
					songForm.SongBoxControl.PlayButtonClickHandler += new System.EventHandler(this.SongBoxPlayButton_Click);
					songForm.SongBoxControl.EditButtonClickHandler += new System.EventHandler(this.EditSongBoxButton_Click);
					SongsContainer.Controls.Add(songForm.SongBoxControl);
				}
		}

		/// <summary>
		/// Evento de clicado del botón del componente personalizado para reproducir una canción.
		/// </summary>
		/// <param name="sender">El emisor del evento.</param>
		/// <param name="e">Los argumentos del evento.</param>
		private void SongBoxPlayButton_Click(object sender, EventArgs e) {
			MusicReproduction(((SongBox)sender).Music, ((SongBox)sender).SongImage, ((SongBox)sender).SongName);
		}

		/// <summary>
		/// Evento de clicado del botón de edición de una canción.
		/// </summary>
		/// <param name="sender">El emisor del evento.</param>
		/// <param name="e">Los argumentos del evento.</param>
		private void EditSongBoxButton_Click(object sender, EventArgs e) {
			using (EditSongForm editSongForm = new EditSongForm((SongBox)sender)) {
				editSongForm.ShowDialog();
			}
		}

		/// <summary>
		/// Evento que se ejecuta al principio de la aplicación.
		/// Accede a la base de datos y carga el FlowLayout con canciones.
		/// </summary>
		private void ChargeFlowLayout() {
			using (MySqlConnection conn = DataConnection.GetConnection()) {
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
						songBox.EditButtonClickHandler += new System.EventHandler(this.EditSongBoxButton_Click);
						SongsContainer.Controls.Add(songBox);
					}
				}
			}
		}

		/// <summary>
		/// Evento que se ejecuta al principio de la aplicación.
		/// Accede a la base de datos y carga el DGV con playlists.
		/// </summary>
		private void ChargePlaylistsDGV() {
			using (MySqlConnection conn = DataConnection.GetConnection()) {
				conn.Open();
				string query = "SELECT * FROM Playlist";

				using (MySqlCommand command = new MySqlCommand(query, conn))
				using (MySqlDataReader reader = command.ExecuteReader())
					while (reader.Read())
						PlaylistsDGV.Rows.Add(reader["name"]);

			}
		}

		/// <summary>
		/// Evento controlador del estado de las canciones.
		/// </summary>
		/// <param name="newState">Nuevo estado adquirido por la canción en reproducción.</param>
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

		/// <summary>
		/// Evento que reproduce una canción y cambia la imagen de la PictureBox principal.
		/// </summary>
		/// <param name="music">Array de Bytes contenedor de la canción.</param>
		/// <param name="image">Array de Bytes contenedor de la imagen.</param>
		/// <param name="name">Nombre de la canción.</param>
		private void MusicReproduction(byte[] music, byte[] image, String name) {

			Console.WriteLine("Reproduction");

			string tempFile = Path.GetTempFileName();

			SongImagePB.Image = Image.FromStream(new MemoryStream(image));
			SongNameLabel.Text = name;

			Console.WriteLine(tempFile);
			File.WriteAllBytes(tempFile, music);

			// Reproducir el archivo temporal
			musicPlayer.URL = tempFile;
			musicPlayer.controls.play();

			Console.WriteLine(tempFile);
		}

		/// <summary>
		/// Evento de movimiento de la barra de volumen.
		/// Cambia el volumen de reproducción de las canciones.
		/// </summary>
		/// <param name="sender">El emisor del evento.</param>
		/// <param name="e">Los argumentos del evento.</param>
		private void VolumeTrackBar_ValueChanged(object sender, EventArgs e) {
			musicPlayer.settings.volume = VolumeTrackBar.Value;
		}

		/// <summary>
		/// Evento del filtro para las canciones.
		/// </summary>
		/// <param name="sender">El emisor del evento.</param>
		/// <param name="e">Los argumentos del evento.</param>
		private void FilterTextBox_TextChanged(object sender, EventArgs e) {
			if (!String.IsNullOrEmpty(FilterTextBox.Text))
				foreach (SongBox songBox in SongsContainer.Controls)
					songBox.Visible = songBox.SongName.ToLower().Contains(FilterTextBox.Text.ToLower());

			else
				foreach (SongBox songBox in SongsContainer.Controls)
					songBox.Visible = true;
		}

		/// <summary>
		/// Evento del botón de creación de listas de reproducción.
		/// </summary>
		/// <param name="sender">El emisor del evento.</param>
		/// <param name="e">Los argumentos del evento.</param>
		private void NewPlaylistButton_Click(object sender, EventArgs e) {
			try {
				ListInsertion();

				if (PlaylistsDGV.RowCount > 0)
					EmptyDGVLabel.Visible = false;
				
			} catch (MySqlException) {
				String message = "Por favor, conecta la base de datos.";
				String caption = "Aviso!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;

				// Reproducción de sonido de aviso
				System.Media.SystemSounds.Exclamation.Play();

				MessageBox.Show(message, caption, buttons);
			}
		}

		/// <summary>
		/// Método de inserción de una lista de reproducción en la base de datos.
		/// </summary>
		private void ListInsertion() {
			using (NewPlaylistForm playlistForm = new NewPlaylistForm()) {
				if (playlistForm.ShowDialog() == DialogResult.OK) {
					PlaylistsDGV.Rows.Add(
						playlistForm.PlaylistName
					);

					using (MySqlConnection conn = DataConnection.GetConnection()) {
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

		/// <summary>
		/// Evento controlador de clicadp de las celdas del DGV de playlists.
		/// </summary>
		/// <param name="sender">El emisor del evento.</param>
		/// <param name="e">Los argumentos del evento.</param>
		private void PlaylistsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e) {

			// Se comprueba que la celda clicada no pertenezca al encabezado
			if (e.RowIndex > -1) {
				try {
					DGVCellEvents(e);
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

		/// <summary>
		/// Método que comprueba que columna se ha clicado para realizar la acción consecuente.
		/// </summary>
		/// <param name="e">Los argumentos del evento.</param>
		private void DGVCellEvents(DataGridViewCellEventArgs e) {
			
			// Columna de editar seleccionada
			if (e.ColumnIndex == 1) {
				String oldName = PlaylistsDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
				using (NewPlaylistForm playlistForm = new NewPlaylistForm()) {

					playlistForm.Text = "Editar Playlist";

					if (playlistForm.ShowDialog() == DialogResult.OK) {
						PlaylistsDGV.Rows[e.RowIndex].Cells[0].Value = playlistForm.PlaylistName;

						using (MySqlConnection conn = DataConnection.GetConnection()) {
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
					using (MySqlConnection conn = DataConnection.GetConnection()) {
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

				if (PlaylistsDGV.RowCount == 0)
					EmptyDGVLabel.Visible = true;
			}
		}

		/// <summary>
		/// Evento de clicado del menú de ayuda.
		/// </summary>
		/// <param name="sender">El emisor del evento.</param>
		/// <param name="e">Los argumentos del evento.</param>
		private void HelpMenuItem_Click(object sender, EventArgs e) {
			new HelpForm().ShowDialog();
		}
	}
}
