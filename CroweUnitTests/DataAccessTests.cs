using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CroweDataAccess;
namespace CroweUnitTests
{
	[TestClass]
	public class DataAccessTests
	{
		[TestMethod]
		public void TestMethod1()
		{
			//arrange
			DataHandler data = new DataHandler();

			//act
			string results = data.RetrieveData();

			//assert
			// uncomment this line to run a breaking test
			//Assert.AreEqual("Good-bye World!", results);
			Assert.AreEqual("Hello World!", results);

		}
	}
}
