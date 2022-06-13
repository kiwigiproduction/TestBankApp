using Domain.Enums;

namespace Domain
{
    

    internal class Borrower
    {
        Dictionary<string, string> people = new Dictionary<string, string>();


        public int Id { get; set; }
        public string Name { get; }

        public string Country { get; }

        public int YearPersantage { get; }

        public BorrowerTypes Type { get; set; }

        public Borrower(string name, string country, int yearPercentAge)
        {
            Name = name;
            Country = country;
            YearPersantage = yearPercentAge;
        }

        public void GetAllBorrowers() 
        {
            var people = new Dictionary<string, string>();
            people.Add("Ім'я банку", "UNIVERSAL BANK");
            people.Add("Країна Банку", "Україна");
            people.Add("Річна Ставка","10%");
        }
    }
}