using System.Data;
using System.Data.SqlClient;

namespace Data.DAL;

public class AppDbContext
{
    readonly string _connectionString = "Server=DESKTOP-L6JGBQE\\SQLEXPRESS;" +
                                       "Database=AdoNetBlogDb;" +
                                       "Trusted_Connection=true;" +
                                       "Integrated Security=true;" +
                                       "TrustServerCertificate=true;";
    SqlConnection _sqlConnection;

    public AppDbContext()
       => _sqlConnection = new SqlConnection(_connectionString);


    public int NonQuery(string command)
    {
        _sqlConnection.Open();
        SqlCommand sqlCommand = new SqlCommand(command, _sqlConnection);
        var result = sqlCommand.ExecuteNonQuery();
        _sqlConnection.Close();

        return result;
    }

    public DataTable Query(string query)
    {
        _sqlConnection.Open();
        DataTable dataTable = new DataTable();
        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, _sqlConnection);
        dataAdapter.Fill(dataTable);
        _sqlConnection.Close();

        return dataTable;
    }
}
