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

    public MainPage()
    {
        InitializeComponent();

        ProjectDatabase dataBase = new ProjectDatabase();

        Users = dataBase.SelectUser();

        UserList.ItemsSource = Users;
    }
}
