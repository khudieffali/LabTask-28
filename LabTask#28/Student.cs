using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_28
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public Student(string name,string surname,byte age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
