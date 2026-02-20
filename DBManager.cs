using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;

namespace Assignment_1
{
    public class DBManager
    {
        private readonly string connectionString;

        public DBManager(string _connectionstring)
        {
            connectionString = _connectionstring;
        }

        public DataTable ExecuteQuery(string storedProcedure, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public void ExecuteNonQuery(string storedProcedure, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public object ExecuteScalar(string storedProcedure, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters != null) cmd.Parameters.AddRange(parameters);

                conn.Open();
                return cmd.ExecuteScalar();
            }
        }

        public bool ExecuteBool(string storedProcedure, SqlParameter[] parameters = null)
        {
            object result = ExecuteScalar(storedProcedure, parameters);
            if (result == null) return false;
            return Convert.ToInt32(result) > 0;
        }

    }
}
