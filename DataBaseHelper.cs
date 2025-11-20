using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project1
{
    internal class DataBaseHelper
    {
     
        
            // Connection string for Visual Studio database
            private static readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Lenovo\\source\\repos\\Project1\\Project1\\project1.mdf;Integrated Security=True;";

            // Method to get the connection
            public static SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }

            // Method to test the connection
            public static void TestConnection()
            {
                try
                {
                    using (SqlConnection connection = GetConnection())
                    {
                        connection.Open();
                        Console.WriteLine("Connection successful!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection failed: " + ex.Message);
                }
            }
        }
    }

    

