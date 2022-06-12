namespace Domain
{
    using Domain.Enums;

    internal class Borrower
    {
        public int Id { get; set; }
        public string Name { get; }

        public string Country { get; }

        public int YearPersantage { get; }

        public BorrowerTypes Type { get; set; }

        public Borrower(string name, string country, int yearPersantage)
        {
            Name = name;
            Country = country;
            YearPersantage = yearPersantage;
        }
    }
}