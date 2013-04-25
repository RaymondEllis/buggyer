using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;

namespace buggyer
{
	static class Server
	{
		public static MySqlConnection Connection;
		public static string Database;
		public static string Table;
		public static string UID;

		public static bool Connect(String str)
		{
			Connection = new MySqlConnection(str);
			//Test the connection, then return the results.
			return Open() && Close();
		}

		public static bool Open()
		{
			if (Connection.State == System.Data.ConnectionState.Open) return true;
			try
			{
				Connection.Open();
				return true;
			}
			catch (MySqlException e)
			{
				if (e.Number == 1045)
				{ ShowError("Invalid username/password!"); }
				else
				{ ShowError(e.Message); }
				Connection = null;
				return false;
			}
		}
		public static bool Close()
		{
			try
			{
				Connection.Close();
				return true;
			}
			catch (MySqlException e) { ShowError(e.Message); }
			return false;
		}

		public static void ShowError(String msg)
		{
			System.Windows.Forms.MessageBox.Show(msg, "buggyer - Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
		}
	}
}
