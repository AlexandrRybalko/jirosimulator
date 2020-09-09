using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiroSimulator
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public string Image { get; set; }

        public User(string firstName, string lastName, string image)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = Guid.NewGuid().ToString();
            Image = image;
        }

    }
}
