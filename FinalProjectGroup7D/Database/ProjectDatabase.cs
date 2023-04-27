using FinalProjectGroup7D.Tables;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Created by Dave Prepsl, Jin Her, Markus Luthi
//On April 22th, 2023
//For OOP2 Final Project
//Creates a connection to the database, and calls the 4 select statements that we need to pull information from our tables.
//

namespace FinalProjectGroup7D.Database
{
    internal class ProjectDatabase
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public ProjectDatabase()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "oopfinal";
            uid = "root";
            password = "password";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //Uncomment if you want to use the Insert() Method
        //public void Insert()
        //{
        //    string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";

        //    //open connection
        //    if (OpenConnection() == true)
        //    {
        //        //create command and assign the query and connection from the constructor
        //        MySqlCommand cmd = new MySqlCommand(query, connection);

        //        //Execute command
        //        cmd.ExecuteNonQuery();

        //        //close connection
        //        CloseConnection();
        //    }
        //}

        //Uncomment if you want to use the Update() Method
        //public void Update()
        //{
        //    string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

        //    //Open connection
        //    if (OpenConnection() == true)
        //    {
        //        //create mysql command
        //        MySqlCommand cmd = new MySqlCommand();
        //        //Assign the query using CommandText
        //        cmd.CommandText = query;
        //        //Assign the connection using Connection
        //        cmd.Connection = connection;

        //        //Execute query
        //        cmd.ExecuteNonQuery();

        //        //close connection
        //        CloseConnection();
        //    }
        //}

        //Uncomment if you want to use the Delete() Method
        //public void Delete()
        //{
        //    string query = "DELETE FROM tableinfo WHERE name='Joe'";

        //    if (OpenConnection() == true)
        //    {
        //        MySqlCommand cmd = new MySqlCommand(query, connection);
        //        cmd.ExecuteNonQuery();
        //        CloseConnection();
        //    }
        //}

        ////Select History statement
        public List<Tables.History> SelectHistory()
        {
            //SQL command
            string query = "SELECT * FROM HISTORY";

            //Create a list to store the result
            List<Tables.History> historyList = new List<Tables.History>();


            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data by index and store them in the list
                while (dataReader.Read())
                {
                Tables.History x= new Tables.History(
                    dataReader.GetInt32(0),     //UilityNum
                    dataReader.GetInt32(1),     //Address
                    dataReader.GetFloat(2),     //Usage
                    dataReader.GetDateTime(3),  //StartDate
                    dataReader.GetDateTime(4)); //EndDate

                    historyList.Add(x);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed
                return historyList;
            }
            else
            {
                return historyList;
            }
        }

        public List<Tables.Location> SelectLocation()
        {
            //SQL command
            string query = "SELECT * FROM LOCATION";

            //Create a list to store the result
            List<Tables.Location> locationList = new List<Tables.Location>();


            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data by index and store them in the list
                while (dataReader.Read())
                {
                    Tables.Location x = new Tables.Location(
                        dataReader.GetInt32(0),     //AddressNum
                        dataReader.GetInt32(1),     //Accountnum
                        dataReader.GetString(2));   //PropertyLocation

                    locationList.Add(x);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed
                return locationList;
            }
            else
            {
                return locationList;
            }
        }

        public List<Tables.User> SelectUser()
        {
            //SQL command
            string query = "SELECT * FROM USER";

            //Create a list to store the result
            List<Tables.User> userList = new List<Tables.User>();


            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data by index and store them in the list
                while (dataReader.Read())
                {
                    Tables.User x = new Tables.User(
                        dataReader.GetInt32(0),     //AccountNum
                        dataReader.GetString(1),    //FirstName
                        dataReader.GetString(2),    //LastName
                        dataReader.GetString(3),    //MailingAddress
                        dataReader.GetString(4),    //PhoneNumber
                        dataReader.GetString(5),    //Email
                        dataReader.GetString(6));   //CreditCard

                    userList.Add(x);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed
                return userList;
            }
            else
            {
                return userList;
            }
        }

        public List<Tables.Utility> SelectUtility()
        {
            //SQL command
            string query = "SELECT * FROM UTILITY";

            //Create a list to store the result
            List<Tables.Utility> utilityList = new List<Tables.Utility>();


            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data by index and store them in the list
                while (dataReader.Read())
                {
                    Tables.Utility x = new Tables.Utility(
                        dataReader.GetInt32(0),     //UtilityNum
                        dataReader.GetString(1),    //Type
                        dataReader.GetFloat(2));    //Rate

                    utilityList.Add(x);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed
                return utilityList;
            }
            else
            {
                return utilityList;
            }
        }


        public List<Tables.OverviewList> GrabLists()
        {
            //SQL command
            string query = "SELECT location, CONCAT('$', FORMAT(SUM(history.usage * utility.rate), 2)) AS total_sum FROM location JOIN history ON location.`address_#` = history.`address_#` JOIN utility ON history.`utility_#` = utility.`utility_#` GROUP BY location;";

            //Create a list to store the result
            List<Tables.OverviewList> overviewList = new List<Tables.OverviewList>();


            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data by index and store them in the list
                while (dataReader.Read())
                {
                    Tables.OverviewList x = new Tables.OverviewList(
                        dataReader.GetString(0),     // Address
                        dataReader.GetString(1));    // Total Cost converted to dollar amount
                    overviewList.Add(x);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed
                return overviewList;
            }
            else
            {
                return overviewList;
            }
        }


    }
}
