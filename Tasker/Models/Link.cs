using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.Models
{
    [Serializable]
    public class Link
    {
        public string Path { get; set; }
        public string Description { get; set; }

        public Link(string path, string description)
        {
            Path = path;
            Description = description;
        }
    }
}
