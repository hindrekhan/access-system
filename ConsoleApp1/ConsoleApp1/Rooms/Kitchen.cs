using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Rooms
{
    class Kitchen : Room
    {
        public Kitchen()
        {
            Name = "Köök";
        }

        public override bool IsAccessible(Job checkJob)
        {
            return true;
        }

        public override void InitializeAccessableJobs()
        {
        }
    }
}
