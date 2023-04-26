using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create by Markus Luthi
//On April 25th, 2023
//For OOP2 Final Project
//Used to get and set the properties for the History class

namespace FinalProjectGroup7D.Tables
{
    public class History
    {
        public int UtilityNum { get; set; }
        public int AddressNum { get; set; }
        public float Usage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Enddate { get; set; }

        public History()
        {

        }

        public History(int utilityNum, int addressNum, float usage, DateTime startdate, DateTime enddate)
        {
            UtilityNum = utilityNum;
            AddressNum = addressNum;
            Usage = usage;
            StartDate = startdate;
            Enddate = enddate;
        }
    }
}
