using NUnit.Framework;
using System;
using algorithimdevspace;
namespace algorithimtest
{
	[TestFixture ()]
	public class Sample2
	{
		/*
Sample 2: (6X5 matrix normal flow)

Input:

3 4 1 2 8 6

6 1 8 2 7 4

5 9 3 9 9 5

8 4 1 3 2 6

3 7 2 1 2 3

 

Output(possibility1): I get this one, as my first min part check in the recursion is to the left.

Yes

11

[1 2 1 5 5 5]

Output(possibility1):

Yes

11

[1 2 1 5 4 5]
*/



		[Test ()]
		public void TestCase2 ()
		{
			//Arrange
			MainClass.nodesOnpath =String.Empty;
			MainClass.TravelledFromOneEndofMatrixToNext = String.Empty;
			MainClass.RowGlobal = 5;
			MainClass.ColumnGlobal = 6;
			MainClass.sourcematrix = new int[5,6]{{3,4,1,2,8,6},{6,1,8,2,7,4},{5,9,3,9,9,5},{8,4,1,3,2,6},{3,7,2,1,2,3}};


			//Act

			var result = MainClass.GenerateSmallestPossiblePaths (MainClass.RowGlobal, MainClass.ColumnGlobal);
			MainClass.formatOutput (result);


			//Assert


			Assert.AreEqual(MainClass.minpathValue,"11");
			Assert.AreEqual (MainClass.nodesOnpath, "121555");
			Assert.AreEqual (MainClass.TravelledFromOneEndofMatrixToNext, "Yes");	


		}






	}
}

