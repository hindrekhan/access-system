using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Room
    {
        protected string Name;
        public List<Job> AccessableJobs;

        public void PrintName(int count)
        {
            count++;
            Console.WriteLine(count + ". " + Name);
        }

        public void IsAccessible(Job checkJob)
        {

        }
    }
}
