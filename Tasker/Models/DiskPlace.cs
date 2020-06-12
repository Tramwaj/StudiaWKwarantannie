using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.Models
{
    [Serializable]
    public class DiskPlace
    {
        public string Path { get; set; }
        public string Description { get; set; }
        public bool IsFile { get; set; }

        public DiskPlace(string path, string description, bool isFile)
        {
            Path = path;
            Description = description;
            IsFile = isFile;
        }
    }


}
