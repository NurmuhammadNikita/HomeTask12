using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace kutbhona
{
    internal class User
    {
        public int Age;
        public string Name;
        public static int PensiyaYoshi;

        public User(int age) {
            this.Age = age;
        }
        public void ChackAge()
        {
            if(Age >= PensiyaYoshi)
            {
                Console.WriteLine("Pensiyada");
            }
            else
            {
                Console.WriteLine($"Pensiyaga qancha vaqt qoldi: {PensiyaYoshi - Age}");

            }

        }
        static public void ShowRetirementAge()
        {
            Console.WriteLine(PensiyaYoshi);
        }
    }
}

