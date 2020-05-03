using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.Models
{
    public class Subject
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public int ECTS { get; set; }
        public int Priority { get; set; }
        public virtual ICollection<Event> Events { get; set; }

        public Subject(string name, Teacher teacher, int eCTS, int priority)
        {
            Name = name;
            Teacher = teacher;
            ECTS = eCTS;
            Priority = priority;
        }
    }
}
