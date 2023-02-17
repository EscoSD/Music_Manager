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

	/// <summary>
	/// Clase del componente personalizado.
	/// </summary>
	public partial class SongBox : UserControl {

		/// <summary>
		/// Id de la canción.
		/// </summary>
		public int SongId { get; set; }

		/// <summary>
		/// Nombre de la canción.
		/// </summary>
		public String SongName { get; set; }

		/// <summary>
		/// Contenedor de los Bytes de la imagen.
		/// </summary>
		public byte[] SongImage { get; set; }

		/// <summary>
		/// Contenedor de los Bytes de la música.
		/// </summary>
		public byte[] Music { get; set; }

		/// <summary>
		/// Manejador de eventos del botón de reproducción.
		/// </summary>
		public event EventHandler PlayButtonClickHandler;

		/// <summary>
		/// Manejador de eventos del botón de edición.
		/// </summary>
		public event EventHandler EditButtonClickHandler;

		/// <summary>
		/// Constructor por defecto.
		/// </summary>
		public SongBox() {
			InitializeComponent();
		}

		/// <summary>
		/// Constructor general.
		/// </summary>
		/// <param name="id">Id de la canción.</param>
		/// <param name="name">Nombre de la canción.</param>
		/// <param name="image">Contenedor de los Bytes de la imagen.</param>
		/// <param name="music">Contenedor de los Bytes de la música.</param>
		public SongBox(int id, String name, byte[] image, byte[] music) {
			InitializeComponent();

			SongId = id;

			SongName = name;
			SongNameLabel.Text = name;

			SongImage = image;
			VideoImageBox.Image = Image.FromStream(new MemoryStream(image));

			Music = music;

			ToolTips.SetToolTip(SongNameLabel, SongNameLabel.Text);
		}

		/// <summary>
		/// Evento de clicado del botón de reproducción.
		/// </summary>
		/// <param name="sender">El objeto emisor del evento.</param>
		/// <param name="e">Los argumentos del evento.</param>
		private void PlayButton_Click(object sender, EventArgs e) {
			PlayButtonClickHandler.Invoke(this, e);
		}

		/// <summary>
		/// Evento de clicado del botón de edición.
		/// </summary>
		/// <param name="sender">El objeto emisor del evento.</param>
		/// <param name="e">Los argumentos del evento.</param>
		private void EditButton_Click(object sender, EventArgs e) {
			EditButtonClickHandler.Invoke(this, e);
		}

		/// <summary>
		/// Método que actualiza los componentes visuales de la SongBox cuando se edita la información.
		/// </summary>
		public void UpdateComponents() {
			SongNameLabel.Text = SongName;
			VideoImageBox.Image = Image.FromStream(new MemoryStream(SongImage));
		}
	}
}
