using FinalProjectGroup7D.Database;
using FinalProjectGroup7D.Tables;
using Microsoft.Maui.Controls;
using MySqlConnector;

//Create by Markus Luthi
//On April 25th, 2023
//For OOP2 Final Project

namespace FinalProjectGroup7D;

public partial class MainPage : ContentPage


{
    public List<User> Users = new List<User>();
    public List<Utility> Utilities = new List<Utility>();

    public MainPage()
    {
        InitializeComponent();
        
        ProjectDatabase userdataBase = new ProjectDatabase();

        Users = userdataBase.SelectUser();

        UserList.ItemsSource = Users;


        ProjectDatabase utilitiesDataBase = new ProjectDatabase();

        Utilities = utilitiesDataBase.SelectUtility();

        UtilityInfo.ItemsSource= Utilities;
    }
}
