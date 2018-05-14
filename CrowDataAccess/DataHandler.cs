using System;

namespace CroweDataAccess
{
    public class DataHandler
    {
		public string RetrieveData()
		{
			return "Hello World!";
		}
		public bool WriteData(IDataWriter writer)
		{
			return writer.Write(RetrieveData());
		}
    }
}
