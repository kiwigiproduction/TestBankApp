using System;

namespace Domain
{
    

    public class Contract
    {
        public int Id { get; }

        public int CustomerId { get; }
        public int BorrowerId { get; } 

        public DepositAmount Amount { get; }

        public DateTime ValidFrom { get; }

        public DateTime ValidTo { get; }

        public Contract(int customerId, int borrowerId, DepositAmount amount, DateTime validFrom, DateTime validTo)
        {
            CustomerId = customerId;
            BorrowerId = borrowerId;
            Amount = amount;
            ValidFrom = validFrom;
            ValidTo = validTo;
        }
    }
}