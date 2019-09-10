using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace The_Real_C_Sharp_Challenge_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {


            //Mision: Write a reversed sentence
            Console.WriteLine("Enter a sentence: ");
            var input = Console.ReadLine();
            string[] split = input.Split(' ');
            Array.Reverse(split);
            foreach (string s in split)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();



            //Mission: Write a C# program to find the size of a specified file in bytes.
            string hexVAL = "4B0";
            Console.WriteLine("HexVAL number: " + hexVAL);
            int decvalue = int.Parse(hexVAL, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("Convert to: ");
            Console.WriteLine("Dex number: " + decvalue);

            /*Write a C# Sharp program to compute the sum of the two given integer values. 
            If the two values are the same, then return triple their sum. */

            //Else
            Console.WriteLine(test(1, 2));
            Console.WriteLine(test(3, 2));
            Console.WriteLine(test(2, 2));
            Console.ReadKey();

            /* Write a C# Sharp program to get the absolute difference between n and 51. 
            If n is greater than 51 return triple the absolute difference. Go to the editor*/


            //multiply two array displayed
            int[] first = { 1, 3, -5, 4 };
            int[] second = { 1, 4, 7, 45 };

            Console.WriteLine("Arraay [{0}]", string.Join(", " , first));
            Console.WriteLine("array {0}", string.Join(",", second));
            Console.WriteLine("Multiply two array");

            for (int i = 0; i < first.Length; i++)
            {
                Console.WriteLine(first[i] * second[i] + "  ");
            }
            Console.WriteLine("\n");

            //4 copies of last words of sentence
            string stlrng;
            int line = 0;
            Console.Write("input a stirng :");
            stlrng = Console.ReadLine();
            if (stlrng.Length>4)
            {
                Console.WriteLine(stlrng.Length < 4 ? stlrng + stlrng + stlrng : stlrng.Substring(stlrng.Length - 4) + stlrng.Substring(stlrng.Length - 4) + stlrng.Substring(stlrng.Length - 4) + stlrng.Substring(stlrng.Length - 4) + stlrng.Substring(stlrng.Length - 4));


            }
            //Difficulty: medium
            string lol;
            int lastwords = 0;
            Console.WriteLine("Input a string");
            lol = Console.ReadLine();
            if (lol.Length>4)
            {
                Console.WriteLine(lol.Length < 4 ? lol + lol + lol : lol.Substring(lol.Length - 4) + lol.Substring(lol.Length - 4) + lol.Substring(lol.Length - 4) + lol.Substring(lol.Length - 4));
            }

            //multiple of 3 or 7 return true
            Console.WriteLine("if num = 3 or 7 return true ootherwise return false");
            Console.WriteLine("Input a num");
            int st = Convert.ToInt32(Console.ReadLine());
            if (st > 0)
            {
                Console.WriteLine(st % 3 == 0 || st % 7 == 0);
            }

            //pc talk back
            Console.WriteLine("If your texts include hello it will true");
            Console.WriteLine("input a fuking string ");
            string fuck = Console.ReadLine();
            Console.WriteLine((fuck.Length < 6 && fuck.Equals("Hello")) || (fuck.StartsWith("Hello") && fuck[5] == ' '));

            //cut 2
            Console.WriteLine("another string");
            fuck = Console.ReadLine();
            Console.WriteLine(fuck.StartsWith("Hello"));



        }
        public static int test(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }

    }
}
