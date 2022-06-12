using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IDepositService
    {
        Task CreateDepositAmount(int customerId, int bankId, DepositAmount deposit, int duration);
        
        Task<DepositAmount> GetDepositAmount(decimal amount, decimal percantage, int duration);
    }
}
