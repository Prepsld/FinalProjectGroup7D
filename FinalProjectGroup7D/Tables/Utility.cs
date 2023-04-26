using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create by Markus Luthi
//On April 25th, 2023
//For OOP2 Final Project
//Used to get and set the properties for the Utility class
namespace FinalProjectGroup7D.Tables
{
    public class Utility
    {
        public int UtilityNum { get; set; }
        public string Type { get; set; }
        public float Rate { get; set; }

        public Utility()
        {

        }

        public Utility(int utilityNum, string type, float rate)
        {
            UtilityNum = utilityNum;
            Type = type;
            Rate = rate;
        }
    }
}
