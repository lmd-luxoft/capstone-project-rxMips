using HomeAccounting.BusinessLogic.Contracts.Dto;

namespace HomeAccounting.BusinessLogic.Contracts
{
    public interface IAccountingService
    {
        void Create(AccountModel accountModel);
    }
}