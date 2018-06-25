using NUnit.Framework;
using System;
using algorithimdevspace;
namespace algorithimtest
{
	[TestFixture ()]
	public class Sample4
	{
		/*
		Sample 4: (1X5 matrix)

		Input:

		5 8 5 3 5



		Output:

		Yes

		26

		[1 1 1 1 1]
		*/

		[Test ()]
		public void TestCase4 ()
		{
			//Arrange
			MainClass.nodesOnpath =String.Empty;
			MainClass.TravelledFromOneEndofMatrixToNext = String.Empty;
			MainClass.RowGlobal = 1;
			MainClass.ColumnGlobal = 5;
			MainClass.sourcematrix = new int[1,5]{{5,8,5,3,5}};


			//Act

			var result = MainClass.GenerateSmallestPossiblePaths (MainClass.RowGlobal, MainClass.ColumnGlobal);
			MainClass.formatOutput (result);


			//Assert


			Assert.AreEqual(MainClass.minpathValue,"26");
			Assert.AreEqual (MainClass.nodesOnpath, "11111");
			Assert.AreEqual (MainClass.TravelledFromOneEndofMatrixToNext, "Yes");	


		}
			


	}
}

