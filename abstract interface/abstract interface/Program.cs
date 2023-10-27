namespace abstract_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Owl qus = new Owl();
            Dolphin baliq = new Dolphin();
            qus.Fly();
            baliq.Swim();

            Animal quss = new Owl();
            ((Owl)quss).Fly();
            
        }
    }
}