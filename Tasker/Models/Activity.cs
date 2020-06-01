using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.Models
{
    [Serializable]
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public abstract class Activity
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        public int Id { get; set; }
        public Subject Subject { get; set; }
        public DateTime Time { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public ICollection<string> PlaceOnDisk { get; set; }
        public ICollection<string> Links { get; set; }
        public abstract Status Status { get; set; }

        protected Activity(Subject subject, DateTime time)
        {
            Subject = subject;
            Time = time;
            Notes = new List<Note>();
            //Links = new List<string>();
        }

        protected Activity(Subject subject, DateTime time, ICollection<string> placeOnDisk, ICollection<string> links) : this(subject, time)
        {
            PlaceOnDisk = placeOnDisk;
            Links = links;
        }

        public bool Equals(Activity other)
        {
            return Subject == other.Subject
                && Time == other.Time;                
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Activity);
        }


        public override string ToString()
        {
            //var sb = new StringBuilder();
            //sb.Append(Subject.ShortName)
            //    .Append(" ")
            //    .Append
            return Time.ToString() + " " + Subject.ShortName + " " + Notes.Count;
        }
    }
}
