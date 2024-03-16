using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exchange
{
    internal class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private Student[] students;
        

        public Group(int Id, string name, Student [] students)
        {
            Id = Id;
            Name = name;
            this.students = students;
        }
        public Student this[int index]
        {
            get
            {
                if (index >= 0 && index < students.Length) 
                return students[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >=0  &&index >= students.Length)
                    students[index] = value;
                throw new IndexOutOfRangeException();
                    
            }
        }
      
    }
}
