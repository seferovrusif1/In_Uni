    using ExceptionTask.Exceptions;
    using ExceptionTask.Models;
    using System.Reflection;
    using System.Text.RegularExpressions;


    User1 s = new User1();

    var t = s.GetType().GetField("_id", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
    Console.WriteLine(t.GetValue(s));

    t.SetValue(s, 6);
    Console.WriteLine(t.GetValue(s));

    while (true)
    {
        User user = new User();
    l1:
        try
        {
            Console.WriteLine("Enter Name:");
            user.Name = Console.ReadLine();
        }
        catch (InvalidNameException x)
        {
            Console.WriteLine(x.Message);
            goto l1;
        }
    l2:
        try
        {
            Console.WriteLine("Enter Age");
            user.Age = Convert.ToInt32(Console.ReadLine());
        }
        catch (InvalidAgeException x)
        {
            Console.WriteLine(x.Message);
            goto l2;
        }
    l3:
        try
        {

            Console.WriteLine("Enter Password");
            user.Password = Console.ReadLine();

        }
        catch (PasswordException x)
        {
            Console.WriteLine(x.Message);
            goto l3;
        }
    l4:
        try
        {

            Console.WriteLine("Enter Phone");
            user.PhoneNuber = Console.ReadLine();

        }
        catch (InvalidPhoneNumber x)
        {
            Console.WriteLine(x.Message);
            goto l4;
        }


    }
                //bool iscontinue=true;
                ////while (iscontinue)
                ////{

                ////}