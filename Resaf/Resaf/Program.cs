namespace Resaf
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IntList a = new IntList();
            Console.WriteLine("sdfckjhbsdfjhn");
            int b = Convert.ToInt32(Console.ReadLine());
            a.Add(b);
            a.Add(1, 2, 3);
            a.Get(1);
            Console.WriteLine(a.GetAll());
            a.Print();
        }
    }
}