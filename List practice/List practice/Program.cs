using List_practice.Model;

namespace List_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

           //  = new Employe();
            string name;
            string surname;
            byte age;
            decimal salary;
            Gender gender=Gender.other;
            Position position=Position.worker;
            EmployeeService co = new EmployeeService();
            
                bool iscontunie = true;
                while (iscontunie)
                {
                    Console.WriteLine("1. Create employe:\n2. Get employee details by id\n3. Get all employees\n4.Update employee details id\n5.Delete employee records by id\n7.Get Employe by value\n7.Quit");
                    string a = Console.ReadLine();
                    switch (a)
                    {
                        case "1":
                       
                            Console.WriteLine("Enter name:"); name = Console.ReadLine();
                            Console.WriteLine("Enter surname:"); surname = Console.ReadLine();
                            Console.WriteLine("Enter age:"); age = Convert.ToByte(Console.ReadLine());
                            Console.WriteLine("Enter salary:"); salary = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Enter gender(1. Male\n2. FeMale\n3. other):");
                        bool x = true;
                        while (x)
                        {
                            gender = (Gender)(Convert.ToInt32(Console.ReadLine()));
                            if (gender == Gender.Male || gender == Gender.FeMale || gender ==Gender.other)
                            {
                                x = false;
                            }
                            else
                            {
                                Console.WriteLine("Gender is not correct:");

                            }
                        }
                        Console.WriteLine("Enter position(\n1.  Developer,\n2. teacher\n3. worker):");
                        x = true;
                        while (x)
                        {
                            position = (Position)(Convert.ToInt32(Console.ReadLine()));
                            if (position == Position.Developer || position == Position.teacher || position == Position.worker)
                            {
                                x = false;
                            }
                            else
                            {
                                Console.WriteLine("Position is not correct:");

                            }
                        }
                            Employe add = new Employe(name, surname, age, salary, gender,position,DateTime.Now);
                            co.AddEmployee(add);
                            break;
                        case "2":
                        try
                        {
                            Console.WriteLine("Write Employee Id:");
                            
                            Console.WriteLine(co.GetEmployeeById(Convert.ToInt32(Console.ReadLine())));

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }   
                        break;
                        case "3":
                            co.GetAllEmployees();
                             break;
                        case "4":
                        try
                        {
                            Console.WriteLine("Write Employee Id:");

                            int i = Convert.ToInt32(Console.ReadLine());
                            co.GetEmployeeById(i);
                            co.UpdateEmployee(i);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "5":
                        try
                        {
                            Console.WriteLine("Write Employee Id:");
                            co.RemoveEmployee(Convert.ToInt32(Console.ReadLine()));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "6":
                        try
                        {
                            Console.WriteLine("Write string:");
                             co.GetEmployeesByValue(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "7":
                            iscontunie = false;
                            break;
                        default:
                            Console.WriteLine("Wrong input!!");
                            break;

                    }
                }
            }
         
        }
    
}