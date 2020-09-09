using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiroSimulator
{
    public class Comment
    {
        public string Id { get; set; }
        public readonly string AuthorId;
        public readonly string TaskId; 
        public string CommentText { get; set; }
        private readonly DateTime _creationDate;
        public DateTime UpdatedDate { get; set; }

        public Comment(string authorId, string taskId, string commentText)
        {
            Id = Guid.NewGuid().ToString();
            AuthorId = authorId;
            TaskId = taskId;
            CommentText = commentText;
            _creationDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
        }
    }
}
