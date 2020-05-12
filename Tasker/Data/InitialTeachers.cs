using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.Models;

namespace Tasker.Data
{
    public static class InitialTeachers
    {
        public static ICollection<Teacher> Provide()
        {
            //new Teacher("Stanisław","Zawiślak","naszdom44@gmail.com","",""),
            return new List<Teacher>
            {
                new Teacher("Kornel", "Warwas", "kwarwas@ath.bielsko.pl",
                "https://teams.microsoft.com/l/team/19%3a7718cf99a2a043788774aa3ebbfad826%40thread.tacv2/conversations?groupId=fc6279dd-8de1-4189-9808-4aacd40b4314&tenantId=70dbaa1f-55b3-4a67-96d1-7ba70d67f6b9"),
                new Teacher("Mirosław", "Kordos", "",
                "http://kordos.com/msi.html"),
                new Teacher("Grzegorz", "Ilewicz", "gilewicz@ath.bielsko.pl",
             "https://teams.microsoft.com/l/channel/19%3a37a398837f6b4222b2df41b190610c8e%40thread.tacv2/Og%25C3%25B3lny?groupId=c8d3b652-cd7d-4137-9825-a17a3ae23778&tenantId=70dbaa1f-55b3-4a67-96d1-7ba70d67f6b9")
            };
        }
    }
}

