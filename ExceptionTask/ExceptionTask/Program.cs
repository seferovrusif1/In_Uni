﻿    using ExceptionTask.Exceptions;
    using ExceptionTask.Models;
    using System.Reflection;
    using System.Text.RegularExpressions;


User1 s = new User1();
var props = typeof(User1).GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
foreach (var item in props)
{
    Console.WriteLine(item);
}
props[0].SetValue(s, 12);
props[1].SetValue(s, "Rusif");
props[2].SetValue(s, 20);
foreach (var item in props)
{
    Console.WriteLine(item.GetValue(s));
}

User1.ChangeAge(2);
Console.WriteLine("\nmethod ile deyisdikden sonra age:\n" + props[2].GetValue(s));
var method = typeof(User1).GetMethod("ChangeAge", BindingFlags.NonPublic | BindingFlags.Static);
method.Invoke(obj: null, parameters: new object[] { (int)4 });
//method.Invoke(null, new object[] { (int)4 });
Console.WriteLine(props[2].GetValue(s));

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