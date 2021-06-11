namespace HomeAccounting.BusinessLogic.Contracts.Dto
{
    public class AccountModel
    {
        public string Title { get; set; }
        public decimal Amount { get; set; }
        public object[] Params { get; set; }
        public AccountType Type { get; set; }
    }

    public enum AccountType
    {
        Simple, Deposit, Property, Cash
    }
}