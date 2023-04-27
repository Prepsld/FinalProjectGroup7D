using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create by David Prepsl
//On April 26th, 2023
//For OOP2 Final Project
//Used to get and set the properties for a list used in the Main Page


namespace FinalProjectGroup7D.Tables
{
    public class OverviewList
    {

        public string Address { get; set; }
        public string totalCost { get; set; }

        public OverviewList()
        {

        }

        public OverviewList(string addressGet, string totalCostGet)
        {
            Address = addressGet;
            totalCost = totalCostGet;
        }
    }
}
