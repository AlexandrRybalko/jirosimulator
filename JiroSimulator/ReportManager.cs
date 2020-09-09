using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiroSimulator
{
    public class TaskManager : IReportManager
    {
        private Board _board;
        public TaskManager(Board board)
        {
            _board = board;
        }
        public List<BaseTask> GetCRTasks()
        {
            List<BaseTask> result = new List<BaseTask>();
            foreach (var task in _board.GetTasks())
            {
                if (task.Status == Enums.TaskStatuses.Done)
                {
                    result.Add(task);
                }
            }
            return result;
        }

        public List<BaseTask> GetDoneTasks()
        {
            List<BaseTask> result = new List<BaseTask>();
            foreach (var task in _board.GetTasks())
            {
                if (task.Status == Enums.TaskStatuses.Done)
                {
                    result.Add(task);
                }
            }
            return result;
        }
    }
}
