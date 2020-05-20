using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.Models
{
    [Serializable]
    public class Activities
    {
        public List<Activity> All { get; set; }
        public Activities()
        {
            All = new List<Activity>();
        }
        public Activities(ICollection<Activity> eventsCollection)
        {
            All = eventsCollection.ToList();
        }
        public void AddRange(ICollection<Activity> eventsCollection)
        {
            All.AddRange(eventsCollection);
        }
        public void Add(Activity activity)
        {
            if (All.Contains(activity))
            {
                return;
            }
            All.Add(activity);
        }
        public IEnumerable<Job> Jobs
        {
            get => All.OfType<Job>();
        }
        public IEnumerable<Lesson> Lessons
        {
            get => All.OfType<Lesson>();
        }
    }
}
