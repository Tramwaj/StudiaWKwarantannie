using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.Models
{
    public enum LessonType
    {
        Lecture,
        Lab
    }
    public class Lesson : Event
    {
        public DateTime Start { get; set; }
        public TimeSpan Duration { get; set; }
        public LessonType Type { get; set; }
    }
}
