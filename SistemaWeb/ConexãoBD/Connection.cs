using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace Albertinho09
{
	public class DBConnection
	{
		private static SqlConnection instance;
		//construtor
		public DBConnection()
		{
		}
		public static SqlConnection Instance
		{
			get
			{
				if (instance == null)
					instance = new SqlConnection(ConfigurationManager.ConnectionStrings["conexaoaula9"].ConnectionString);
				return instance;
			}
		}
	}
}
