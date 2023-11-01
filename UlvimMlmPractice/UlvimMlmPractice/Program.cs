using Core.Models;
using System.Diagnostics.Metrics;

namespace UlvimMlmPractice;

internal class Program
{
    static void Main(string[] args)
    {
        Book kitab;
        User d = new User();
        d.Name = "Rusif";
        d.SurName = "Safarov";
        d.UserName = "RS";
        d.Password = "123456";
        d.role = Role.Admin;
        users.Add(d);

        Author muellif1 = new Author("Ali", "Qasimov");
        Author muellif2 = new Author("Kerem", "Qasimov");
        Author muellif3 = new Author("Xalid", "Qasimov");
        Author muellif4 = new Author("Qezenfer", "Qasimov");
        Author muellif5 = new Author("Kaz", "Qasimov");
        Author[] muellifler = { muellif1, muellif2, muellif3, muellif4, muellif5 };
        string name;
        string surname;
        string username;
        string password;
        bool iscontunie = true;
        while (iscontunie)
        {
            Console.WriteLine("1: Login\n2: Register\n3: GetUser\n4: Logut\n5: Quit\n6: Get username and password");
            string a = Console.ReadLine();
            switch (a)
            {
                case "1":
                    Console.WriteLine("Username daxil edin");
                    username = Console.ReadLine();
                    Console.WriteLine("Pasword daxil edin");
                    password = Console.ReadLine();

                    if (Authorization.Login(username, password).role == Role.Admin)
                    {
                        goto rs;
                    }


                    break;
                case "2":
                    Console.WriteLine("name enter surname enter username enter pasword");
                    name = Console.ReadLine();
                    Console.WriteLine("surname");
                    surname = Console.ReadLine();
                    Console.WriteLine("username");
                    username = Console.ReadLine();
                    while (!Authorization.CheckUsername(username))
                    {
                        Console.WriteLine("Usernami yeniden daxil edin:");
                        username = Console.ReadLine();
                    }
                    Console.WriteLine("pasword");

                    password = Console.ReadLine();
                    while (!Authorization.CheckPassword(password))
                    {
                        Console.WriteLine("Passwordu yeniden daxil edin:");
                        password = Console.ReadLine();
                    }
                    Authorization.Register(name, surname, username, password, d);
                    break;
                case "3":
                    Authorization.GetUsers();
                    break;
                case "4":
                    Authorization.Logout();
                    break;
                case "6":
                    Authorization.GetUserinfo(Console.ReadLine());
                    break;
                case "5":
                    iscontunie = false;
                    break;
            }
        rs:
            Console.WriteLine("1: Create book\n2: Logout");
            string q = Console.ReadLine();
            switch (q)
            {
                case "1":
                    Console.WriteLine("Muellifi secin:");
                    foreach (var item in muellifler)
                    {
                        Console.WriteLine($"Author Name: {item.Name}  Author Surname:{item.Surname}");
                    }
                    kitab = new Book();
                    break;
                case "2":
                    Authorization.Logout();
                    break;
            }


        }
    }

    public static List<User> users { get; set; } = new List<User>();
    public static bool islogin=false;

    public static class Authorization
    {
        static public void Register(string name, string surname, string username, string password,User a)
        {
            a.Name = name;
            a.SurName = surname;
            a.UserName = username;
            a.Password = password;
            a.role = Role.Member;
            users.Add(a);
        }
        public static User Login(string username,string password)
        {
            if (users is not null)
            {
                if (islogin)
                {
                    foreach (var item in users)
                    {
                        if (item.UserName == username)
                        {
                            if (item.Password == password)
                            {
                                Console.WriteLine("Login olundu");
                                islogin = true;
                                return item;
                            }
                            else
                            {
                                Console.WriteLine("Password Yanlisdir!");
                            }
                        }
                        else
                        {
                        Console.WriteLine("Username tapilmadi!");
                        }

                    }  

                }
                else
                {
                    Console.WriteLine("evvelceden login olunub");
                }
            }
            else
            {
                Console.WriteLine("Istifadechi yoxdur");
            }
            return null;
        }
        public static void Logout()
        {
            if (islogin)
            {
                islogin = false;
                Console.WriteLine("Hesabdan chixildi.");
            }
            else
            {
                Console.WriteLine("Login olunmayib");
            }
        }
        public static void GetUsers()
        {
            foreach (var item in users)
            {
                Console.WriteLine(item.UserName);
            }
        }
        public static void GetUserinfo(string username)
        {
            foreach (var item in users)
            {
                if (username == item.UserName)
                {
                Console.WriteLine(item.UserName+" "+ item.Password);

                }
            }
        }

        public static bool CheckUsername(string username)
        {
            if (username.Length < 4)
            {
                Console.WriteLine("username 4 simvoldan qisadir");
                return false;
            }
            foreach (var item in users)
            {
                if (item.UserName == username)
                {
                    Console.WriteLine("username artiq istifade olunub");
                    return false;
                }
            }
            return true;
        }
        public static bool CheckPassword(string password)
        {
            if (password.Length < 6)
            {
                Console.WriteLine("password 6 simvoldan qisadir");
                return false;
            }
            return true;
        }
    }
}