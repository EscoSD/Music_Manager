using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Music_Manager {
	/// <summary>
	/// Clase contenedora del formulario de creación de canción.
	/// </summary>
	public partial class NewSongForm : Form {

		/// <summary>
		/// SongBox para almacenar información.
		/// </summary>
		public SongBox SongBoxControl { get; set; }

		/// <summary>
		/// Constructor por defecto.
		/// </summary>
		public NewSongForm() {
			InitializeComponent();
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
		/// Evento llamado al elegir una File en cualquiera de los FileDialogs.
		/// </summary>
		/// <param name="sender">El objeto emisor del evento.</param>
		/// <param name="e">Los argumentos del evento.</param>
		private void FilesOK(object sender, CancelEventArgs e) {
			InfoOK();
		}

		/// <summary>
		/// Evento llamado al modificar información del TextBox para el nombre.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NameTextBox_TextChanged(object sender, EventArgs e) {
			InfoOK();
		}

		/// <summary>
		/// Método que comprueba que todos los campos están rellenados y permite confirmar la creación.
		/// </summary>
		private void InfoOK() {
			if (
				!String.IsNullOrEmpty(MusicFileDialog.FileName)
				&& !String.IsNullOrEmpty(ImagesFileDialog.FileName)
				&& !String.IsNullOrEmpty(NameTextBox.Text)
				)
				OkButton.Enabled = true;
		}

		/// <summary>
		/// Evento de clicado del botón de aceptar.
		/// </summary>
		/// <param name="sender">El objeto emisor del evento.</param>
		/// <param name="e">Los argumentos del evento.</param>
		private void AcceptButton_Click(object sender, EventArgs e) {
			try {
			SongInsertion();
			} catch (MySqlException) {
				String message = "Por favor, conecta la base de datos.";
				String caption = "Aviso!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;

				// Reproducción de sonido de aviso
				System.Media.SystemSounds.Exclamation.Play();

				MessageBox.Show(message, caption, buttons);
				DialogResult = DialogResult.Cancel;
			}
		}

		/// <summary>
		/// Método de inserción de una canción en la base de datos.
		/// </summary>
		private void SongInsertion() {
			using (MySqlConnection conn = DataConnection.GetConnection()) {
				conn.Open();
				string sql = "INSERT INTO Song (name, image, music) values(@name, @image, @music);";

				using (MySqlCommand command = new MySqlCommand(sql, conn))
				using (MemoryStream memoryStream = new MemoryStream()) {
					command.Parameters.Add("@name", MySqlDbType.Text).Value = NameTextBox.Text;

					Image image = ImageFilesPictureBox.Image;
					image.Save(memoryStream, image.RawFormat);
					command.Parameters.Add("@image", MySqlDbType.MediumBlob).Value = memoryStream.ToArray();

					byte[] mp3Bytes = File.ReadAllBytes(MusicFileDialog.FileName);
					command.Parameters.Add("@music", MySqlDbType.MediumBlob).Value = mp3Bytes;

					command.ExecuteNonQuery();

					SongBoxControl = new SongBox(1,
						NameTextBox.Text,
						memoryStream.ToArray(),
						mp3Bytes);
				}

				sql = "SELECT id FROM Song WHERE name = @name";
				using (MySqlCommand command = new MySqlCommand(sql, conn)) {
					command.Parameters.Add("@name", MySqlDbType.Text).Value = NameTextBox.Text;
					using (MySqlDataReader reader = command.ExecuteReader()) {
						reader.Read();
						SongBoxControl.SongId = Convert.ToInt32(reader["id"]);
					}
				}
			}
		}
	}
}
