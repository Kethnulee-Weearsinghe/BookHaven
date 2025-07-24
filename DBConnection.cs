using System.Data.SqlClient;
public static class DBConnection
{
    public static SqlConnection GetConnection()
    {
        string connString = @"Data Source=KETHNULEE;Initial Catalog=BookHaven;Integrated Security=True";
        return new SqlConnection(connString);
    }
}


