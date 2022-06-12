using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBankApp
{

    internal class Customer
    {
        public int Id { get; }
        public string Name { get; }
        public decimal Amount { get; }

        public Customer(int id, string name, decimal amount)
        {
            Id = id;
            Name = name;
            Amount = amount;
        }
    }
}
