using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic
{
    public class DepositJob : Job
    {
        private readonly Contract contract;
        private readonly IOperationRepository operationRepository;

        public DepositJob(Contract contract, IOperationRepository operationRepository, DateTime finishDate) : base(finishDate)
        {
            this.contract = contract;
            this.operationRepository = operationRepository;
        }

        public override void DoJob()
        {
            var operation = new Operation(contract.Id, contract.Amount);
            operationRepository.Create(operation);
        }

        public override int GetRepetitionIntervalTime() => new TimeSpan(30, 0, 0, 0).Milliseconds;

        public override bool IsRepeatable() => true;
    }
}
