namespace extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Bu bir custom contains methodudur";
            Console.WriteLine(a.CustomContains("Bu"));
            Console.WriteLine(a.CustomContains("bu"));
            Console.WriteLine(a.CustomContains("tains"));
            Console.WriteLine(a.CustomContains("ns Methodudur"));
            Console.WriteLine(a.CustomContains("bu bir custom"));
             a = "Bu bir custom contains methodudur";
            Console.WriteLine(a.CustomContains1("Bu"));
            Console.WriteLine(a.CustomContains1("bu"));
            Console.WriteLine(a.CustomContains1("tains"));
            Console.WriteLine(a.CustomContains1("ns Methodudur"));
            Console.WriteLine(a.CustomContains1("bu bir custom"));
             a = "Bu bir custom contains methodudur";
            Console.WriteLine(a.CustomContains2("Bu"));
            Console.WriteLine(a.CustomContains2("bu"));
            Console.WriteLine(a.CustomContains2("tains"));
            Console.WriteLine(a.CustomContains2("ns Methodudur"));
            Console.WriteLine(a.CustomContains2("bu bir custom"));


        }
    }
}