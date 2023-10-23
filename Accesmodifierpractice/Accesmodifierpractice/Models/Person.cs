using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accesmodifierpractice.Models
{
    internal class Person
    {
        private string _name;
        private string _surname;
        private byte _age;
        private DateTime _birthday;
        private string _phonenumber;






        public string PhoneNumber
        {
            get { return _phonenumber; }
            set 
            {
                value = value.TrimStart();
                if ((value.Length==13) && (value.StartsWith("+994")))
                    {
                        _phonenumber = value;
                    }
                else
                    {
                        Console.WriteLine("Wrong number");
                    }
            } 

        }
        public byte Age
        {
            get { return _age; }
            set
            {
                if (16<value)
                {
                    _age = value;
                }
                else              

                {
                    Console.WriteLine("Yas balacadir");
                }
            }
        }



        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length >= 2)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Username en azi 2 simvol olmalidi");
                }

            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
            }
        }
        public DateTime BirthDay
        {
            get
            {
                return _birthday;
            }
            set
            {
                _birthday = value;
            }
        }
        public string GetName()
        {
            return _name;
        }
        public string GetSurname()
        {
            return _surname;
        }
        public string GetPhone()
        {
            return _phonenumber;
        }
        public byte GetAge()
        {
            return _age;
        }
        public DateTime GetBirthDay()
        {
            return _birthday;
        }
        public void GetFullInfo()
        {
        Console.WriteLine($"Name: {GetName()}\nSurname: {GetSurname()}\nBirthday: {GetBirthDay()}\nAge: {GetAge()}\nTel. no: {GetPhone()}");

        }
    }
}
