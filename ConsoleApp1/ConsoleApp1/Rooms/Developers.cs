using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Rooms
{
    class Developers : Room
    {
        public Developers()
        {
            Name = "Arendajate ruum";
        }

        public override void InitializeAccessableJobs()
        {
            AccessableJobs.Add(new Jobs.Janitor());
            AccessableJobs.Add(new Jobs.JuniorDeveloper());
            AccessableJobs.Add(new Jobs.Owner());
            AccessableJobs.Add(new Jobs.SeniorDeveloper());
            AccessableJobs.Add(new Jobs.SpecialJanitor());
        }
    }
}
