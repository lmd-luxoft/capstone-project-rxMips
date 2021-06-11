namespace HomeAccounting.DataSource.Contracts
{
    public interface IRepository
    {
        void Add(DbAccount dbAccount);
        DbAccount GetById(int id);
    }
}