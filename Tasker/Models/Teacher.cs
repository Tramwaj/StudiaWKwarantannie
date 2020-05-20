using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.Models
{
    [Serializable]
    public class Teacher
    {
        //public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Link { get; set; }
        //public string CommunicationMedium { get; set; }

        public Teacher(string firstName, string lastName, string email, string link)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Link = link;
            //CommunicationMedium = communicationMedium;
        }
    }
}
