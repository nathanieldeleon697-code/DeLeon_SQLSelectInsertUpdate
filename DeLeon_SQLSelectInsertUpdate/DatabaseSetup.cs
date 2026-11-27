using System;
using System.Data.SqlClient;
namespace DeLeon_SQLSelectInsertUpdate
{
    internal static class DatabaseSetup
    {
        internal static string ConnectionString
        {
            get
            {
                var builder = new SqlConnectionStringBuilder();
                builder.DataSource = @".\SQLEXPRESS";
                builder.IntegratedSecurity = true;
                builder.InitialCatalog = "ClubDatabase";
                builder.ConnectTimeout = 30;
                return builder.ConnectionString;
            }
        }
        internal static void Initialize()
        {
            var builder = new SqlConnectionStringBuilder(ConnectionString);
            builder.InitialCatalog = "master";
            using (var connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT DB_ID(N'ClubDatabase')", connection))
                {
                    if (command.ExecuteScalar() == DBNull.Value)
                    {
                        // SQL Server uses its configured data directory and service permissions.
                        command.CommandText = "CREATE DATABASE [ClubDatabase]";
                        command.ExecuteNonQuery();
                    }
                }
            }
            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(@"IF OBJECT_ID(N'dbo.ClubMembers', N'U') IS NULL
                CREATE TABLE dbo.ClubMembers (
                    ID INT NOT NULL PRIMARY KEY,
                    StudentId BIGINT NOT NULL UNIQUE,
                    FirstName VARCHAR(50) NOT NULL,
                    MiddleName VARCHAR(50) NOT NULL,
                    LastName VARCHAR(50) NOT NULL,
                    Age INT NOT NULL CHECK (Age BETWEEN 1 AND 120),
                    Gender VARCHAR(50) NOT NULL,
                    Program VARCHAR(50) NOT NULL);", connection))
            { connection.Open(); command.ExecuteNonQuery(); }
        }
    }
}
