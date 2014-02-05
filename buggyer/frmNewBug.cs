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
			lblReportedBy.Text = Server.UID;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (Server.Open())
			{
				MySqlCommand cmd = new MySqlCommand(
					"INSERT INTO `" + Server.Database + "`.`" + Server.Table + "`\n" +
					"(`id`,`summary`,`description`,`reported by`,`reported at`,`assigned to`,`priority`,`status`,`comments`)" +
					"\n VALUES " +
					"(NULL,@summary,@description,@reportedby,@reportedat,@assignedto,@priority,@status,@comments)", Server.Connection);


				cmd.Parameters.AddWithValue("@summary", txtSummary.Text);
				cmd.Parameters.AddWithValue("@description", txtDescription.Text);
				cmd.Parameters.AddWithValue("@reportedby", lblReportedBy.Text);
				string reportedAt = DateTime.UtcNow.ToString("yyyy-MM-dd H:mm:ss");
				cmd.Parameters.AddWithValue("@reportedat", reportedAt);
				cmd.Parameters.AddWithValue("@assignedto", txtAssignedTo.Text);
				cmd.Parameters.AddWithValue("@priority", txtPriority.Text);
				cmd.Parameters.AddWithValue("@status", txtStatus.Text);
				cmd.Parameters.AddWithValue("@comments", txtComments.Text);

				try
				{
					cmd.ExecuteNonQuery();
					this.Close();
				}
				catch (MySqlException ex)
				{
					Server.ShowError(ex.Message);
				}
				finally
				{
					Server.Close();
				}

			}
		}
	}
}
