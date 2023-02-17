using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;

namespace Music_Manager {
	class DataUtilities {
		public static Bitmap ByteToImage(byte[] blob) {
			MemoryStream mStream = new MemoryStream();
			byte[] data = blob;
			mStream.Write(data, 0, Convert.ToInt32(data.Length));
			Bitmap bm = new Bitmap(mStream, false);
			mStream.Dispose();
			return bm;
		}

		public static MySqlConnection GetConnection() {
			MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder {
				Server = "localhost",
				UserID = "root",
				Password = "",
				Database = "DINT_DATABASE"
			};

			return new MySqlConnection(builder.ToString());
		}
	}
}
