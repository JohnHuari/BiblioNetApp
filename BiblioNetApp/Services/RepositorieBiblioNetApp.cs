using BiblioNetApp.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BiblioNetApp.Services
{
    public interface IRepositorieBiblioNetApp
    {
        void Create(Book biblioNetApp);
    }
    public class RepositorieBiblioNetApp : IRepositorieBiblioNetApp
    {
        private readonly string connectionString;

        public RepositorieBiblioNetApp(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Create(Book biblioNetApp)
        {
            using var connection = new SqlConnection(connectionString);
            var id = connection.QuerySingle<int>($@"Insert into Book (BookName, Author, Price) values (@BookName , @Author, @Price ) ;
                                                    Select SCOPE_IDENTITY();", biblioNetApp);
            biblioNetApp.Id = id;
        }
    }
}
