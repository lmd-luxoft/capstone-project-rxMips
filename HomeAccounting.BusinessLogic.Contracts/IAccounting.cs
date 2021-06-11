namespace HomeAccounting.BusinessLogic.Contracts
{
    public interface IAccounting
    {
        void Create(Account account);
        Account GetById(int id);
        void Save(Account account);
    }
}