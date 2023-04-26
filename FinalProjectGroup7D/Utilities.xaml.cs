using FinalProjectGroup7D.Database;
using FinalProjectGroup7D.Tables;
using Microsoft.Maui.Controls;
using MySqlConnector;
using System.Collections.ObjectModel;
using System.Data;

//Create by Markus Luthi
//On April 25th, 2023
//For OOP2 Final Project

namespace FinalProjectGroup7D;

public partial class Utilities : ContentPage


{
    public List<Utility> Util = new List<Utility>();

    public Utilities()
    {
        InitializeComponent();

        ProjectDatabase dataBase = new ProjectDatabase();

        Util = dataBase.SelectUtility();

        UtilitiesList.ItemsSource = Util;
    }
}