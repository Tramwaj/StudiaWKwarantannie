using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.Models
{
    public abstract class Event
    {
        public int Id { get; set; }
        public Subject Subject { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public override string ToString()
        {
            return ;
        }
    }
}
