namespace Acces_modifier_sinifde_task_tekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook x001 = new Notebook("",0,0);

            Console.WriteLine("Nece notbuk var?");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Product Brand: ");
                string e = Console.ReadLine();
                Console.WriteLine("Product Model: ");
                string f = Console.ReadLine();
                Console.WriteLine("Product price: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Product Ram: ");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Product Storage: ");
                int d = Convert.ToInt32(Console.ReadLine());
                x001 = new Notebook(f, a, b);
                
                x001.Brand = e;
                x001.Ram = c;
                x001.Storage = d;

                 
            }
        }
    }
}