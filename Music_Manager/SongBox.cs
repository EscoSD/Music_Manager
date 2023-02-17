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
	public partial class SongBox : UserControl {

		public int SongId { get; set; }
		public String SongName { get; set; }
		public byte[] Image { get; set; }
		public byte[] Music { get; set; }

		public event EventHandler PlayButtonClickHandler;
		public event EventHandler OptionsButtonClickHandler;

		public SongBox() {
			InitializeComponent();
		}

		public SongBox(int id, String name, byte[] image, byte[] music) {
			InitializeComponent();

			SongId = id;

			SongName = name;
			SongNameLabel.Text = name;

			Image = image;
			VideoImageBox.Image = DataUtilities.ByteToImage(image);

			Music = music;
		}

		private void PlayButton_Click(object sender, EventArgs e) {
			PlayButtonClickHandler.Invoke(this, e);
		}

		private void OptionsButton_Click(object sender, EventArgs e) {
			OptionsButtonClickHandler.Invoke(this, e);
		}

		public void UpdateComponents() {
			SongNameLabel.Text = SongName;
			VideoImageBox.Image = DataUtilities.ByteToImage(Image);
		}
	}
}
