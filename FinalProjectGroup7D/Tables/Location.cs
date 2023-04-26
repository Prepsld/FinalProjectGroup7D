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
    public class Location
    {
        public int AddressNum { get; set; }
        public int Accountnum { get; set; }
        public string PropertyLocation { get; set; }

        public Location()
        {

        }

        public Location(int addressNum, int accountnum, string propertyLocation)
        {
            AddressNum = addressNum;
            Accountnum = accountnum;
            PropertyLocation = propertyLocation;
        }
    }
}
