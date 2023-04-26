using FinalProjectGroup7D.Database;
using FinalProjectGroup7D.Tables;
using Microsoft.Maui.Controls;
using MySqlConnector;

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
