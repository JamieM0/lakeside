using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace lakeside.DAL
{
    class StaffDAL : DAL
    {
        public bool AddNewStaff(Staff s)
        {
            //SqlCommand used to store details of the command
            SqlCommand command = new SqlCommand();

            //Set SQL query command text to valid insert statement using values from the Guest class.
            command.CommandText = string.Format($"INSERT INTO Staff VALUES('{s.Forename}','{s.Surname}','{s.Email}','{s.Number}','{s.Street}','{s.CityTown}','{s.Postcode}','{s.Country}','{s.Position}')");

            return ExecuteNonQuery(command);
        }

        public Staff[] SearchStaff(string search)
        {
            Staff[] allStaff = new Staff[100];
            Staff[] staffMembers;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT * FROM Staff WHERE forename LIKE '{search}%' OR surname LIKE '{search}%' OR email LIKE '%{search}%' OR position LIKE '%{search}%' OR staff_id LIKE '{search}'", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            allStaff[i] = new Staff(String.Format($"{reader[1]}"), String.Format($"{reader[2]}"), String.Format($"{reader[3]}"), String.Format($"{reader[4]}"), String.Format($"{reader[5]}"), String.Format($"{reader[6]}"), String.Format($"{reader[7]}"), String.Format($"{reader[8]}"), int.Parse(String.Format($"{reader[0]}")), String.Format($"{reader[9]}"));
                            i++;
                        }

                        //Check for duplicates in allStaff
                        allStaff = allStaff.Distinct().ToArray();

                        staffMembers = new Staff[i];
                        for (int l = 0; l < staffMembers.Length; l++)
                        {
                            staffMembers[l] = allStaff[l];
                        }
                    }
                }
            }

            return staffMembers;
        }
        
        public Staff[] GetTutors()
        {
            Staff[] allStaff = new Staff[100];
            Staff[] staffMembers;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT * FROM Staff WHERE Position = 'Tutor'", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            allStaff[i] = new Staff(String.Format($"{reader[1]}"), String.Format($"{reader[2]}"), String.Format($"{reader[3]}"), String.Format($"{reader[4]}"), String.Format($"{reader[5]}"), String.Format($"{reader[6]}"), String.Format($"{reader[7]}"), String.Format($"{reader[8]}"), int.Parse(String.Format($"{reader[0]}")), String.Format($"{reader[9]}"));
                            i++;
                        }

                        //Check for duplicates in allStaff
                        allStaff = allStaff.Distinct().ToArray();

                        staffMembers = new Staff[i];
                        for (int l = 0; l < staffMembers.Length; l++)
                        {
                            staffMembers[l] = allStaff[l];
                        }
                    }
                }
            }

            return staffMembers;
        }

        public Staff StaffLookup(int id)
        {
            Staff result = new Staff();

            //Get the guest corresponding to the guest_id
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT * FROM Staff WHERE staff_id = {id}", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = new Staff(String.Format($"{reader[1]}"), String.Format($"{reader[2]}"), String.Format($"{reader[3]}"), String.Format($"{reader[4]}"), String.Format($"{reader[5]}"), String.Format($"{reader[6]}"), String.Format($"{reader[7]}"), String.Format($"{reader[8]}"), int.Parse(String.Format($"{reader[0]}")), String.Format($"{reader[9]}"));
                        }
                    }
                }
            }

            return result;
        }

        public bool UpdateStaff(Staff g)
        {
            //SqlCommand used to store details of the command
            SqlCommand command = new SqlCommand();

            //Set SQL query command text to valid insert statement using values from the Guest class.
            command.CommandText = string.Format($"UPDATE Staff SET forename = '{g.Forename}', surname = '{g.Surname}', email = '{g.Email}', mobilePhone = '{g.Number}', streetname = '{g.Street}', townname = '{g.CityTown}', postcode = '{g.Postcode}', country = '{g.Country}', position = '{g.Position}' WHERE staff_id = {g.StaffID}");

            return ExecuteNonQuery(command);
        }
    }
}
