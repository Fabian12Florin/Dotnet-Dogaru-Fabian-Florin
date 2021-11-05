using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2
{
    class Person
    {
        public string firstName;
        public string lastName;
        public int CNP;

        public Person (string firstName , string lastName , int CNP)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.CNP = CNP;
        }

        public int Sum(int nr1, int nr2)
        {
            return nr1 + nr2;
        }

        public int Sum(int nr1, int nr2, int nr3)
        {
            Console.WriteLine("A doua metoda");
            return nr1 + nr2 + nr3;
        }

        public void afisare ()
        {
            Console.WriteLine(this.firstName);
            Console.WriteLine(this.lastName);
            Console.WriteLine(this.CNP);
        }
    }
}
