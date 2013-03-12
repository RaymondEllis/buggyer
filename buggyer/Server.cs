using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;

namespace buggyer
{
	static class Server
	{
		public static MySqlConnection Conn;
		public static string Table;
		public static string UID;

		public static bool Connect(String str)
		{
			Conn = new MySqlConnection(str);
			return Open() && Close();
		}

		public static bool Open()
		{
			if (Conn.State == System.Data.ConnectionState.Open) return true;
			try
			{
				Conn.Open();
				return true;
			}
			catch (MySqlException e)
			{
				if (e.Number == 1045)
				{ ShowError("Invalid username/password!"); }
				else
				{ ShowError(e.Message); }
				Conn = null;
				return false;
			}
		}
		public static bool Close()
		{
			try
			{
				Conn.Close();
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
