using System.Collections.Generic;

namespace HomeAccounting.DataSource.EF.Domain
{
    public class Property : Account
    {
        public decimal BasePrice { get; set; }

        public string Location { get; set; }

        public IEnumerable<PropertyPriceChange> PropertyPriceChanges { get; set; }

        public PropertyType PropertyType { get; set; }
    }
}