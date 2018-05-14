using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CroweTest
{
	class Program
	{
		static void Main(string[] args)
		{

			string s = ConfigurationManager.AppSettings["Destination"];
			CroweDataAccess.IDataWriter writer = null;
			CroweDataAccess.DataHandler dataService = new CroweDataAccess.DataHandler();
			switch (s.ToLower())
			{
				case "console":
					writer = new StreamData(Console.Out);
					break;
				case "database":
					writer = new DatabaseData("connectionString");
					break;
				default:
					Console.WriteLine("Invalid destination.  Please check the Destination value in App.config");
					break;
			}
			if (writer != null)
				dataService.WriteData(writer);

			//pause after operations are complete
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("press any key to continue");
			Console.ReadKey();
		}
	}
}
