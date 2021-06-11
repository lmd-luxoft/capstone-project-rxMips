using System.Collections.Generic;

namespace HomeAccounting.DataSource.EF.Domain
{
    public class Operation: Entity
    {
        public int ExecutionDate
        {
            get;
            set;
        }

        public int Amount
        {
            get;
            set;
        }

        public IEnumerable<Account> Accounts
        {
            get;
            set;
        }
    }
}