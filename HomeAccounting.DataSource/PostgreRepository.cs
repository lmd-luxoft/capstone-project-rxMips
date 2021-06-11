using System.Linq;
using Dapper;
using HomeAccounting.DataSource.Contracts;
using Npgsql;

namespace HomeAccounting.DataSource
{
    public class PostgreRepository : IRepository
    {
        private const string ConnectionString = "Host=localhost; Username=postgres; Password=1; Database=Demo";

        public void Add(DbAccount dbAccount)
        {
            using var connection = new NpgsqlConnection(ConnectionString);
            var cmd = "insert into public.accounts(creation_time,title)values(@CreationTime, @Title)";
            connection.Execute(cmd, dbAccount);
        }

        public DbAccount GetById(int id)
        {
            using var connection = new NpgsqlConnection(ConnectionString);
            var query =
                "select id as \"Id\", creation_time as \"CreationTime\", title as \"Title\" from public.accounts where id = @id";
            return connection.Query<DbAccount>(query, id).Single();
        }
    }
}