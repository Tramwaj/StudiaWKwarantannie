using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.Models;

namespace Tasker.InitialDataProviders
{
    class InitialSubjects
    {
        public ICollection<Subject> Provide(ICollection<Teacher> teachers)
        {
            return new List<Subject>
            {
                new Subject("Programowanie 4 - lab",teachers.Single(x=>x.LastName=="Warwas"),9,5),
                new Subject("");
                /* J.ang. 1 ; Md 2 ; Boio 3 ; P4 3 ; SK 6 ; GK 4 ; MSI 6 ; BD 5 */
            }
        }
    }
}
