using NUnit.Framework;
using System;
using algorithimdevspace;
namespace algorithimtest
{
	[TestFixture ()]
	public class Sample1a
	{
		/*
Sample 1.a: (5X6 matrix normal flow) --> 6 Columns and 5 Rows

Input:

3 4 1 2 8 6 <- Row1

6 1 8 2 7 4 <- Row2

5 9 3 9 9 5 <-Row3

8 4 1 3 2 6 <-Row4

8 4 1 3 2 6 <-Row5

 

Output:

Yes

15

[1 2 1 1 5 1]
		*/

		[Test ()]
		public void TestCase1a ()
		{
			//Arrange
			MainClass.nodesOnpath =String.Empty;
			MainClass.TravelledFromOneEndofMatrixToNext = String.Empty;
			MainClass.RowGlobal = 5;
			MainClass.ColumnGlobal = 6;
			MainClass.sourcematrix = new int[5,6]{{3,4,1,2,8,6},{6,1,8,2,7,4},{5,9,3,9,9,5},{8,4,1,3,2,6},{8,4,1,3,2,6}};


			//Act

			var result = MainClass.GenerateSmallestPossiblePaths (MainClass.RowGlobal, MainClass.ColumnGlobal);
			MainClass.formatOutput (result);


			//Assert


			Assert.AreEqual(MainClass.minpathValue,"15");
			Assert.AreEqual (MainClass.nodesOnpath, "121151");
			Assert.AreEqual (MainClass.TravelledFromOneEndofMatrixToNext, "Yes");	


		}




	}
}

