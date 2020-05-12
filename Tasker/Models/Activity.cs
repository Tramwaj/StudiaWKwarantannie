using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.Models
{
    public abstract class Activity
    {
        public int Id { get; set; }
        public Subject Subject { get; set; }
        public DateTime Time { get; set; }
        public virtual ICollection<Note> Notes { get; set; }

        protected Activity(Subject subject, DateTime time)
        {
            Subject = subject;
            Time = time;
            Notes = new List<Note>();            
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
