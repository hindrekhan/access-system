using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Room
    {
        public string Name;
        public List<Job> AccessableJobs;

        public abstract void InitializeAccessableJobs();

        public Room()
        {
            AccessableJobs = new List<Job>();
            InitializeAccessableJobs();
        }

        public void PrintName(int count)
        {
            count++;
            Console.WriteLine(count + ". " + Name);
        }

        public virtual bool IsAccessible(Job checkJob)
        {
            foreach (Job job in AccessableJobs)
                if (checkJob.Name == job.Name)
                    return true;

            return false;
        }
    }
}
