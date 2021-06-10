using System;
using HomeAccounting.BusinessLogic.Contracts;
using HomeAccounting.DataSource.Contracts;

namespace HomeAccounting.BusinessLogic
{
    public class AccountingService : IAccounting
    {
        private readonly IRepository _repository;

        public AccountingService(IRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        
        public void Create(Account account)
        {
            var dto = Map(account);
            _repository.Add(dto);
        }

        public Account GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Account account)
        {
            throw new System.NotImplementedException();
        }
        
        private static DbAccount Map(Account account)
        {
            var dto = new DbAccount
            {
                Id = account.Id,
                Title = account.Title,
                CreationTime = account.CreationTime
            };
            return dto;
        }
    }
}