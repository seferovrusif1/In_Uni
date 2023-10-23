using AccesModifier.Models.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifier.Models
{
    internal class User
    {
        private string _username;
        private string _password;
        public bool checklower = false;
        public bool checkint = false;
        public bool checkupper = false;



        public string Password
        {
            get { return _password; }
            set 
            {
                if (CheckLower(value) && CheckInt(value) && CheckUpper(value))
                {
                    _password = value;

                }
                else
                {
                    Console.WriteLine($"{CheckLower(value)} && {CheckInt(value)} && {CheckUpper(value)}");
                    Console.WriteLine("Wrong password");
                }
            }
        }


        public string UserName
        {
            get { return _username; }
            set
            {
                if (value.Length >= 4)
                {
                    _username = value;
                }
                else
                {
                    Console.WriteLine("Username en azi 4 simvol olmalidi");
                }

            }
        }



        


        public bool CheckLower(string Password)
        {
            foreach (var item in Password)
            {
                if (char.IsLower(item))
                {
                    checklower = true;
                    break;

                }
            }
            return checklower;
        }



        public bool CheckInt(string Password)
        {
            foreach (var item in Password)
            {
                if (Char.IsDigit(item))
                {
                    checkint = true;
                    break;
                }
            }
            return checkint;
        }



        public bool CheckUpper(string Password)
        {
            foreach (var item in Password)
            {
                if (char.IsUpper(item))
                {
                    checkupper = true;
                    break;

                }
            }
            return checkupper;
        }
    }

    
}
