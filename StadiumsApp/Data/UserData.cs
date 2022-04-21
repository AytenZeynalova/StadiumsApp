using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using StadiumsApp.Models;

namespace StadiumsApp.Data
{
    class UserData
    {
        public void Add(User user)
        {
            using (SqlConnection con = new SqlConnection(Sql.ConnectionString))
            {
                con.Open();
                string query = $"INSERT INTO Users (FullName,Email) Values ('{user.FullName}','{user.Emaile}')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
        }
        public List<User> GetAll()
        {
            List<User> users = new List<User>();
            using (SqlConnection con = new SqlConnection(Sql.ConnectionString))
            {
                con.Open();
                string query = "SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        User user = new User
                        {
                            Id = dr.GetInt32(0),
                            FullName = dr.GetString(1),
                            Emaile = dr.GetString(2),

                        };

                        users.Add(user);
                    }
                }
            }


            return users;
        }
    }
}
