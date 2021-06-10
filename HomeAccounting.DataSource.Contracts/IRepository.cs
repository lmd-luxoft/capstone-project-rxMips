namespace HomeAccounting.DataSource.Contracts
{
    public interface IRepository
    {
        void Add(DbAccount dbAccount);
        void GetById(int id);
    }
}