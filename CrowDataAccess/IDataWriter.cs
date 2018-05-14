using System;
using System.Collections.Generic;
using System.Text;

namespace CroweDataAccess
{
    public interface IDataWriter
    {
		bool Write(string data);
    }
}
