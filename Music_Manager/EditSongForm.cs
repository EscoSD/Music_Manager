using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Music_Manager {
	public partial class EditSongForm : Form {

		private bool editEnabled = false;
		private SongBox songBox;

		public EditSongForm() {
			InitializeComponent();
		}

		public EditSongForm(SongBox songBox) {
			InitializeComponent();

			this.songBox = songBox;

			NameTextBox.Text = this.songBox.SongName;
			ImageFilesPictureBox.Image = DataUtilities.ByteToImage(this.songBox.Image);

			try {
				LoadPlaylists();
			} catch(MySqlException) {
				String message = "Por favor, conecta la base de datos.";
				String caption = "Aviso!";
				MessageBoxButtons buttons = MessageBoxButtons.OK;

				// Reproducción de sonido de aviso
				System.Media.SystemSounds.Exclamation.Play();

				MessageBox.Show(message, caption, buttons);
			}
		}

		private void LoadPlaylists() {
			/*using (MySqlConnection conn = DataUtilities.GetConnection()) {
				conn.Open();
				string query = "SELECT * FROM Playlist";

				using (MySqlCommand command = new MySqlCommand(query, conn))
				using (MySqlDataReader reader = command.ExecuteReader())
					while (reader.Read())
						break;
						//PlaylistsDGV.Rows.Add(reader["name"]);
			}*/
		}

		private void MusicFilesButton_Click(object sender, EventArgs e) {
			if (MusicFileDialog.ShowDialog() == DialogResult.OK) {
				String[] arr = MusicFileDialog.FileName.Split('\\');
				SongNameLabel.Text = arr[arr.Length - 1];

				SongNameLabel.Visible = true;
			}
		}

		private void ImageFilesPictureBox_Click(object sender, EventArgs e) {
			if (ImagesFileDialog.ShowDialog() == DialogResult.OK)
				ImageFilesPictureBox.Image = new Bitmap(ImagesFileDialog.FileName);
		}

		private void EnableEditButton_Click(object sender, EventArgs e) {
			editEnabled = !editEnabled;

			if (editEnabled) {
				EnableEditButton.Text = "Guardar";

				NameTextBox.Enabled = true;
				MusicFilesButton.Enabled = true;
				ImageFilesPictureBox.Enabled = true;
				CancelEditButton.Enabled = true;
				OkButton.Enabled = false;
			}

			else {
				EnableEditButton.Text = "Editar";

				NameTextBox.Enabled = false;
				MusicFilesButton.Enabled = false;
				ImageFilesPictureBox.Enabled = false;
				CancelEditButton.Enabled = false;
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

		private void CancelEditButton_Click(object sender, EventArgs e) {

			editEnabled = !editEnabled;
			EnableEditButton.Text = "Editar";

			NameTextBox.Enabled = false;
			MusicFilesButton.Enabled = false;
			ImageFilesPictureBox.Enabled = false;
			CancelEditButton.Enabled = false;
			OkButton.Enabled = true;
			SongNameLabel.Visible = false;

			NameTextBox.Text = songBox.SongName;
			ImageFilesPictureBox.Image = DataUtilities.ByteToImage(songBox.Image);
		}

		private void UpdateSongContent() {
			using (MySqlConnection conn = DataUtilities.GetConnection()) {
				conn.Open();
				string sql = "UPDATE Song SET name = @name, image = @image, music = @music WHERE id = @id;";

				using (MySqlCommand command = new MySqlCommand(sql, conn))
				using (MemoryStream memoryStream = new MemoryStream())
				using (FileStream fileStream = new FileStream(MusicFileDialog.FileName, FileMode.Open, FileAccess.Read)) {

					command.Parameters.Add("@id", MySqlDbType.Int32).Value = songBox.SongId;

					command.Parameters.Add("@name", MySqlDbType.Text).Value = NameTextBox.Text;
					songBox.SongName = NameTextBox.Text;

					Image image = ImageFilesPictureBox.Image;
					image.Save(memoryStream, image.RawFormat);
					command.Parameters.Add("@image", MySqlDbType.MediumBlob).Value = memoryStream.ToArray();
					songBox.Image = memoryStream.ToArray();

					byte[] mp3Bytes = new byte[fileStream.Length];
					fileStream.Read(mp3Bytes, 0, mp3Bytes.Length);
					command.Parameters.Add("@music", MySqlDbType.MediumBlob).Value = mp3Bytes;
					songBox.Music = mp3Bytes;

					command.ExecuteNonQuery();
				}
			}
		}
	}
}
