using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiroSimulator.Enums
{
    public enum TaskStatuses
    {
        Backlog = 1,
        ToDo = 2,
        InProgress = 3,
        ReadyForQA = 4,
        ReOpen = 5,
        Done = 6
    }
}
