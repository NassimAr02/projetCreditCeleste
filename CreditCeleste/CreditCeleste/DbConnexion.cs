using System;
using System.Configuration;
using System.Data.SqlClient;


namespace CreditCeleste
{
    public static class DbConnexion
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            return new SqlConnection(connectionString);
        }
    }
    
}
