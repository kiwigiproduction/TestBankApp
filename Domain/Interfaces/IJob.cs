namespace Domain.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IJob
    {
      void ExecuteJob();

      abstract void DoJob();

      abstract bool IsRepeatable();

      abstract int GetRepetitionIntervalTime();
    }
}
