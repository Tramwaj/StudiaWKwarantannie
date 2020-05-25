using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.Models
{
    public enum TaskType
    {
        Project = 0,
        LabReport = 1,
        Partial = 2
    } 
    public enum Status
    {
        Untouched = 0,
        InProgress = 1,
        Done = 2
    }
    [Serializable]
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class Job : Activity
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        public TaskType Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }        
        public Status Status { get; set; }         

        public Job(Subject subject, DateTime time, TaskType type, string name, string description, string placeOnDisk, ICollection<string> links): base(subject, time)
        {
            Type = type;
            Name = name;
            Description = description;
            PlaceOnDisk = new List<string> { placeOnDisk };
            Links = links;
        }

        public bool Equals(Job other)
        {
            return Name == other.Name
                && Type == other.Type;
        }

        public override bool Equals(object obj)
        {
            if (obj is Job)
            {
                return base.Equals(obj)
                    && Equals(obj as Job);
            }
            return false;
        }
        public override string ToString()
        {
            var sb = new StringBuilder(base.ToString());
            return sb
                .Append(" - ")
                .Append(Name)
                .Append(" - ")
                .Append(Type)
                .ToString();
        }
    }
}
