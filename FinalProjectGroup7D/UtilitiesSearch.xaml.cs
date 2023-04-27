using MySqlConnector;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

//Created by Dave Prepsl, Jin Her, Markus Luthi
//On April 22th, 2023
//For OOP2 Final Project

namespace FinalProjectGroup7D;

public partial class UtilitiesSearch : ContentPage
{
    public UtilitiesSearch()
    {
        InitializeComponent();
    }


    public void QueryDatabase()
    {
        // Object utility = new Object();

        string connectionString = "Server=localhost;Uid=root;Pwd=password;Database=oopfinal;";

        // connection is created and is properly garbage collected when the connection is closed
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            // hardcoded MariaDB compatible SQL query

            string query = entryAdd.Text;
            // string query = "SELECT * FROM user;";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                // retrieves data from the database by executing the query with the proper connection details
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // if there is data to be read with the results from command.ExecuteReader()
                    // parses and sets corresponding variables from the rows of data retrieved from command.ExecuteReader()
                    while (reader.Read())
                    {

                        int utilityNumber = reader.GetInt32("utility_#");
                        string utilityname = reader.GetString("name");
                        double utilityrate = reader.GetDouble("rate");

                        utilityNumberLabel.Text += utilityNumber.ToString() + Environment.NewLine;
                        typeLabel.Text += utilityname + Environment.NewLine;
                        rateLabel.Text += utilityrate.ToString() + Environment.NewLine;
                    }
                }
            }
            connection.Close();
        }
    }



    public void SearchUtilities(object sender, EventArgs e)
    {
        if (entryAdd != null)
        {
            QueryDatabase();
        }
    }

}