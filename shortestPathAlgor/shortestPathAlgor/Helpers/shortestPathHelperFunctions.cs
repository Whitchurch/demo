using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shortestPathAlgor.Models;

namespace shortestPathAlgor.Helpers
{
    class shortestPathHelperFunctions
    {
        //Input probes for testing the program
        public static int[,] sourcematrix;
        public static int ColumnGlobal = 0;
        public static int RowGlobal = 0;
        public static int MaximumAllowedPathWeight = 0;

        //Output probes for getting the test results
        public static string minpathValue = String.Empty;
        public static string nodesOnpath = String.Empty;
        public static string TravelledFromOneEndofMatrixToNext = String.Empty;

        public static ResultFromrun Main(int prows,int pcolumns,int[,]pData)
        {
            //Step0: Source matrix
            sourcematrix = pData;

            //  Step1: Enter the Rows in the matrix

            int rows = prows;
            RowGlobal = rows;




            //Step2: Enter the Columns in the matrix

            int columns = pcolumns;
            ColumnGlobal = columns;



            //Step3: Generate the matrix
            //GenerateUserInput(rows, columns,sourcematrix); //Not needed....





            //Step4: Generate all possible paths  and then return the smallest value path.	
            var minValue = GenerateSmallestPossiblePaths(rows, columns);





            //Step5: Display the results, in the required format
             ResultFromrun finalResult =   formatOutput(minValue);

            return finalResult;
            

        }

        #region "Helper Functions"

		//Display the results in the required format upto a limit
		public static void formatOutputN(pathData minValue,int limit)
		{

			pathData result = minValue;

			
			minpathValue = result.minValue.ToString();


			String sReplace = result.rows.Replace (",", String.Empty);
			char[] srow = sReplace.ToCharArray ();

			String sReplace1 = result.columns.Replace (",", String.Empty);
			char[] scolumn = sReplace1.ToCharArray ();

			//Extract co-oridnates from chars.

			int[] irows = new int[srow.Length];
			int[] icolumns = new int[scolumn.Length];

			int irowCounter = 0;
			int icolumncounter = 0;
			foreach (var item in srow) 
			{
				irows [irowCounter] = Int32.Parse (item.ToString());
				irowCounter++;
			}

			foreach (var item in scolumn) 
			{
				icolumns [icolumncounter] = Int32.Parse (item.ToString());
				icolumncounter++;
			}
		

			int countOfItemsToRemove = 0;

			for(int i = 0; i< irows.Length;i++)
			{
				for (int j = 0; j < icolumns.Length; j++) 
				{
					
					if (result.minValue > limit) {
						result.minValue = result.minValue - sourcematrix [i, j];
						countOfItemsToRemove++;
						minpathValue = result.minValue.ToString ();
						formatOutputN (result, limit);



					} else {
						
						return;
					}
				}
			}



			String sRevereseReplace = sReplace.Remove (0, countOfItemsToRemove);
			char[] s1 = sRevereseReplace.ToCharArray ();

			Array.Reverse (s1);

			foreach (var item in s1) 
			{
				nodesOnpath += (Int32.Parse (item.ToString ()) + 1).ToString ();
				
			}

			

			if (s1.Length == ColumnGlobal) {
				
				TravelledFromOneEndofMatrixToNext = "Yes";			
			} else 
			{
				
				TravelledFromOneEndofMatrixToNext = "No";	
			}
				
		}


		//Display the results in the required format
		public static Models.ResultFromrun formatOutput(pathData minValue)
		{

            nodesOnpath = String.Empty;

			pathData result = minValue;

			
			minpathValue = result.minValue.ToString();


			String sReplace = result.rows.Replace (",", String.Empty);
			char[] s1 = sReplace.ToCharArray ();

			Array.Reverse (s1);

			foreach (var item in s1) 
			{
				nodesOnpath += (Int32.Parse (item.ToString ()) + 1).ToString ();
				
			}



			

			if (s1.Length == ColumnGlobal) {
				
				TravelledFromOneEndofMatrixToNext = "Yes";			
			} else 
			{
				
				TravelledFromOneEndofMatrixToNext = "No";	
			}


            ResultFromrun Finalresult = new ResultFromrun(minpathValue, nodesOnpath, TravelledFromOneEndofMatrixToNext);
            return Finalresult;
		}




		//Generate all possible paths runs. Each run has (weightedCost, nodes in the path)
		public static pathData GenerateSmallestPossiblePaths(int rows, int columns)
		{
			pathData[] RunContext = new pathData[rows];
			var listOfRunContenxt = new List<pathData> ();

			for (int i = 0; i < rows; i++) 
			{
				//Call shortest path algorithim
				RunContext[i] = shortestPathHelperFunctions.cost (i, columns-1);
				listOfRunContenxt.Add (RunContext [i]);


			}

			//This part is to get the least costly path from all the runs
			pathData minValue = new pathData (RunContext[0].minValue,RunContext[0].rows.ToString(),RunContext[0].columns.ToString());
			foreach (var item in listOfRunContenxt) 
			{

				if (item.minValue < minValue.minValue) {
					minValue.minValue = item.minValue;
					minValue.rows = item.rows;
					minValue.columns = item.columns;
				}
			}

			return minValue;
		}






		//Construct the input matrix
		public static void GenerateUserInput(int rows, int columns,int[,]pData)
		{
            shortestPathHelperFunctions.sourcematrix = new int[rows,columns];

			for (int i = 0; i < rows; i++)
			{

				for (int j = 0; j < columns; j++)
                {
                    shortestPathHelperFunctions.sourcematrix[i, j] = pData[i, j];
				}

			}
		}






		//The shortest path algorithim
		public static pathData cost(int i, int j)
		{
			

			

				//If we are a cell i in the leftmost column return the value in that cell, as there are no other columns to the left of us to look at.
				if (j == 0) 
				{
					var p1 = new pathData (shortestPathHelperFunctions.sourcematrix [i, 0],i.ToString(),"0");	
					return p1;

					//return MainClass.sourcematrix [i, 0];
				}
				//If we are in any other column other than the last column. Look at cells in the next column to the left of our column. That are on the top, left and bottom, to find the min weighted one
				int leftPosX = i % RowGlobal;
				int leftPosY = j - 1;
				pathData left = cost (leftPosX, leftPosY);

				int upPosX = (i - 1 + RowGlobal) % RowGlobal;
				int upPosY = j-1;
				pathData up = cost (upPosX, upPosY);

				int downPosX = (i + 1) % RowGlobal;
				int downPosY = j - 1;
				pathData down = cost (downPosX, downPosY);


				var listOfCosts = new List<pathData>{left,up,down};
				pathData minValue = new pathData (left.minValue,left.rows.ToString(),left.columns.ToString());
				foreach (var item in listOfCosts) 
				{

					if (item.minValue < minValue.minValue) {
						minValue.minValue = item.minValue;
						minValue.rows = item.rows;
						minValue.columns = item.columns;
					}
				}
				

				minValue.minValue = shortestPathHelperFunctions.sourcematrix[i,j]+minValue.minValue;
				minValue.rows = i.ToString () + "," + minValue.rows.ToString ();
				minValue.columns = j.ToString () + "," + minValue.columns.ToString ();
				return minValue;




		}
		#endregion
    }
}
