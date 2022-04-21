using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using StadiumsApp.Models;

namespace StadiumsApp.Data
{
    class ReservationData
    {
        public void Add(Reservation rezelvation)
        {
            using (SqlConnection con = new SqlConnection(Sql.ConnectionString))
            {
                con.Open();
                string query = $"INSERT INTO Reservations (StadionId,UserId,StartDate,EndDate) Values ({rezelvation.StadionId},{rezelvation.UserId},{rezelvation.StartDate},{rezelvation.EndDate})";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
