using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace List_practice.Model
{
  //  delegate void Print(Person p);

    internal class Company
    {
        public string Name { get; set; }

        public List<Employe> Employees=new List<Employe> (); 

        public void AddEmployee(Employe employee)
        {
            Employees.Add(employee);
        }
        public Employe GetEmployeeById(int id)///////////////////////
        {
            Employe? emp = Employees.Find(emp => emp.Id == id);
            if ( emp== null) 
            {
                throw new Exceptions("User not Found!");
            }
            else
            {
                return emp;
            }
        }

        


        public void UpdateEmployee(int id)
        {
            Console.WriteLine("0-name 1- gender 2- Salary 3- Position");
            string a = Console.ReadLine();
            switch (a)
            {
                case "0":
                    UpdateName(id);
                    break;
                case "1":
                    UpdateGender(id);
                    break;
                case "2":
                    UpdateSalary(id);
                        break;
                case "3":
                    UpdatePosition(id);
                   
                        break;
            }

        }
        public void UpdateName(int id)
        {
            Console.WriteLine("name daxil edin");
            this.GetEmployeeById(id).Name = Console.ReadLine();
        }
        public void UpdateGender(int id)
        {
            Console.WriteLine("Enter gender(\n1. Male\n2. FeMale\n3. other):");
            this.GetEmployeeById(id).Gender = (Gender)(Convert.ToInt32(Console.ReadLine()));

        }
        public void UpdateSalary(int id)
        {

            Console.WriteLine("Salary daxil edin");
            this.GetEmployeeById(id).Salary = Convert.ToDecimal(Console.ReadLine());
        }
        public void UpdatePosition(int id)
        {
            Console.WriteLine("Enter position(\n1.  Developer,\n2. teacher\n3. worker):");
            this.GetEmployeeById(id).Position = (Position)(Convert.ToInt32(Console.ReadLine()));

        }

        public void GetAllEmployees()///////////////////
        {
            Employees.ForEach(x => Console.WriteLine(x));
            //var result = Employees.Select(p => p);
            //foreach (var person in result)
            //{
            //    Console.WriteLine(person);
            //}
            //foreach (var item in Employees)
            //{
            //    Console.WriteLine(item);

            //}
        }

        public void RemoveEmployee(int id)
        {
            Employees.Remove( this.GetEmployeeById(id));
        }








    }
}
