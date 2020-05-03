using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.Models
{
    public enum TaskType
    {
        Project,
        LabReport,
        Partial
    } 
    public class Task : Event
    {
        public DateTime Deadline { get; set; }
        public TaskType Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PlaceOnDisk { get; set; }
        public Subject Subject { get; set; }
        public ICollection<string> Links { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
