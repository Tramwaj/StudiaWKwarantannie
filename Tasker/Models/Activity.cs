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
        public ICollection<DiskPlace> DiskPlaces { get; set; }
        public ICollection<Link> Links { get; set; }
        public abstract Status Status { get; set; }
       
        protected Activity(Subject subject, DateTime time, ICollection<DiskPlace> diskPlaces, ICollection<Link> links, ICollection<Note> notes)
        {
            Subject = subject;
            Time = time;
            DiskPlaces = diskPlaces;
            Links = links;
            Notes = notes;
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
    }
}
