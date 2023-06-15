using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Showinformation()
        {
            Console.WriteLine($"Name: {Name} Age: {Age}");
        }
    }
}
