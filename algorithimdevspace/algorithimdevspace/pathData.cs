using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace algorithimdevspace
{
	public class pathData
	{
		public int minValue;
		public String rows;
		public String columns;
			

		public pathData (int minValues,string row, string column)
		{
			minValue = minValues;
			rows = row;
			columns = column;
		}
	}
}

