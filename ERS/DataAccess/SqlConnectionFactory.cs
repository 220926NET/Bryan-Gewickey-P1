using Microsoft.Data.SqlClient;

namespace DataAccess;

public class SqlConnectionFactory
{

    private const string _connectionString = $"Server=tcp:bryangp1dbserver.database.windows.net,1433;Initial Catalog=ProjectP1DB;Persist Security Info=False;User ID=bgp1serveradmin;Password={zr8hXzJ5XiPq22n};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

    public SqlConnection GetConnection()
    {
        return new SqlConnection(_connectionString, zr8hXzJ5XiPq22n);
    }
}