using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.Models
{
    public class Note
    {
        public string Name { get; set; }
        public DateTime TimeCreated { get; set; }
        public string Content { get; set; }        
    }
}
