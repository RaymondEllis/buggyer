using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace buggyer
{
	public partial class frmNewBug : Form
	{
		public frmNewBug()
		{
			InitializeComponent();
		}

		private void frmNewBug_Load(object sender, EventArgs e)
		{
			//TODO: ReportedAt is not saving properly.
			lblReportedAt.Text = DateTime.Now.ToString();
			lblReportedBy.Text = Server.UID;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (Server.Open())
			{
				StringBuilder query = new StringBuilder();
				
				query.Append("INSERT INTO `" +Server.Database+"`.`" + Server.Table + "` (");
				query.Append("\n`id`,`summary`,`description`,`reported by`,`reported at`,`assigned to`,`priority`,`status`,`comments`");
				query.Append("\n)");
				query.Append("\nVALUES (");
				query.Append("\nNULL ,");
				query.Append("\n'"); query.Append(txtSummary.Text.Replace("'", "''")); query.Append("',");
				query.Append("\n'"); query.Append(txtDescription.Text.Replace("'", "''")); query.Append("',");
				query.Append("\n'"); query.Append(lblReportedBy.Text.Replace("'", "''")); query.Append("',");
				query.Append("\n'"); query.Append(lblReportedAt.Text.Replace("'", "''")); query.Append("',");
				query.Append("\n'"); query.Append(txtAssignedTo.Text.Replace("'", "''")); query.Append("',");
				query.Append("\n'"); query.Append(txtPriority.Text.Replace("'", "''")); query.Append("',");
				query.Append("\n'"); query.Append(txtStatus.Text.Replace("'", "''")); query.Append("',");
				query.Append("\n'"); query.Append(txtComments.Text.Replace("'", "''")); query.Append("'");
				query.Append("\n);");

				MySqlCommand cmd = new MySqlCommand(query.ToString(), Server.Connection);
				try
				{
					cmd.ExecuteNonQuery();
				}
				catch (MySqlException ex) { Server.ShowError(ex.Message); }
			}
			Server.Close();
		}
	}
}
