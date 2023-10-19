namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car x001 = new Car("BMW", "M5","ah");
            //Car x002 = new Car("BMW", "M3");
            //x002.Color ="Red";
            //x002.SeatNumber = 124;
            //Car x003 = new Car("Mercedes", "e300");
            //x002.Color = "Green";
            //x002.SeatNumber = 125;
            //Car x004 = new Car("BMW", "M4");
            //x002.Color = "Red";
            //x002.SeatNumber = 137;

            //string[] arr =Car.;
            //Console.WriteLine($"{x001.Brand} {x001.Model}");

            Student x001 = new Student("Rusif", "Safarov");
            Student x002 = new Student("ALi", "Safarov", "asfd");
            Student x003 = new Student("Nihad", "Safarov", "asfd", 23);
            Student x004 = new Student("Kerem", "Safarov", "asfd", 23, true);
            Student x007 = new Student("Cefer", "Safarov", "asfd", 23, true);
            Student x005 = new Student("Vuqar", "Safarov", "asfd", 23, true);
            Console.WriteLine(x004.Name+x004.Surname+x004.Group);

            Student[] arr = new Student[] {x001,x002,x003,x004,x005,x007} ;


            foreach (var item in arr)
            {
                Console.WriteLine($"{item.Name} {item.Surname} {item.Group} {item.Age} {item.HasScholarship}");
            }



        }
    }
    
}