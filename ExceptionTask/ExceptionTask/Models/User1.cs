using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask.Models
{
    internal class User1
    {
        private int _id=0;
        private string _name;
        private static int _age;
        static void ChangeAge(int age) 
        {
            
        }

        internal bool GetValues(User1 s)
        {
            throw new NotImplementedException();
        }
    }
}
