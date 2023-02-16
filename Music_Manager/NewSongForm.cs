﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Manager {
	public partial class NewSongForm : Form {

		private readonly MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
		private MySqlConnection conn;
		public SongBox SongBoxControl { get; set; }

		public NewSongForm() {
			InitializeComponent();
		}

		private void MusicFilesButton_Click(object sender, EventArgs e) {
			if (MusicFileDialog.ShowDialog() == DialogResult.OK) {
				String[] arr = MusicFileDialog.FileName.Split('\\');
				SongNameLabel.Text = arr[arr.Length - 1];
			}
		}

		private void ImageFilesPictureBox_Click(object sender, EventArgs e) {
			if (ImagesFileDialog.ShowDialog() == DialogResult.OK)
				ImageFilesPictureBox.Image = new Bitmap(ImagesFileDialog.FileName);
		}

		private void FilesOK(object sender, CancelEventArgs e) {
			InfoOK();
		}

		private void NameTextBox_TextChanged(object sender, EventArgs e) {
			InfoOK();
		}

		private void InfoOK() {
			if (
				!String.IsNullOrEmpty(MusicFileDialog.FileName)
				&& !String.IsNullOrEmpty(ImagesFileDialog.FileName)
				&& !String.IsNullOrEmpty(NameTextBox.Text)
				)
				OkButton.Enabled = true;
		}

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

		private void SongInsertion() {
			using (conn = new MySqlConnection(builder.ToString())) {
				conn.Open();
				string sql = "INSERT INTO Song (name, image, music) values(@name, @image, @music);";

				using (MySqlCommand command = new MySqlCommand(sql, conn))
				using (MemoryStream memoryStream = new MemoryStream())
				using (FileStream fileStream = new FileStream(MusicFileDialog.FileName, FileMode.Open, FileAccess.Read)) {

					command.Parameters.Add("@name", MySqlDbType.Text).Value = SongNameLabel.Text.Split('.')[0];

					Image image = ImageFilesPictureBox.Image;
					image.Save(memoryStream, image.RawFormat);
					command.Parameters.Add("@image", MySqlDbType.MediumBlob).Value = memoryStream.ToArray();

					byte[] mp3Bytes = new byte[fileStream.Length];
					fileStream.Read(mp3Bytes, 0, mp3Bytes.Length);
					command.Parameters.Add("@music", MySqlDbType.MediumBlob).Value = mp3Bytes;

					command.ExecuteNonQuery();

					SongBoxControl = new SongBox(1,
						NameTextBox.Text,
						memoryStream.ToArray(),
						mp3Bytes);
				}

				sql = "SELECT id FROM Song WHERE name = @name";
				using (MySqlCommand command = new MySqlCommand(sql, conn)) {
					command.Parameters.Add("@name", MySqlDbType.Text).Value = SongNameLabel.Text.Split('.')[0];
					using (MySqlDataReader reader = command.ExecuteReader()) {
						reader.Read();
						SongBoxControl.SongId = Convert.ToInt32(reader["id"]);
					}
				}
			}
		}

		private void NewSongForm_Load(object sender, EventArgs e) {
			builder.Server = "192.168.1.23";
			builder.UserID = "esco";
			builder.Password = "lalimonada47";
			builder.Database = "DINT_DATABASE";
		}
	}
}
