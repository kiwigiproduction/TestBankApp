using BuisnessLogic;
using NUnit.Framework;
using Moq;
using Domain.Interfaces;
using Domain;

namespace TestProject1
{
    public class Tests
    {
        [TestCase]
        public void Setup()
        {
        }

        [TestCase]
        public async Task GetDeposit()
        {
            var fakeContactRepos = new Mock<IContractRepository>();
            var fakeOperationRepos = new Mock<IOperationRepository>();
            var fakeJobService = new Mock<IJobService>();

            decimal percentage = 0.15m;
            decimal amount = 100000m;
            int duration = 10;

            var depositService = new DepositeService(fakeContactRepos.Object, fakeOperationRepos.Object, fakeJobService.Object);
            var depositAmount = await depositService.GetDepositAmount(amount,percentage,duration);

            Assert.IsNotNull(depositAmount);
            Assert.AreEqual(10000, depositAmount.BorrowAmount);
            Assert.AreEqual(1500, depositAmount.MonthPersantageAmount);
            Assert.AreEqual(11500,depositAmount.TotalAmount);
        }

        [TestCase]
        public async Task CreateDepositAmount()
        {
            var fakeContactRepos = new Mock<IContractRepository>();
            var fakeOperationRepos = new Mock<IOperationRepository>();
            var fakeJobService = new Mock<IJobService>();

            decimal percentage = 0.15m;
            decimal amount = 100000m;
            int duration = 10;
            int customerId = 0;
            int bankId = 1;
            var depositService = new DepositeService(fakeContactRepos.Object, fakeOperationRepos.Object, fakeJobService.Object);

            var depositAmount = await depositService.GetDepositAmount(amount, percentage, duration);
            await depositService.CreateDepositAmount(customerId,bankId,depositAmount,duration);

            fakeContactRepos.Verify(x => x.Create(It.Is<Contract>(y => y.BorrowerId == bankId && y.CustomerId == customerId && y.Amount == depositAmount)), Times.Once);
            fakeJobService.Verify(x => x.ScheduleJob(It.IsAny<IJob>()), Times.Once);
        }
    }
}