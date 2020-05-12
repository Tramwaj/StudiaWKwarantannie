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
        public string ShortName { get; set; }
        public int ECTS { get; set; }
        public int Priority { get; set; }
        //public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Note> Notes { get; set; }

        public Subject(string name, string shortName, Teacher teacher, int eCTS, int priority)
        {
            Name = name;
            ShortName = shortName;
            Teacher = teacher;
            ECTS = eCTS;
            Priority = priority;
        }
        //public AddTask()
    }
}
