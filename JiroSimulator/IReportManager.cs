using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiroSimulator
{
    public interface IReportManager
    {
        List<BaseTask> GetDoneTasks();
        List<BaseTask> GetCRTasks();
    }
}
