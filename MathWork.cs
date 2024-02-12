namespace MaU_C__Assignment2
{
    internal class MathWork
    {
        public void MathWorkStart() 
        {
            do
            {
                Console.WriteLine("********** Math Works **********");
                Calculate();
            } while (ExitCalculation() == true);
        }

        private static void Calculate()
        {
            //takes two user input numbers
            Console.WriteLine();
            Console.WriteLine("Give me two numbers!");
            
            Console.Write("The first number: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("and the second number: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            //set start and end numbers based on size
            int startNumber;
            int endNumber;
            if (numberOne < numberTwo)
            { 
                startNumber = numberOne;
                endNumber = numberTwo;
            }
            else
            {
                endNumber = numberOne;
                startNumber = numberTwo;
            }

            //following methods, taking these integers as parameters
            Console.WriteLine($"The sum of numbers between {startNumber} and {endNumber} is {SumNumbers(startNumber, endNumber)}");
            PrintEvenNumbers(startNumber, endNumber);
            PrintOddNumbers(startNumber, endNumber);
            CalculateSquareRoots(startNumber, endNumber);
        }
        private static int SumNumbers(int start, int end)
        {
            //calculates the sum of all numbers between start and end numbers
            int sum = 0;

            for (int i = 0; start <= end; i++)
            {
                sum += start;
                start++;
            }

            return sum;
        }

        private static void PrintEvenNumbers(int num1, int num2)
        {
            //prints all even numbers between start and end numbers
            Console.WriteLine();
            Console.WriteLine($"****Even numbers between {num1} and {num2}");

            for (int i = 0; num1 <= num2; i++)
            {
                var isEvenNumber = num1 % 2 == 0;
                if (isEvenNumber == true)
                {
                    Console.Write($"   {num1}");
                }
                num1++;
            }
            Console.WriteLine();
        }
        private static void PrintOddNumbers(int num1, int num2)
        {
            //prints all odd numbers between start and end numbers
            Console.WriteLine();
            Console.WriteLine($"****Odd numbers between {num1} and {num2}");

            for (int i = 0; num1 <= num2; i++)
            {
                var isOddNumber = num1 % 2 == 1;
                if (isOddNumber == true)
                {
                    Console.Write($"   {num1}");
                }
                num1++;
            }
            Console.WriteLine();
        }
        private static void CalculateSquareRoots(int num1, int num2) 
        {
            Console.WriteLine();
            Console.WriteLine($"**** Square Roots ****");

            //nested loop calculating the square root of all numbers between start and end numbers 
            for (int i = 0; num1 <= num2; i++)
            {
                if (num1.ToString().Length == 1)
                {
                    Console.Write($"Sqrt(  {num1} to {num2})");
                }
                else
                {
                    Console.Write($"Sqrt( {num1} to {num2})");
                }

                for (int j = num1; j <= num2; j++)
                {
                    double sqrtValue = Math.Sqrt(j); //square root of value
                    double roundValue = Math.Round(sqrtValue, 2, MidpointRounding.AwayFromZero); //round down
                    Console.Write($"  {roundValue:0.00}"); //and display with the correct amount of decimals
                }
                Console.WriteLine();
                num1++;
            }
        }
        private static bool ExitCalculation()
        {
            Console.WriteLine();
            Console.WriteLine("Exit Math Work? (y/n)");

            bool validInput = true;
            bool answer = false;

            //check for valid user input
            do
            {
                var readResult = Console.ReadLine().ToLower().Trim();
                if (readResult == "y")
                {
                    answer = false; //wants to exit
                }
                else if (readResult == "n")
                {
                    answer = true; //wants to stay
                }
                else
                {
                    Console.WriteLine("Please try again by entering yes or no. Do you want to continue? (y/n)");
                    validInput = false;
                }
            } while (validInput == false);

            Console.WriteLine();
            Console.WriteLine("Exiting Math Works...");
            HelperMethods.ConfirmationButton();
            Console.Clear();

            return answer;
        }
    }
}
