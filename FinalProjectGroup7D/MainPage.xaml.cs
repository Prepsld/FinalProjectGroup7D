using Microsoft.Maui.Controls;
using MySqlConnector;

namespace FinalProjectGroup7D;

public partial class MainPage : ContentPage
{
	public MainPage()
    {
        InitializeComponent();

        string connectionString = "Server=localhost;Uid=root;Pwd=password;Database=oopfinal;";

        // connection is created and is properly garbage collected when the connection is closed
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            // hardcoded MariaDB compatible SQL query
            string query = "SELECT * FROM user LIMIT 1;";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                // retrieves data from the database by executing the query with the proper connection details
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // if there is data to be read with the results from command.ExecuteReader()
                    // parses and sets corresponding variables from the rows of data retrieved from command.ExecuteReader()
                    if (reader.Read())
                    {
                        string firstName = reader.GetString("first_name");
                        string lastName = reader.GetString("last_name");
                        string email = reader.GetString("e_mail");

                        firstNameLabel.Text = firstName;
                        lastNameLabel.Text = lastName;
                        emailLabel.Text = email;
                    }
                }
            }
            connection.Close();
        }
    }
}

