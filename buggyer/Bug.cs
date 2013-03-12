using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;

namespace buggyer
{
	public class Bug
	{
		//id, summary, description, reported by, reported at, assigned to, priority, status, comments
		public int id = -1;
		public string Summary;
		public string Description;
		public string ReportedBy;
		public DateTime ReportedAt;
		public string AssignedTo;
		public int Priority;
		public string Status;
		public string Comments;

		public Bug(MySqlDataReader r)
		{
			id = (int)r["id"];
			Summary = (string)r["summary"];
			Description = (string)r["description"];
			ReportedBy = (string)r["reported by"];
			ReportedAt = (DateTime)r["reported at"];
			AssignedTo = (string)r["assigned to"];
			Priority = (sbyte)r["priority"];
			Status = (string)r["status"];
			Comments = (string)r["comments"];
		}

		public override string ToString()
		{
			StringBuilder str=new StringBuilder();
			//id
			str.Append(id);
			str.Append(' ', 4 - id.ToString().Length);
			//status
			str.Append('['); str.Append(Status); str.Append(']');
			str.Append(' ', 10 - Status.Length);
			//summary
			str.Append(Summary);
			return str.ToString();
		}
	}
}
