using System.Collections.Generic;

namespace HomeAccounting.DataSource.EF.Domain
{
    public class Operation
    {
        public int ExecutionDate
        {
            get => default;
            set
            {
            }
        }

        public int Amount
        {
            get => default;
            set
            {
            }
        }

        public IEnumerable<Account> Account
        {
            get => default;
            set
            {
            }
        }
    }
}