using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Room : NamePlace
    {
        
        public List<Job> AccessableJobs;

        public abstract void InitializeAccessableJobs();

        public Room()
        {
            AccessableJobs = new List<Job>();
            InitializeAccessableJobs();
        }

        public virtual bool IsAccessible(Job checkJob)
        {
            //Loops through each job in AccessableJobs and checks if checkjob is the same
            foreach (Job job in AccessableJobs)
                if (checkJob.Name == job.Name)
                    return true;

            return false;
        }
    }
}
