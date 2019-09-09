using System;
using System.Linq;

namespace The_Real_C_Sharp_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Longest word in a string 
            string line = "Write a text to display the longest word";
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);   //First try
            string word = "";
            int num = 0;
            foreach (string s in words)
            {
                if (s.Length > num)
                {
                    word = s;
                    num = s.Length;
                }
            }
