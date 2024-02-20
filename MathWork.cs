namespace MaU_C__Assignment2
{
    internal class MathWork
    {
        /// <summary>
        /// Start Method, executing the Calculate() method as long as the user wants to
        /// </summary>
        public void MathWorkStart() 
        {
            do
            {
                Console.WriteLine("********** Math Works **********");
                Calculate();
            } while (ExitCalculation() == true);
        }
        /// <summary>
        /// Calculate() Method, taking in two user-input numbers, putting them in order of size,
        /// and passing them as parameters into the other MathWork methods
        /// </summary>
        private static void Calculate()
        {
            Console.WriteLine();
            Console.WriteLine("Give me two numbers!");

            string readResult;
            bool validInput;

            int numberOne = 0;
            Console.Write("The first number: ");
            do
            {
                readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _))
                {
                    numberOne = Convert.ToInt32(readResult);
                    validInput = true;
                }
                else
                {
                    validInput = false;
                    Console.WriteLine("Try again. Enter a proper number for the calculations!");
                }
            } while (validInput == false);

            int numberTwo = 0;
            Console.Write("and the second number: ");
            do
            {
                readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _))
                {
                    numberTwo = Convert.ToInt32(readResult);
                    validInput = true;
                }
                else
                {
                    validInput = false;
                    Console.WriteLine("Try again. Enter a proper number for the calculations!");
                }
            } while (validInput == false);

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

            Console.WriteLine($"The sum of numbers between {startNumber} and {endNumber} is {SumNumbers(startNumber, endNumber)}");
            PrintEvenNumbers(startNumber, endNumber);
            PrintOddNumbers(startNumber, endNumber);
            CalculateSquareRoots(startNumber, endNumber);
        }

        /// <summary>
        /// Takes user input numbers and prints the sum of all the numbers between those two
        /// </summary>
        /// <param name="start">User input start number</param>
        /// <param name="end">User input end number</param>
        /// <returns>Int sum of all numbers between the two params</returns>
        private static int SumNumbers(int start, int end)
        {
            int sum = 0;

            for (int i = 0; start <= end; i++)
            {
                sum += start;
                start++;
            }

            return sum;
        }

        /// <summary>
        /// Takes user input numbers and prints the all even numbers between those two
        /// </summary>
        /// <param name="num1">User input start number</param>
        /// <param name="num2">User input end number</param>
        private static void PrintEvenNumbers(int num1, int num2)
        {
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

        /// <summary>
        /// Takes user input numbers and prints the all odd numbers between those two
        /// </summary>
        /// <param name="num1">User input start number</param>
        /// <param name="num2">User input end number</param>
        private static void PrintOddNumbers(int num1, int num2)
        {
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

        /// <summary>
        /// Takes user input numbers and, with a nested loop, 
        /// calculates the square root of all numbers between those two.
        /// </summary>
        /// <param name="num1">User input start number</param>
        /// <param name="num2">User input end number</param>
        private static void CalculateSquareRoots(int num1, int num2) 
        {
            Console.WriteLine();
            Console.WriteLine($"**** Square Roots ****");

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
                    double sqrtValue = Math.Sqrt(j);
                    double roundValue = Math.Round(sqrtValue, 2, MidpointRounding.AwayFromZero);
                    Console.Write($"  {roundValue:0.00}");
                }
                Console.WriteLine();
                num1++;
            }
        }

        /// <summary>
        /// Method asking for user input, for whether to stay or leave the MathWork method
        /// </summary>
        /// <returns>bool answer, true or false, staying inside or exiting the loop</returns>
        private static bool ExitCalculation()
        {
            Console.WriteLine();
            Console.WriteLine("Exit Math Work? (y/n)");

            bool validInput;
            bool answer;

            do
            {
                var readResult = Console.ReadLine().ToLower().Trim();
                if (readResult == "y")
                {
                    validInput = true;
                    answer = false;
                }
                else if (readResult == "n")
                {
                    validInput = true;
                    answer = true;
                }
                else
                {
                    Console.WriteLine("Please try again by entering yes or no. Do you want to continue? (y/n)");
                    validInput = false;
                    answer = false;
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
