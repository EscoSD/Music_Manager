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
		public String SongName { get; }
		public byte[] Image { get; }
		public byte[] Music { get; }

		public event EventHandler PlayButtonClickHandler;
		public event EventHandler OptionsButtonClickHandler;

		public SongBox() {
			InitializeComponent();
		}

		public SongBox(int id, String name, byte[] image, byte[] music) {
			InitializeComponent();

			this.SongId = id;

			this.SongName = name;
			SongNameLabel.Text = name;

			this.Image = image;
			VideoImageBox.Image = ByteToImage(image);

			this.Music = music;
		}

		private void PlayButton_Click(object sender, EventArgs e) {
			PlayButtonClickHandler.Invoke(this, e);
		}

		private void OptionsButton_Click(object sender, EventArgs e) {
			OptionsButtonClickHandler.Invoke(this, e);
		}

		public static Bitmap ByteToImage(byte[] blob) {
			MemoryStream mStream = new MemoryStream();
			byte[] data = blob;
			mStream.Write(data, 0, Convert.ToInt32(data.Length));
			Bitmap bm = new Bitmap(mStream, false);
			mStream.Dispose();
			return bm;
		}
	}
}
