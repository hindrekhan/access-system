﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Rooms
{
    class Owners : Room
    {
        public Owners()
        {
            Name = "Ülemuste tuba";
        }

        public override void InitializeAccessableJobs()
        {
            AccessableJobs.Add(new Jobs.SeniorDeveloper());
            AccessableJobs.Add(new Jobs.SpecialJanitor());
            AccessableJobs.Add(new Jobs.Owner());
        }
    }
}
