using Domain.Interfaces;


namespace BuisnessLogic
{

    public class JobService : IJobService
    {
        private List<IJob> _jobs;

        public JobService()
        {
            _jobs = new List<IJob>();
        }

        public Task ScheduleJob(IJob job)
        {
            job.ExecuteJob();
            _jobs.Add(job);
            return Task.CompletedTask;
        }
    }
}
