namespace BuisnessLogic
{
    using Domain;
    using Domain.Interfaces;
    using System.Threading.Tasks;

    public class DepositeService : IDepositService
    {
        private readonly IContractRepository contractRepository;
        private readonly IOperationRepository operationRepository;
        private readonly IJobService jobService;

        public DepositeService(IContractRepository contractRepository,IOperationRepository operationRepository, IJobService jobService)
        {
            this.contractRepository = contractRepository;
            this.operationRepository = operationRepository;
            this.jobService = jobService;
        }

        public async Task CreateDepositAmount(int customerId, int bankId, DepositAmount deposit, int duration)
        {
            var validFrom = DateTime.UtcNow;
            var validTo = validFrom.AddMonths(duration);
            var contract = new Contract(customerId, bankId, deposit, validFrom, validTo);
            
            contract = await contractRepository.Create(contract);

            var job = new DepositJob(contract,operationRepository, validTo);

            await jobService.ScheduleJob(job);
        }

        public Task<DepositAmount> GetDepositAmount(decimal amount, decimal percantage, int duration)
        {
            decimal borrowAmount = amount / duration;
            decimal monthPersantageAmount = ((amount / duration) * percantage);
            return Task.FromResult(new DepositAmount(borrowAmount,monthPersantageAmount));
        }
    }
}