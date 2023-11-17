﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace lakeside
{
    public class DAL
    {
        //The connection string
        private string _connectionString = ConfigurationManager.ConnectionStrings["lakeside.Properties.Settings.LakesideDBConnectionString"].ConnectionString;
        
        //Get value of connection string
        public string ConnectionString
        {
            get { return _connectionString; }
        }
        
        //Executes the SQL statement
        public bool ExecuteNonQuery(SqlCommand command)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    return command.ExecuteNonQuery()==1;
                }
                catch(Exception ex)
                {
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        //Fills in table with data from in the database
        public DataTable RunSelectQueryOnTable(SqlCommand command)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    SqlDataAdapter resultsReader = new SqlDataAdapter(command);
                    DataTable results = new DataTable();
                    resultsReader.Fill(results);
                    return results;
                }
                catch (Exception ex)
                {
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        //public bool AddNewGuest(Guest g)
        //{
        //    //SqlCommand used to store details of the command
        //    SqlCommand command = new SqlCommand();

        //    //Set SQL query command text to valid insert statement using values from the Guest class.
        //    command.CommandText = string.Format($"INSERT INTO Guest VALUES('{g.Forename}','{g.Surname}','{g.Email}','{g.Number}','{g.Street}','{g.CityTown}','{g.Postcode}','{g.Country}')");

        //    return ExecuteNonQuery(command);
        //}
    }
}