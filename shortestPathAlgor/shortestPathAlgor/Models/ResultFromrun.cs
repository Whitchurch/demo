using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shortestPathAlgor.Models
{
    public class ResultFromrun
    {
        public string minpathValue;
        public String nodesOnpath;
        public String TravelledFromOneEndofMatrixToNext;

        public ResultFromrun(string pminpathValue, string pnodesOnPath,string pTravelledFromOneEndofMatrixToNext)
        {
            this.minpathValue = pminpathValue;
            this.nodesOnpath = pnodesOnPath;
            this.TravelledFromOneEndofMatrixToNext = pTravelledFromOneEndofMatrixToNext;
        }
    }
}
