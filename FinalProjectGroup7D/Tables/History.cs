using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create by Markus Luthi
//On April 25th, 2023
//For OOP2 Final Project

namespace FinalProjectGroup7D.Tables
{
    public class History
    {
        public int UtilityNum { get; set; }
        public int AddressNum { get; set; }
        public float Usage { get; set; }
        public string Startdate { get; set; }
        public string Enddate { get; set; }

        public History()
        {

        }

        public History(int utilityNum, int addressNum, float usage, string startdate, string enddate)
        {
            UtilityNum = utilityNum;
            AddressNum = addressNum;
            Usage = usage;
            Startdate = startdate;
            Enddate = enddate;
        }
    }
}
