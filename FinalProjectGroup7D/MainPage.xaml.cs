using FinalProjectGroup7D.Database;
using FinalProjectGroup7D.Tables;
using Microsoft.Maui.Controls;
using MySqlConnector;

//Created by Ben Mazerolle, Dave Prepsl, Jin Her, Markus Luthi
//On April 22th, 2023
//For OOP2 Final Project
//Creates lists and Itemsources for the MainPage.XAML file

namespace FinalProjectGroup7D;

public partial class MainPage : ContentPage


{
    //Creates a list That holds User Information
    public List<User> Users = new List<User>();

    //Creates a list that holds Utility Information
    public List<OverviewList> overviewLists = new List<OverviewList>();

    public MainPage()
    {
        InitializeComponent();

        //USERS

        //Populates the User List
        ProjectDatabase userdataBase = new ProjectDatabase();
        Users = userdataBase.SelectUser();

        //Passes that information to the UserList.ItemSource to be used in the XAML file
        UserList.ItemsSource = Users;


        //UTILITY

        //Populates the overview lists
        ProjectDatabase overviewList = new ProjectDatabase();
        overviewLists = overviewList.GrabLists();

        //Passes that information to the UtilityInfo.ItemSource to be used in the XAML file
        UtilityInfo.ItemsSource= overviewLists;
    }
}
