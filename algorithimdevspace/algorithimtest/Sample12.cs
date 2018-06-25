using NUnit.Framework;
using System;
using algorithimdevspace;
namespace algorithimtest
{
	[TestFixture ()]
	public class Sample12
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


		public void TestCase12 ()
		{
			//Arrange
			MainClass.nodesOnpath =String.Empty;
			MainClass.TravelledFromOneEndofMatrixToNext = String.Empty;
			MainClass.RowGlobal = 4;
			MainClass.ColumnGlobal = 3;
			MainClass.MaximumAllowedPathWeight = 50;
			MainClass.sourcematrix = new int[4,3]{{51,51,51},{0,51,51},{51,51,51},{5,5,51}};


			//Act

			var result = MainClass.GenerateSmallestPossiblePaths (MainClass.RowGlobal, MainClass.ColumnGlobal);
			MainClass.formatOutput (result);


			//Assert


			Assert.AreEqual("10",MainClass.minpathValue);
			Assert.AreEqual ("44",MainClass.nodesOnpath );
			Assert.AreEqual ( "No",MainClass.TravelledFromOneEndofMatrixToNext);	


		}





	}
}

