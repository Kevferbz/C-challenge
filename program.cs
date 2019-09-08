using System;

namespace The_Real_C_Sharp_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(remove_char("w3resource" ));
            Console.WriteLine(remove_char("Python" ));
            Console.WriteLine(remove_char("x" ));  
                

        }
        public static string remove_char(string ustr)
        {
            return ustr.Length > 1
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr; 


            
        }
    }
}
