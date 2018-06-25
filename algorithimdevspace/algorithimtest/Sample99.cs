using NUnit.Framework;
using System;
using algorithimdevspace;
namespace algorithimtest
{
	[TestFixture ()]
	public class Sample99
	{

		[Test ()]


		/*
Sample 1: (5X6 matrix normal flow) --> 6 Columns and 5 Rows

Input:

3 4 1 2 8 6 <- Row1

6 1 8 2 7 4 <- Row2

5 9 3 9 9 5 <-Row3

8 4 1 3 2 6 <-Row4

3 7 2 8 6 4 <-Row5

 

Output:

Yes

16

[1 2 3 4 4 5]
		*/


		public void TestCase99 ()
		{
			//Arrange
			MainClass.nodesOnpath =String.Empty;
			MainClass.TravelledFromOneEndofMatrixToNext = String.Empty;
			MainClass.RowGlobal = 2;
			MainClass.ColumnGlobal = 20;
			MainClass.sourcematrix = new int[2,20]{{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},{2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2}};


			//Act

			var result = MainClass.GenerateSmallestPossiblePaths (MainClass.RowGlobal, MainClass.ColumnGlobal);
			MainClass.formatOutput (result);


			//Assert


			Assert.AreEqual(MainClass.minpathValue,"20");
			Assert.AreEqual (MainClass.nodesOnpath, "11111111111111111111");
			Assert.AreEqual (MainClass.TravelledFromOneEndofMatrixToNext, "Yes");	


		}





	}
}

