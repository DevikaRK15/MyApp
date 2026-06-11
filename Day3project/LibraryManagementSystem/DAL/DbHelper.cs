using Microsoft.Data.SqlClient;
namespace LibraryManagementSystem.DAL
{
    public class DbHelper
    {
        private string connectionString =
            @"Server=.\SQLEXPRESS;
              Database=LibraryManagementSystem;
              Trusted_Connection=True;
              TrustServerCertificate=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}