using System;

namespace HomeAccounting.DataSource.EF.Domain
{
    public class PropertyPriceChange: Entity
    {
        public DateTime RegistrationDate
        {
            get;
            set;
        }

        public decimal Delta
        {
            get;
            set;
        }
    }
}