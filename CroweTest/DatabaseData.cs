using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweTest
{
	class DatabaseData : CroweDataAccess.IDataWriter 
	{
		private string connection;
		public DatabaseData(string connectionString)
		{
			connection = connectionString;
		}
		public bool Write(string data)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(connection))
				{
					throw new Exception("Connection information not provided");
				}

				//using (SqlConnection cn = new SqlConnection(connection) {
				// create a command 
				// write to the database
				//} end using block which automatically closes the connection

				return true;
			}
			catch (Exception ex)
			{
				// log the error somewhere
			}
			return false;
		}
	}
}
