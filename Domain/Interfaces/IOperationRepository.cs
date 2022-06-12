using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IOperationRepository
    {
        Task<IEnumerable<Operation>> GetAll();

        Task Create(Operation operation);

        Task Remove(Operation operation);
    }
}
