using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{

    internal class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Age;
        public bool HasScholarship; 
        public Student(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }
        public Student(string Name, string Surname,string Group) : this(Name, Surname)
        {
            this.Group = Group;
        }
        public Student(string Name, string Surname, string Group, int Age) : this(Name, Surname,Group)
        {
            this.Age = Age;
        }
        public Student(string Name, string Surname, string Group, int Age, bool HasScholarship) : this(Name, Surname,Group,Age)
        {
            this.HasScholarship = HasScholarship;
        }
    }
}
