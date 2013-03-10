using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace buggyer
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void frmLogin_Shown(object sender, EventArgs e)
		{
			load_Settings();
		}
		private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			save_Settings();
		}

		private void load_Settings()
		{
			if (System.IO.File.Exists("settings.sd") == false) return;
			String data;
			using (System.IO.StreamReader sr = new System.IO.StreamReader("settings.sd"))
			{
				data = sr.ReadToEnd();
			}
			SimpleD.Group g = new SimpleD.Group();
			String results = g.FromString(data);
			if (results == null || results.Length == 0)
			{
				foreach (SimpleD.Property p in g.Properties)
				{
					bool chk;
					switch (p.Name.ToLowerInvariant())
					{
						case "saveserver":
							if (bool.TryParse(p.Value, out chk)) chkSaveServer.Checked = chk;
							break;
						case "savedatabase":
							if (bool.TryParse(p.Value, out chk)) chkSaveDatabase.Checked = chk;
							break;
						case "saveuid":
							if (bool.TryParse(p.Value, out chk)) chkSaveUID.Checked = chk;
							break;

						case "server":
							txtServer.Text = p.Value;
							break;
						case "database":
							txtDatabase.Text = p.Value;
							break;
						case "uid":
							txtUID.Text = p.Value;
							txtPassword.Focus();
							break;
					}
				}
			}
			else
			{
				MessageBox.Show("Could not parse settings.sd file!", "buggyer - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void save_Settings()
		{
			SimpleD.Group g = new SimpleD.Group();
			g.Properties.Add(new SimpleD.Property("SaveServer", chkSaveServer.Checked.ToString()));
			g.Properties.Add(new SimpleD.Property("SaveDatabase", chkSaveDatabase.Checked.ToString()));
			g.Properties.Add(new SimpleD.Property("SaveUID", chkSaveUID.Checked.ToString()));
			if (chkSaveServer.Checked) g.Properties.Add(new SimpleD.Property("Server", txtServer.Text));
			if (chkSaveDatabase.Checked) g.Properties.Add(new SimpleD.Property("Database", txtDatabase.Text));
			if (chkSaveUID.Checked) g.Properties.Add(new SimpleD.Property("UID", txtUID.Text));

			String data = g.ToString();
			using (System.IO.StreamWriter sw = new System.IO.StreamWriter("settings.sd"))
			{
				sw.Write(data);
			}
		}
		
		private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				tryConnect();
				e.Handled = true;
			}
		}

		private void tryConnect()
		{
			StringBuilder str = new StringBuilder();
			str.Append("SERVER="); str.Append(txtServer.Text); str.Append(';');
			str.Append("DATABASE="); str.Append(txtDatabase.Text); str.Append(';');
			str.Append("UID="); str.Append(txtUID.Text); str.Append(';');
			str.Append("PASSWORD="); str.Append(txtPassword.Text); str.Append(';');

			str.Append("Convert Zero Datetime=True;");
			if (Server.Connect(str.ToString()))
			{
				//ToDo: Will show other form to figerout what to do next.
				this.Close();
			}
		}

	}
}
