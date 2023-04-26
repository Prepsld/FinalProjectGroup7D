using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create by Markus Luthi
//On April 25th, 2023
//For OOP2 Final Project
//Used to get and set the properties for the Location class

namespace FinalProjectGroup7D.Tables
{
    public class Location
    {
        public int AddressNum { get; set; }
        public int AccountNum { get; set; }
        public string PropertyLocation { get; set; }

        public Location()
        {

        }

        public Location(int addressNum, int accountnum, string propertyLocation)
        {
            AddressNum = addressNum;
            AccountNum = accountnum;
            PropertyLocation = propertyLocation;
        }
    }
}
