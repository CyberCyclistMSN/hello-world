using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweTest
{
	class StreamData : CroweDataAccess.IDataWriter
	{
		private System.IO.TextWriter writer;
		public StreamData(System.IO.TextWriter textWriter)
		{
			writer = textWriter;
		}
		public bool Write(string data) 
		{
			try
			{
				if (writer != null)
				{
					writer.WriteLine(data);
				}
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}