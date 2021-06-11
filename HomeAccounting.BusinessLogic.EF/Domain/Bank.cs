namespace HomeAccounting.DataSource.EF.Domain
{
    public class Bank
    {
        public int Id { get; set; }
        
        public string BIC
        {
            get;
            set;
        }

        public int Title
        {
            get;
            set;
        }
    }
}