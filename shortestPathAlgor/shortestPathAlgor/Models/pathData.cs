using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shortestPathAlgor.Models
{
    public class pathData
    {

        public int minValue;
        public String rows;
        public String columns;


        public pathData(int minValues, string row, string column)
        {
            minValue = minValues;
            rows = row;
            columns = column;
        }
    }
}
