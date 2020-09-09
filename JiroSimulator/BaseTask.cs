using JiroSimulator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiroSimulator
{
    public abstract class BaseTask
    {
        public double Estimation { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
        private readonly DateTime _creationDate;
        public DateTime UpdatedDate { get; set; }
        public TaskStatuses Status { get; set; }
        public User TaskOwner { get; set; }
        public readonly User taskCreator;

        public BaseTask(double estimation, TaskTypes type, string title, string description, User taskOwner, User taskCreator, TaskStatuses status = TaskStatuses.Backlog)
        {
            Estimation = estimation;
            Title = title;
            Description = description;
            Id = Guid.NewGuid().ToString();
            this.taskCreator = taskCreator;
            _creationDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            Status = status;
            TaskOwner = taskOwner;
        }
        public BaseTask()
        {
            _creationDate = DateTime.Now;
        }

        public abstract void GetInfo();
    }
}
