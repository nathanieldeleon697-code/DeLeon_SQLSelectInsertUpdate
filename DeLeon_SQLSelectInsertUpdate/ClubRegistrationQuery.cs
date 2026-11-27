using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace DeLeon_SQLSelectInsertUpdate
{
    public sealed class ClubRegistrationQuery : IDisposable
    {
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;
        public DataTable dataTable;
        public BindingSource bindingSource;
        private string connectionString;
        public string _FirstName, _MiddleName, _LastName, _Gender, _Program;
        public int _Age;

        public ClubRegistrationQuery()
        {
            connectionString = DatabaseSetup.ConnectionString;
            sqlConnect = new SqlConnection(connectionString);
            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }
        public bool DisplayList()
        {
            string ViewClubMembers = "SELECT StudentId, FirstName, MiddleName, LastName, Age, Gender, Program FROM dbo.ClubMembers ORDER BY ID";
            using (sqlAdapter = new SqlDataAdapter(ViewClubMembers, sqlConnect))
            {
                dataTable.Clear();
                sqlAdapter.Fill(dataTable);
                bindingSource.DataSource = dataTable;
            }
            return true;
        }
        public int GetLastRegistrationID()
        {
            using (sqlCommand = new SqlCommand("SELECT ISNULL(MAX(ID), 0) FROM dbo.ClubMembers", sqlConnect))
            {
                try { sqlConnect.Open(); return Convert.ToInt32(sqlCommand.ExecuteScalar()); }
                finally { sqlConnect.Close(); }
            }
        }
        private void AddMemberParameters(long studentId, string first, string middle, string last, int age, string gender, string program)
        {
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = studentId;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = first;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar, 50).Value = middle;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = last;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar, 50).Value = gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar, 50).Value = program;
        }
        public bool RegisterStudent(int ID, long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            using (sqlCommand = new SqlCommand(@"INSERT INTO dbo.ClubMembers
                (ID, StudentId, FirstName, MiddleName, LastName, Age, Gender, Program)
                VALUES (@ID, @StudentID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)", sqlConnect))
            {
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                AddMemberParameters(StudentID, FirstName, MiddleName, LastName, Age, Gender, Program);
                try { sqlConnect.Open(); return sqlCommand.ExecuteNonQuery() == 1; }
                finally { sqlConnect.Close(); }
            }
        }
        public bool FindStudent(long studentId)
        {
            using (sqlCommand = new SqlCommand("SELECT FirstName, MiddleName, LastName, Age, Gender, Program FROM dbo.ClubMembers WHERE StudentId = @StudentID", sqlConnect))
            {
                sqlCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = studentId;
                try
                {
                    sqlConnect.Open();
                    using (sqlReader = sqlCommand.ExecuteReader())
                    {
                        if (!sqlReader.Read()) return false;
                        _FirstName = Convert.ToString(sqlReader["FirstName"]);
                        _MiddleName = Convert.ToString(sqlReader["MiddleName"]);
                        _LastName = Convert.ToString(sqlReader["LastName"]);
                        _Age = Convert.ToInt32(sqlReader["Age"]);
                        _Gender = Convert.ToString(sqlReader["Gender"]);
                        _Program = Convert.ToString(sqlReader["Program"]);
                        return true;
                    }
                }
                finally { sqlConnect.Close(); }
            }
        }
        public bool UpdateStudent(long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            using (sqlCommand = new SqlCommand(@"UPDATE dbo.ClubMembers SET FirstName=@FirstName,
                MiddleName=@MiddleName, LastName=@LastName, Age=@Age, Gender=@Gender, Program=@Program
                WHERE StudentId=@StudentID", sqlConnect))
            {
                AddMemberParameters(StudentID, FirstName, MiddleName, LastName, Age, Gender, Program);
                try { sqlConnect.Open(); return sqlCommand.ExecuteNonQuery() == 1; }
                finally { sqlConnect.Close(); }
            }
        }
        public void Dispose()
        {
            bindingSource.Dispose(); dataTable.Dispose(); sqlConnect.Dispose();
        }
    }
}
