using MySql.Data.MySqlClient;

namespace Music_Manager {
	/// <summary>
	/// Clase que maneja la creación de conexiones.
	/// </summary>
	class DataConnection {

		/// <summary>
		/// Método que abre una conexión y la devuelve.
		/// </summary>
		/// <returns>La conexión a la base de datos.</returns>
		public static MySqlConnection GetConnection() {
			MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder {
				Server = "192.168.1.23",
				UserID = "esco",
				Password = "lalimonada47",
				Database = "DINT_DATABASE"
			};

			return new MySqlConnection(builder.ToString());
		}
	}
}
