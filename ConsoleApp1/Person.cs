using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        public string Firstname { get; }
        public string Lastname { get; }
        public Person(string fn, string ln)
        {
            Firstname = fn;
            Lastname = ln;
        }
    }
}
