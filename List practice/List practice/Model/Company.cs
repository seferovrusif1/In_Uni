using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace List_practice.Model
{
    internal class Company
    {
        public string Name { get; set; }

        public List<Employe> Employees=new List<Employe> (); 

        public void AddEmployee(Employe employee)
        {
            Employees.Add(employee);
        }
        public Employe GetEmployeeById(int id)
        {
            foreach (var item in Employees)
            {
                    if (item.Id == id)
                    {
                        return item;
                    }
            }
            throw new Exception("User not Found!");

            
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
            Console.WriteLine("Position daxil edin");
            this.GetEmployeeById(id).Position = Console.ReadLine();
        }

        public void GetAllEmployees()
        {
            foreach (var item in Employees)
            {
                Console.WriteLine(item);

            }
        }

        public void RemoveEmployee(int id)
        {
            Employees.Remove( this.GetEmployeeById(id));
        }








    }
}
