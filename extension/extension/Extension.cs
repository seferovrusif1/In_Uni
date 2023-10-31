using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extension
{
    internal static class Extension
    {
        public static bool CustomContains(this string text, string txt)
        {
            text = text.ToLower();
            txt = txt.ToLower();
            int t = 0;
            int x = text.Length - txt.Length + 1;

            for (int i = 0; i < x; i++)
            {
                t = i;

                for (int j = 0; j < txt.Length; j++)
                {
                    if (text[t] == txt[j])
                    {
                        t++;
                        if (j == txt.Length - 1)
                        {
                            return true;
                        }
                    }

                }
            }
            return false;
        }




        public static bool CustomContains1(this string text, string txt)
        {
            text = text.ToLower();
            txt = txt.ToLower();
            int t = text.Length - txt.Length + 1;
            int x = txt.Length;


            for (int i = 0; i < t; i++)
            {
                if (text.Substring(i, x) == txt)
                {
                    return true;
                };

            }
            return false;
        }

        public static bool CustomContains2(this string text, string txt)
        {
            text = text.ToLower();
            txt = txt.ToLower();
            int t = text.Length - txt.Length + 1;
            int x = txt.Length;


            for (int i = 0; i < t; i++)
            {
                if (text.Substring(i, x) == txt)
                {
                    return true;
                };

            }
            return false;

        }
    }

}