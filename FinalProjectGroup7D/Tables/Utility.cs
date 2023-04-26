using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGroup7D.Tables
{
    public class Utility
    {
        public int UtilityNum { get; set; }
        public int AddressNum { get; set; }
        public float Usage { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public Utility()
        {

        }

        public Utility(int utilityNum, int addressNum, float usage, string startDate, string endDate)
        {
            UtilityNum = utilityNum;
            AddressNum = addressNum;
            Usage = usage;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
