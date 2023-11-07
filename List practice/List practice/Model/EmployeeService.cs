using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace List_practice.Model
{
    internal class EmployeeService
    {
         
        public void AddEmployee(Employe employee)
        {
            CompanyDatabase.Employees.Add(employee);
        }
        public Employe GetEmployeeById(int id)
        {
            Employe? emp = CompanyDatabase.Employees.Find(emp => emp.Id == id);
            if (emp == null)
            {
                throw new UserNotFoundException("User not Found!");
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
            CompanyDatabase.Employees.ForEach(x => Console.WriteLine(x));

        }
        public void GetEmployeesByValue(string str)///////////////////
        {
            // CompanyDatabase.Employees.ForEach(x =>    x.Name.Contains(str) && x.SurName.Contains(str) );
            //CompanyDatabase.Employees.ForEach()
            //var d=CompanyDatabase.Employees.FindAll(x => CompanyDatabase.Employees.Any(item => item.Name.Contains(str) || item.SurName.Contains(str))) ;
            CompanyDatabase.Employees.FindAll(item => item.Name.Contains(str) || item.SurName.Contains(str)).ForEach(x => Console.WriteLine(x));
            
        }
        public void GetLatestEmployees()
        {
            CompanyDatabase.Employees.FindAll(item => (DateTime.Now-item.CreatedAt).TotalDays<7).ForEach(x => Console.WriteLine(x));
        }

        public void RemoveEmployee(int id)
        {
            CompanyDatabase.Employees.Remove(this.GetEmployeeById(id));
        }






    }
}
