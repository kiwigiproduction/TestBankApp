using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain
{

    public class Operation
    {
        public int ContractId { get; }

        public DepositAmount Amount { get; }

        public Operation(int contractId, DepositAmount amount)
        {
            ContractId = contractId;
            Amount = amount;
        }
    }
}
