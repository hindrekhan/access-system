﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Rooms
{
    class DataProcessors : Room
    {
        public DataProcessors()
        {
            Name = "Andmetöötlejate ruum";
        }

        public override void InitializeAccessableJobs()
        {
            AccessableJobs.Add(new Jobs.DataProcessor());
            AccessableJobs.Add(new Jobs.Owner());
            AccessableJobs.Add(new Jobs.SeniorDeveloper());
            AccessableJobs.Add(new Jobs.SpecialJanitor());
        }
    }
}
