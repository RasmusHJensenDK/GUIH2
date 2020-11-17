using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GUIH2
{
    class DatabaseWrapper
    {
        private readonly string _connectionString;
        public DatabaseWrapper(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void ExecuteQuery(string query)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}
