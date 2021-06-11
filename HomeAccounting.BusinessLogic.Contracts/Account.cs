using System;

namespace HomeAccounting.BusinessLogic.Contracts
{
    public class Account
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string Title { get; set; }
    }
}