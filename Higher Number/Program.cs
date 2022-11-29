using System;

namespace Higher_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawWelcome();
        }

        static void DrawWelcome()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "===== Higher Number ====="));
            Console.WriteLine();
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Press any key to continue"));
            Console.ReadKey();
            RunTest();
        }
        static void RunTest()
        {
            Console.Clear();
            // catch errors
            try
            {
                // get numbers from user
                int number1 = GetUserNumber("Please enter the fist number: ");
                int number2 = GetUserNumber("Please enter the second number: ");
                Console.WriteLine();
                // begin result output
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"The higher of {number1} and {number2} is: ");
                // begin result output
                Console.ForegroundColor = ConsoleColor.White;
                // check which is higher and output
                if (number1 > number2) Console.WriteLine(number1);
                else if (number2 > number1) Console.WriteLine(number2);
                else Console.WriteLine("Neither of them!");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                again();
            }
            // catch errors
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error {e.Message}");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                again();
            }
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
        private static void again()
        {
            Console.Clear();
            Console.WriteLine("if you wish to rerun the program press 'y' otherwise press 'n' to exit.");
            string usercommand = Console.ReadLine().ToLower();
            if (usercommand == "y")
            {

                RunTest();

            }
            else if (usercommand == "n")
            {
                exit();
            }
        }
        private static void exit()
        {
            Console.Clear();
            Console.WriteLine("Thank you for using my program");
            Console.WriteLine("Find more interesting projects at my GitHub Repository: bit.ly/2YDCMYQ ");
            Console.WriteLine();
            Console.WriteLine("Program Developed by Jordan W Sparkes");
            Console.WriteLine("Program Developed using Visual Studio 2019 Community Edition");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}



