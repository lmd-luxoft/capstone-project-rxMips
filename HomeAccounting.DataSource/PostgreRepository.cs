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
            var cmd = $"insert into public.accounts(creation_time,title)values(@CreationTime, @Title)";
            connection.Execute(cmd, dbAccount);
        }

        public void GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}