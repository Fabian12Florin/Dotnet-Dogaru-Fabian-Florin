using System;
using System.Collections.Generic;
using System.Text;

namespace Introductiv
{
    class Person
    {
        string middleName = "Granola Bar";
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
