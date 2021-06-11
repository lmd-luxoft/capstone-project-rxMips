namespace HomeAccounting.DataSource.EF.Domain
{
    public class Cash : Account
    {
        public int Banknots { get; set; }

        public int Monets { get; set; }
    }
}