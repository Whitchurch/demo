using NUnit.Framework;
using System;
using algorithimdevspace;
namespace algorithimtest
{
	[TestFixture ()]
	public class Sample5
	{
		/*

Sample 5: (5X1 matrix)

Input:

5

8

5

3

5

 

Output:

Yes

3

[4]		*/

		[Test ()]
		public void TestCase5 ()
		{
			//Arrange
			MainClass.nodesOnpath =String.Empty;
			MainClass.TravelledFromOneEndofMatrixToNext = String.Empty;
			MainClass.RowGlobal = 5;
			MainClass.ColumnGlobal = 1;
			MainClass.sourcematrix = new int[5,1]{{5},{8},{5},{3},{5}};


			//Act

			var result = MainClass.GenerateSmallestPossiblePaths (MainClass.RowGlobal, MainClass.ColumnGlobal);
			MainClass.formatOutput (result);


			//Assert


			Assert.AreEqual(MainClass.minpathValue,"3");
			Assert.AreEqual (MainClass.nodesOnpath, "4");
			Assert.AreEqual (MainClass.TravelledFromOneEndofMatrixToNext, "Yes");	


		}
			

	}
}

