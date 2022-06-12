namespace BuisnessLogic
{
    using Domain.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Job : IJob 
    {
        private readonly DateTime finishDate;

        public Job(DateTime finishDate)
        {
            this.finishDate = finishDate;
        }

        public void ExecuteJob()
        {
            if (IsRepeatable())
            {
                var interval = GetRepetitionIntervalTime();
                var timeToRun = DateTime.UtcNow.AddMilliseconds(interval);
                while (timeToRun < finishDate)
                {
                    Thread.Sleep(interval);
                    DoJob();
                    timeToRun = DateTime.UtcNow.AddMilliseconds(interval);
                }
            }
            else
            {
                DoJob();
            }
        }

        public abstract void DoJob();

        public abstract bool IsRepeatable();

        public abstract int GetRepetitionIntervalTime();
    }
}
