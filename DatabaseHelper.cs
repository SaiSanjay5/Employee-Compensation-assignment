
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace EmployeeCompensationApp
{
    public class DatabaseHelper
    {
        private readonly string connectionString = "Server=YOUR_SERVER;Database=YOUR_DB;Trusted_Connection=True;TrustServerCertificate=True;";

        public DataTable FilterEmployees(string role, string location, bool includeInactive)
        {
            DataTable dt = new DataTable();
            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand("FilterEmployees", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Role", string.IsNullOrEmpty(role) ? DBNull.Value : role);
            cmd.Parameters.AddWithValue("@Location", string.IsNullOrEmpty(location) ? DBNull.Value : location);
            cmd.Parameters.AddWithValue("@IncludeInactive", includeInactive ? 1 : 0);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public DataTable GetAvgCompensationByLocation()
        {
            DataTable dt = new DataTable();
            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand("AvgCompByLocation", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
