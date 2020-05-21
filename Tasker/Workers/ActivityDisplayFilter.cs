using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.Models;

namespace Tasker.Workers
{
    class ActivityDisplayFilter
    {
        public DateTime _startDate { get; set; }
        public DateTime _endDate { get; set; }
        public bool _disabled { get; set; }
        public ActivityDisplayFilter()
        {
            _disabled = true;
        }

        public IEnumerable<Activity> Apply(IEnumerable<Activity> collection)
        {
            return _disabled ? collection :
                collection.Where(x => x.Time >= _startDate && x.Time <= _endDate);
        }
        public void Set(DateTime start, DateTime end)
        {
            _startDate = start;
            _endDate = end;
            _disabled = false;
        }
        public void Disable()
        {
            _disabled = true;
        }
    }
}
