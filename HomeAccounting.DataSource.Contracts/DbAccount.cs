using System;

namespace HomeAccounting.DataSource.Contracts
{
    public class DbAccount
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string Title { get; set; }
    }
}