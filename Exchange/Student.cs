using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exchange
{
    internal class Student
    {
        public  int Id { get; set; }
        public string Name { get; set; }
        public string Surname  { get; set; }

        private static int NextId = 1;

        public Student ( string name, string surname)
        {
            Id = NextId++;
            Name = name;
            Surname = surname;

        }
        
    }

}
