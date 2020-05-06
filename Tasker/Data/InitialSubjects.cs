using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.Models;

namespace Tasker.Data
{
    public static class InitialSubjects
    {
        public static List<Subject> Provide(ICollection<Teacher> teachers)
        {
            return new List<Subject>
            {
                new Subject("Programowanie 4 - lab", "P4 lab",
                teachers.Single(t=>t.LastName.Equals("Warwas")), 3, 9),
                new Subject("Programowanie 4 - wykład", "P4 w",
                teachers.Single(t=>t.LastName.Equals("Warwas")), 3, 9),
                new Subject("Metody Sztucznej inteligencji", "MSI",
                teachers.Single(t=>t.LastName.Equals("Kordos")), 6, 5),
                new Subject("Grafika Komputerowa", "GK",
                teachers.Single(t=>t.LastName.Equals("Ilewicz")), 4, 3)
                /* J.ang. 1 ; Md 2 ; Boio 3 ; P4 3 ; SK 6 ; GK 4 ; MSI 6 ; BD 5 */
            };
        }
    }
}
