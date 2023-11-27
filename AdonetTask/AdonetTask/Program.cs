using AdonetTask.Models;
using AdonetTask.Services;

namespace AdonetTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User u = new User()
            {
                Name = "sdas",
                Surame="asd",
                Password="asdert"
            };
            UserServices.Create(u);
        }
    }
}