//creat a new string  where the first and last characters will change their positions.
            Console.WriteLine(remove_char("w3resource" ));
            Console.WriteLine(remove_char("Python" ));
            Console.WriteLine(remove_char("x" ));

            //Create a new string from a given string with the first character added at the front and back
            string texts;
            Console.WriteLine("Input a string to make texts look weird");
            Console.WriteLine("Input a string: ");
            texts = Console.ReadLine();
            if (texts.Length >= 1)
            {
                var s = texts.Substring(0, 1);
                Console.WriteLine(s + texts + s);
            }

            //Write a C# program to see two given integers and return true if one is negative and one is positive
            int first, second;
            Console.WriteLine("If one num is negative then return true");
            Console.WriteLine("Input the num: ");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second num: ");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check to see which one is positive: ");
            Console.WriteLine((first < 0 && second > 0) || (first > 0 && second < 0));

            //Sum of two num, if two num equals then return 3 of their sum
            int num1, num2;
            Console.WriteLine("If two num equals then sum will x3 else they will = (x + y)");
            Console.WriteLine("Enter 1st num: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd num: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine((num1 + num2) * 3);
            }
            else
            {
                Console.WriteLine(num1 + num2);
            }
            //Absolute value
            Console.WriteLine("Enter a number to get absolute value: ");
            Console.WriteLine(value(13, 40));
            Console.WriteLine(value(50, 21));
            Console.WriteLine(value(0, 23));

            //If one num = 20 or sum = 20 return true
            int x, y;
            int sum;
            Console.WriteLine("If one num = 20 or sum = 20 return true");
            Console.WriteLine("input a num: ");
             x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input another num: ");
             y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x == 20 || y== 20 || ( x+y == 20));
            //if num = 20 or 100 or 200 return true
            Console.WriteLine("if = 20, 100, 200 return true");
            Console.WriteLine("input a num");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(whoa(a));
            //C# lower case
            string line = "SEE THIS TURN LOWERCASE";
            Console.WriteLine(line.ToLower());
