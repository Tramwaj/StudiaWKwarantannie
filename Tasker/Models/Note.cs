using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.Models
{
    [Serializable]
    public class Note
    {
        public string Name { get; set; }
        public DateTime TimeCreated { get; }
        public DateTime TimeModified { get; set; }
        public string Content { get; set; }  
        public ICollection<string> PlaceOnDisk { get; set; }
        public ICollection<string> Links { get; set; }

        public Note(string name, string content)
        {
            Name = name;
            TimeCreated = DateTime.Now;
            TimeModified = DateTime.Now;
            Content = content;
        }

        public Note(string name, string content, ICollection<string> placeOnDisk, ICollection<string> links) : this(name, content)
        {
            PlaceOnDisk = placeOnDisk;
            Links = links;
        }
    }
}
