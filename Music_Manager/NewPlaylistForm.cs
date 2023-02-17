using System;
using System.Windows.Forms;

namespace Music_Manager {
	/// <summary>
	/// Clase con un formulario para crear listas de reproducción.
	/// </summary>
	public partial class NewPlaylistForm : Form {

		/// <summary>
		/// Nombre de la Playlist.
		/// </summary>
		public String PlaylistName { get; set; }

		/// <summary>
		/// Constructor por defecto.
		/// </summary>
		public NewPlaylistForm() {
			InitializeComponent();
		}

		/// <summary>
		/// Evento de clicado del botón de aceptar.
		/// </summary>
		/// <param name="sender">El emisor del evento.</param>
		/// <param name="e">Los argumentos del evento.</param>
		private void AcceptButton_Click(object sender, EventArgs e) {
			PlaylistName = NameTextBox.Text;
		}
	}
}
