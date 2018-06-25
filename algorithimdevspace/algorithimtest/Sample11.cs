using NUnit.Framework;
using System;
using algorithimdevspace;
namespace algorithimtest
{
	[TestFixture ()]
	public class Sample11
	{

		[Test ()]


		/*
Sample 10: (Negative values)

Input:

6,3,-5,9

-5,2,4,10

3,-2,6,10

6,-1,-2,10

 

Output:

Yes

0

[2,3 4 1]
		*/


		public void TestCase11 ()
		{
			//Arrange
			MainClass.nodesOnpath =String.Empty;
			MainClass.TravelledFromOneEndofMatrixToNext = String.Empty;
			MainClass.RowGlobal = 4;
			MainClass.ColumnGlobal = 2;
			MainClass.sourcematrix = new int[4,2]{{51,51},{0,51},{51,51},{5,5}};


			//Act

			var result = MainClass.GenerateSmallestPossiblePaths (MainClass.RowGlobal, MainClass.ColumnGlobal);
			MainClass.formatOutput (result);


			//Assert


			Assert.AreEqual(MainClass.minpathValue,"10");
			Assert.AreEqual (MainClass.nodesOnpath, "44");
			Assert.AreEqual (MainClass.TravelledFromOneEndofMatrixToNext, "Yes");	


		}





	}
}

