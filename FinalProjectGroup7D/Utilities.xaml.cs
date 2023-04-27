using FinalProjectGroup7D.Database;
using FinalProjectGroup7D.Tables;
using Microsoft.Maui.Controls;
using MySqlConnector;
using System.Collections.ObjectModel;
using System.Data;

//Created by Ben Mazerolle, Dave Prepsl, Jin Her, Markus Luthi
//On April 22th, 2023
//For OOP2 Final Project

namespace FinalProjectGroup7D;

public partial class Utilities : ContentPage


{
    //Creates a list That holds Utility Information
    public List<Utility> Util = new List<Utility>();

    public Utilities()
    {
        InitializeComponent();

        //Populates the Utility List
        ProjectDatabase dataBase = new ProjectDatabase();
        Util = dataBase.SelectUtility();

        //Passes that information to the UtilityInfo.ItemSource to be used in the XAML file
        UtilitiesList.ItemsSource = Util;
    }
}