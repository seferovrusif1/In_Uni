using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customDelegate__practice_task.Models
{


    public delegate int customDelegate(int a, int b);
    internal class DelegateMethods
    {

        public int methods(int a,int b, customDelegate meth)
        {
        customDelegate methh = new customDelegate(meth);
            methh(a, b);
            
            Console.WriteLine("wrong method");
            return 0;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }

    }
}
