using inheritance.Models;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BackEndDeveloper x001 = new BackEndDeveloper();
            {
                x001.Name = "Rusif";
                x001.SurName = "Safarov";
                x001.Age = 20;
                x001.Experience = 3;
                x001.Salary = 1000;
                x001.KnownLanguages = new string[] { "Python", "C#" };
                x001.KnownPatternCount = 2;
            }
            FrontEndDeveloper x002 = new FrontEndDeveloper();
            {
                x002.Name = "Ali";
                x002.SurName = "Cafarov";
                x002.Age = 21;
                x002.Experience = 4;
                x002.Salary = 1500;
                string[] languages= new string[] { "Javascript", "Python" };
                x002.KnownLanguages = languages; 
                x002.CodeLineCount = 254003;
            }

            x001.WriteCode();
            x002.WriteCode();
            
        }
    }
}