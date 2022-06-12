using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DepositAmount
    {
        public decimal BorrowAmount { get;}
        public decimal MonthPersantageAmount { get;}
        public decimal TotalAmount => BorrowAmount + MonthPersantageAmount;

        public DepositAmount(decimal borrowAmount, decimal monthPersantageAmount)
        {
            BorrowAmount = borrowAmount;
            MonthPersantageAmount = monthPersantageAmount;
        }
    }
}
