using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.Data;
using Tasker.Models;

namespace Tasker.Workers
{
    public class ActivityDisplayFilter
    {
        private DateTime _startDate;
        private DateTime _endDate;
        private bool _datesEnabled;
        private IEnumerable<string> _subjectsShown;// = new IEnumerable<string>();

        public ActivityDisplayFilter(IEnumerable<string> subjects)
        {
            _subjectsShown = subjects;
            _datesEnabled = false;
        }

        public IEnumerable<Activity> Apply(IEnumerable<Activity> collection)
        {
           
            return (_datesEnabled ? 
                collection.Where(x => x.Time >= _startDate && x.Time <= _endDate)
                : collection)
                .Where(x=>_subjectsShown.Any(s=>x.Subject.Name==s));
                
        }
        public void SetDatesShown(DateTime start, DateTime end)
        {
            _startDate = start;
            _endDate = end;
            _datesEnabled = true;
        }
        public void DisableDates()
        {
            _datesEnabled = false;
        }
        public void SetSubjectsShown(IEnumerable<string> subjects)
        {
            _subjectsShown = subjects;
        }
    }
}
