using System.Collections.Generic;

namespace HomeAccounting.DataSource.EF.Domain
{
    public class Property : Account
    {
        public decimal BasePrice
        {
            get => default;
            set
            {
            }
        }

        public string Location
        {
            get => default;
            set
            {
            }
        }

        public IEnumerable<PropertyPriceChange> PropertyChange
        {
            get => default;
            set
            {
            }
        }

        public PropertyType PropertyType
        {
            get => default;
            set
            {
            }
        }
    }
}