namespace Domain.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IContractRepository
    {
        Task<IEnumerable<Contract>> GetAll(int customerId);

        Task<Contract> Create(Contract contract);

        Task Remove(Contract contract);
    }
}
