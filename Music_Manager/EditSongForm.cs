using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Music_Manager {
	/// <summary>
	/// Clase que contiene el formulario de edición de las canciones.
	/// </summary>
	public partial class EditSongForm : Form {

		/// <summary>
		/// Variable global que controla si está activo el modo de edición o no.
		/// </summary>
		private bool editEnabled = false;

		/// <summary>
		/// Instancia de una SongBox de la que se obtendrá información.
		/// En caso de editar la información se modificarán los campos de la SongBox.
		/// </summary>
		private readonly SongBox songBox;

		/// <summary>
		/// Constructor por defecto.
		/// </summary>
		public EditSongForm() {
			InitializeComponent();
		}

		/// <summary>
		/// Constructor que inicializa la SongBox.
		/// </summary>
		/// <param name="songBox">Instancia de la SongBox de la que se sacará la información.</param>
		public EditSongForm(SongBox songBox) {
			InitializeComponent();

			this.songBox = songBox;

			NameTextBox.Text = this.songBox.SongName;
			ImageFilesPictureBox.Image = Image.FromStream(new MemoryStream(this.songBox.SongImage));

			try {
				LoadPlaylists();
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
		/// Método que recoge todas las playlists de la base de datos y las inserta en el ListBox.
		/// </summary>
		private void LoadPlaylists() {
			using (MySqlConnection conn = DataConnection.GetConnection()) {
				conn.Open();
				string query = "SELECT * FROM Playlist";

				using (MySqlCommand command = new MySqlCommand(query, conn))
				using (MySqlDataReader reader = command.ExecuteReader())
					while (reader.Read()) 
						PlaylistListBox.Items.Add(Convert.ToString(reader["name"]));
					

				query = "SELECT p.name FROM Playlist p INNER JOIN Song_Playlist sp ON sp.playlist_id = p.id INNER JOIN Song s ON s.id = sp.song_id WHERE s.id = @SongId;";

				using (MySqlCommand command = new MySqlCommand(query, conn)) {
					command.Parameters.Add("@SongId", MySqlDbType.Int32).Value = songBox.SongId;

					using (MySqlDataReader reader = command.ExecuteReader())
						while (reader.Read()) {
							int index = PlaylistListBox.FindStringExact(Convert.ToString(reader["name"]));
							if (index >= 0)
								PlaylistListBox.SetSelected(index, true);
						}
				}
			}
		}

		/// <summary>
		/// Evento de clicado del botón para añadir un archivo MP3.
		/// Establecerá el texto del SongNameLabel según el nombre del archivo MP3.
		/// </summary>
		/// <param name="sender">El objeto emisor del evento.</param>
		/// <param name="e">Los argumentos del evento.</param>
		private void MusicFilesButton_Click(object sender, EventArgs e) {
			if (MusicFileDialog.ShowDialog() == DialogResult.OK) {
				String[] arr = MusicFileDialog.FileName.Split('\\');
				SongNameLabel.Text = arr[arr.Length - 1];

				SongNameLabel.Visible = true;
			}
		}

		/// <summary>
		/// Evento de clicado de la PictureBox para añadir un archivo de imagen.
		/// También establecerá la imagen de la propia PictureBox.
		/// </summary>
		/// <param name="sender">El objeto emisor del evento.</param>
		/// <param name="e">Los argumentos del evento.</param>
		private void ImageFilesPictureBox_Click(object sender, EventArgs e) {
			if (ImagesFileDialog.ShowDialog() == DialogResult.OK)
				ImageFilesPictureBox.Image = new Bitmap(ImagesFileDialog.FileName);
		}

		/// <summary>
		/// Evento de clicado del botón para habilitar o deshabilitar la edición.
		/// </summary>
		/// <param name="sender">El objeto emisor del evento.</param>
		/// <param name="e">Los argumentos del evento.</param>
		private void EnableEditButton_Click(object sender, EventArgs e) {
			editEnabled = !editEnabled;

			if (editEnabled) {
				EnableEditButton.Text = "Guardar";

				NameTextBox.Enabled = true;
				MusicFilesButton.Enabled = true;
				ImageFilesPictureBox.Enabled = true;
				CancelEditButton.Enabled = true;
				PlaylistListBox.Enabled = true;
				OkButton.Enabled = false;
			}

			else {
				EnableEditButton.Text = "Editar";

				NameTextBox.Enabled = false;
				MusicFilesButton.Enabled = false;
				ImageFilesPictureBox.Enabled = false;
				CancelEditButton.Enabled = false;
				PlaylistListBox.Enabled = false;
				OkButton.Enabled = true;

				try {
					UpdateSongContent();
					songBox.UpdateComponents();
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
		/// Botón de cancelación de la edición de la canción.
		/// </summary>
		/// <param name="sender">El objeto emisor del evento.</param>
		/// <param name="e">Los argumentos del evento</param>
		private void CancelEditButton_Click(object sender, EventArgs e) {

			editEnabled = !editEnabled;
			EnableEditButton.Text = "Editar";

			NameTextBox.Enabled = false;
			MusicFilesButton.Enabled = false;
			ImageFilesPictureBox.Enabled = false;
			CancelEditButton.Enabled = false;
			PlaylistListBox.Enabled = false;
			OkButton.Enabled = true;
			SongNameLabel.Visible = false;

			NameTextBox.Text = songBox.SongName;
			ImageFilesPictureBox.Image = Image.FromStream(new MemoryStream(songBox.SongImage));
		}

		/// <summary>
		/// Método llamado al guardar los datos de la edición.
		/// Se actualiza el contenido de la base de datos.
		/// </summary>
		private void UpdateSongContent() {
			using (MySqlConnection conn = DataConnection.GetConnection()) {
				conn.Open();
				string sql = "UPDATE Song SET name = @name, image = @image, music = @music WHERE id = @id;";

				using (MySqlCommand command = new MySqlCommand(sql, conn))
				using (MemoryStream memoryStream = new MemoryStream()) {

					command.Parameters.Add("@id", MySqlDbType.Int32).Value = songBox.SongId;

					command.Parameters.Add("@name", MySqlDbType.Text).Value = NameTextBox.Text;
					songBox.SongName = NameTextBox.Text;

					Image image = ImageFilesPictureBox.Image;
					image.Save(memoryStream, image.RawFormat);
					command.Parameters.Add("@image", MySqlDbType.MediumBlob).Value = memoryStream.ToArray();
					songBox.SongImage = memoryStream.ToArray();

					byte[] musicBytes = String.IsNullOrEmpty(MusicFileDialog.FileName) ?
						songBox.Music : File.ReadAllBytes(MusicFileDialog.FileName);
					command.Parameters.Add("@music", MySqlDbType.MediumBlob).Value = musicBytes;
					songBox.Music = musicBytes;

					command.ExecuteNonQuery();

				}

				sql = "DELETE FROM Song_Playlist WHERE song_id = @SongId;";
				using (MySqlCommand command = new MySqlCommand(sql, conn)) {
					command.Parameters.Add("@SongId", MySqlDbType.Int32).Value = songBox.SongId;
					command.ExecuteNonQuery();
				}

				sql = "INSERT INTO Song_Playlist (song_id, playlist_id) VALUES (@SongId, @PlaylistId)";
				using (MySqlCommand command = new MySqlCommand(sql, conn)) {

					String query = "SELECT id FROM Playlist	WHERE name = @name";
					command.Parameters.Add("@SongId", MySqlDbType.Int32).Value = songBox.SongId;
					command.Parameters.Add("@PlaylistId", MySqlDbType.Int32);

					foreach (int index in PlaylistListBox.SelectedIndices)
						using (MySqlCommand queryCommand = new MySqlCommand(query, conn)) {
							queryCommand.Parameters.Add("@name", MySqlDbType.VarChar).Value = PlaylistListBox.Items[index].ToString();

							using (MySqlDataReader reader = queryCommand.ExecuteReader()) {
								reader.Read();
								command.Parameters["@PlaylistId"].Value = Convert.ToInt32(reader["id"]);
							}
							command.ExecuteNonQuery();
						}
				}
			}
		}
	}
}
