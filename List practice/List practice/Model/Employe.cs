using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_practice.Model
{
    internal class Employe:Person
    {
        public decimal Salary { get; set; }
        public Position Position { get; set; }
        public Gender Gender { get; set; }

        public Employe(string name,string surname,byte age, decimal salary,Gender gender, Position position )
        {
            Name = name;
            SurName = surname;
            Age = age;
            Salary = salary;
            Gender = gender;
            Position = position;   
            
        }






        public override string ToString()
        {
            return $"Id=> {Id}  Name: {Name} Surname: {SurName} Age: {Age} Salary: {Salary} Position: {Position} Gender: {Gender}";
        }
    }
}
