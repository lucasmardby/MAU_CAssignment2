﻿namespace MaU_C__Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                MainMenu();
            } while (ExitApplication() == false);
        }

        /* TO-DO
         - finish writing weekday lines
         */
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine(" ---- Main Menu ----".ToUpper());
            Console.WriteLine("--------------------");
            Console.WriteLine();
            Console.WriteLine("Enter a number to choose one of my methods:");
            Console.WriteLine("\t[1] Temperature Converter\n\t[2] String Functions\n\t[3] Math Work\n\t[4] Scheduler");
            Console.WriteLine();

            MenuChoices();
        }

        private static void MenuChoices()
        {
            int menuChoice = 0;
            string readResult;
            var validInput = false;

            do
            {
                Console.Write("Your choice: ");
                readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _))
                {
                    menuChoice = Convert.ToInt32(readResult);
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Try again. Enter a proper number to choose options.");
                }
            } while (validInput == false);

            switch (menuChoice)
            {
                case 1:
                    Console.Clear();
                    var tempObj = new TemperatureConverter();
                    tempObj.TemperatureConverterStart();
                    break;
                case 2:
                    Console.Clear();
                    var stringObj = new StringFunctions();
                    stringObj.StringFunctionStart();
                    break;
                case 3:
                    Console.Clear();
                    var mathObj = new MathWork();
                    mathObj.MathWorkStart();
                    break;
                case 4:
                    Console.Clear();
                    var scheduleObj = new Scheduler();
                    scheduleObj.SchedulerStart();
                    break;
            }

        }
        private static bool ExitApplication()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" ---- Exit Application? (y/n) ----");

            bool validInput = true;
            bool answer = false;

            //loop to make sure user input is a valid yes or no
            do
            {
                var readResult = Console.ReadLine().ToLower().Trim();
                if (readResult == "y")
                {
                    answer = true; //wants to exit
                    validInput = true;

                    Console.WriteLine();
                    Console.WriteLine("Exiting application...");
                    HelperMethods.ConfirmationButton();
                    Console.Clear();
                }
                else if (readResult == "n")
                {
                    answer = false; //wants to stay
                }
                else
                {
                    Console.WriteLine("Please try again by entering yes or no. Do you want to continue? (y/n)");
                    answer = false;
                    validInput = false;
                }
            } while (validInput == false);

            return answer;
        }
    }
}