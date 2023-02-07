/*using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Manager {
	class SQLManagement {


		private readonly MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder {
			Server = "192.168.1.22",
			UserID = "esco",
			Password = "lalimonada47",
			Database= "DINT_DATABASE"
		};
		private MySqlConnection conn;

		MySqlDataReader SQLRead() {
			using (conn = new MySqlConnection(builder.ToString())) {
				conn.Open();

				string query = "SELECT * FROM Song";
				using (MySqlCommand command = new MySqlCommand(query, conn))
				using (MySqlDataReader reader = command.ExecuteReader()) {
					
				}
			}

			return reader;
		}
	}
}
*/