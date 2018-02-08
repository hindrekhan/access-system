using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Job
    {
        protected string Name;

        public void PrintName(int count)
        {
            count++;
            Console.WriteLine(count + ". " + Name);
        }
    }
}
