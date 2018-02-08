using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Used by Room and Job cuz they used the same print logic
    class NamePlace
    {
        public string Name;

        public void PrintName(int count)
        {
            count++;
            Console.WriteLine(count + ". " + Name);
        }
    }
}
