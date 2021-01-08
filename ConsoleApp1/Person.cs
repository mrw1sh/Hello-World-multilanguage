using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        internal string Firstname { get; }
        internal string Lastname { get; }
        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
