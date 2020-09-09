using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiroSimulator
{
    public class Attachment
    {
        public string Link { get; set; }
        public string Name { get; set; }
        private readonly DateTime _creationDate;
        public DateTime UpdatedDate { get; set; }

        public string Id { get; set; }
        public readonly string UserId;
        public readonly string TaskId;

        public Attachment(string link, string name, string userId, string taskId)
        {
            Link = link;
            Name = name;
            _creationDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            Id = Guid.NewGuid().ToString();
            UserId = userId;
            TaskId = taskId;
        }
    }
}
