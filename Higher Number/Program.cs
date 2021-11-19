using System;

namespace Higher_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // program re-run loop
            do
            {
                // clear console
                Console.Clear();
                // single run of the program
                RunTest();
                // add in a blank line
                Console.WriteLine();
                // ask to run again
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Press 'x' to exit or any other key to try again.");
            }
            // re-run program test
            while (Console.ReadKey().KeyChar != 'x');



        }
        // single run of the program
        static void RunTest()
        {
            // welcome the user
            DrawWelcome();
            // catch errors
            try
            {
                // get numbers from user
                int number1 = GetUserNumber("Please enter the fist number: ");
                int number2 = GetUserNumber("Please enter the second number: ");
                // begin result output
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"The higher of {number1} and {number2} is: ");
                // begin result output
                Console.ForegroundColor = ConsoleColor.White;
                // check which is higher and output
                if (number1 > number2) Console.WriteLine(number1);
                else if (number2 > number1) Console.WriteLine(number2);
                else Console.WriteLine("Neither of them!");
            }
            // catch errors
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error {e.Message}");
            }
        }

        // draw boilerplate
        static void DrawWelcome()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("========================");
            Console.Write("====");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Higher Number");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("====");
            Console.WriteLine("========================");
            Console.WriteLine();
        }


        // get a number from the user
        static int GetUserNumber(string question)
        {
            // ask for a number
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(question);
            Console.ForegroundColor = ConsoleColor.White;
            // get user number
            int userNumber = int.Parse(Console.ReadLine());
            // return number
            return userNumber;
        }
    }
}



   