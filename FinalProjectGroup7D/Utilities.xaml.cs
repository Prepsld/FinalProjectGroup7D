//using CloudKit;
using FinalProjectGroup7D.Resources.Database;
using Microsoft.Maui.Controls;
using MySqlConnector;
using System.Collections.ObjectModel;
using System.Data;

namespace FinalProjectGroup7D;

public partial class Utilities : ContentPage
{
    public ObservableCollection<string> tableList = new ObservableCollection<string>();
	public Utilities()
	{
		InitializeComponent();

        //string connectionString = "Server=localhost;Uid=username;Pwd=password;Database=oopfinal;";

        string server = "localhost";
        string database = "oopfinal";
        string uid = "root";
        string password = "password";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        MySqlConnection connection = new MySqlConnection(connectionString);
		connection.Open();
        string query = "SHOW TABLES;";
        MySqlCommand command = new MySqlCommand(query, connection);
        MySqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            tableList.Add(reader.GetString(0));
        }
        tableListView.ItemsSource = tableList;
        connection.Close();
    }
}