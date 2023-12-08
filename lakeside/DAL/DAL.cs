using System;
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
using System.Collections;

namespace lakeside.DAL
{
    public class DAL
    {
        //The connection string
        public string _connectionString = ConfigurationManager.ConnectionStrings["lakeside.Properties.Settings.LakesideDBConnectionString"].ConnectionString;

        //Get value of connection string
        public string ConnectionString
        {
            get { return _connectionString; }
        }

        //Executes the SQL statement
        public bool ExecuteNonQuery(SqlCommand command)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    return command.ExecuteNonQuery() == 1;
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        //public int ExecuteAndGetID(SqlCommand command)
        //{
        //    using (SqlConnection connection = new SqlConnection(_connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            command.Connection = connection;
        //            SqlDataReader reader = command.ExecuteReader();
        //            int id = 0;
        //            if(reader.Read())
        //            {
        //                id = reader.GetInt32(0);
        //            }
        //            reader.Close();
        //            MessageBox.Show(id.ToString());
        //            return id;
        //        }
        //        catch (Exception ex)
        //        {
        //            return -1;
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }
        //    }
        //}

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

        public object ExecuteScalar(string query)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    return command.ExecuteScalar();
                }
            }
        }
    }
}
