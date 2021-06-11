using System;
using System.Linq;
using HomeAccounting.BusinessLogic.Contracts;
using HomeAccounting.BusinessLogic.Contracts.Dto;
using HomeAccounting.DataSource.EF.Domain;
using Account = HomeAccounting.DataSource.EF.Domain.Account;

namespace HomeAccounting.DataSource.EF.Application
{
    public class AccountingService : IAccountingService
    {
        private readonly DomainContext _domainContext;

        public AccountingService(DomainContext domainContext)
        {
            _domainContext = domainContext ?? throw new ArgumentNullException(nameof(domainContext));
        }

        public void Create(AccountModel accountModel)
        {
            switch (accountModel.Type)
            {
                case AccountType.Simple:
                    CreateSimpleAccount(accountModel);
                    break;
                case AccountType.Deposit:
                    CreateDepositAccount(accountModel);
                    break;
                case AccountType.Property:
                    CreatePropertyAccount(accountModel);
                    break;
                case AccountType.Cash:
                    CreateCashAccount(accountModel);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("bad type account");
            }

            _domainContext.SaveChanges();
        }

        private void CreateDepositAccount(AccountModel accountModel)
        {
            var bic = (string) accountModel.Params[0];
            var bank = _domainContext.Banks.SingleOrDefault(x => x.BIC == bic);
            if (bank == null)
                throw new InvalidOperationException($"bank is not found {bic}");

            var account = new Deposit
            {
                Balance = accountModel.Amount,
                Title = "My Deposit",
                CreationDate = DateTime.Now,
                Bank = bank,
                Persent = (decimal) accountModel.Params[2],
                AccountNumber = (string) accountModel.Params[3]
            };

            _domainContext.Deposits.Add(account);
        }

        private void CreatePropertyAccount(AccountModel accountModel)
        {
            var account = new Property
            {
                Balance = accountModel.Amount,
                CreationDate = DateTime.Now,
                Location = "Samara",
                Title = accountModel.Title,
                PropertyType = (PropertyType) accountModel.Params[0],
            };

            _domainContext.Properties.Add(account);
        }

        private void CreateCashAccount(AccountModel accountModel)
        {
            _domainContext.Cashes.Add(new Cash());
        }

        private void CreateSimpleAccount(AccountModel accountModel)
        {
            _domainContext.Accounts.Add(new Account());
        }
    }
}