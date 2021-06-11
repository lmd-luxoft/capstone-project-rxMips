namespace HomeAccounting.DataSource.EF.Domain
{
    public class Deposit : Account
    {
        public string AccountNumber { get; set; }

        public decimal Persent { get; set; }

        public PersentType PersentType { get; set; }

        public Bank Bank { get; set; }
    }
}