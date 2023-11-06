using task_ulvi_t_in_lesson.Models;

namespace task_ulvi_t_in_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> People = new List<Person>();

            Person p = new Person("Rusif", "Safarov", 3);
            Person pe = new Person("Arzu", "Eliyova", 6);
            Person peo = new Person("Tehran", "Mammadov", 9);
            People.Add(p);
            People.Add(pe);
            People.Add(peo);
            //endwith
            Console.WriteLine(People.Find(peop => peop.Name == "Rusif"));
            foreach (var item in People.FindAll(peop => peop.SurnName.Substring(peop.SurnName.Length - 2) == "ov" || peop.SurnName.Substring(peop.SurnName.Length - 3) == "ova"))
            {
                Console.WriteLine(item);

            }
            


        }
    }
}