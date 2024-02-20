namespace MaU_C__Assignment2
{
    internal class StringFunctions
    {
        /// <summary>
        /// Start Method, creating the Main Menu
        /// </summary>
        public void StringFunctionStart()
        {
            MainMenu();
        }

        /// <summary>
        /// Prints the Main Menu of String Functions, before going into the other class methods
        /// </summary>
        private static void MainMenu()
        {
            do
            {
                Console.WriteLine("---------- String Functions ----------".ToUpper());
                Console.WriteLine();
                Console.WriteLine();

                StringLength();
                PredictMyDay();
            } while (RunAgain() == true);
        }

        /// <summary>
        /// Takes a user input string and outputs it in upper case with it's length in characters
        /// </summary>
        private static void StringLength()
        {
            Console.WriteLine($"Write a text with any number of characters and press Enter.");

            var validInput = false;
            string text;

            do
            {
                text = Console.ReadLine();
                if (text != null)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Try again. Enter a sententce to move forward!");
                }
            } while (validInput == false);
            
            int length = text.Length;

            Console.WriteLine();
            Console.WriteLine(" ---- String Length ---- ".ToUpper());
            Console.WriteLine();
            Console.WriteLine(text.ToUpper());
            Console.WriteLine($"Number of chars = {length}");
        }

        /// <summary>
        /// Gives 'Fortune Telling' through user input number, entering into a switch case outputing sentences
        /// </summary>
        private static void PredictMyDay()
        {
            Console.WriteLine(" ********** The Fortune Teller ********** ");
            Console.WriteLine();
            Console.WriteLine($"Let me predict your day!\nSelect a number between 1 and 7:");

            var validInput = false;
            string readResult;
            int menuChoice = 0;

            do
            {
                Console.Write("Your choice: ");
                readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _))
                {
                    menuChoice = Convert.ToInt32(readResult);

                    if (menuChoice <= 7 && menuChoice > 0)
                    {
                        validInput = true;
                    }
                }
                else
                {
                    Console.WriteLine("Try again. Enter a proper number to get your fortune telling!");
                }
            } while (validInput == false);

            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("Monday! A new week filled with new opportunities!");
                    break;
                case 2:
                    Console.WriteLine("Tuesday! You're doing great, keep on pushing through!");
                    break;
                case 3:
                    Console.WriteLine("Wednesday, peak of the week. It's all downhill from here!");
                    break;
                case 4:
                    Console.WriteLine("Thursday! One more day, give youself some compliments!");
                    break;
                case 5:
                    Console.WriteLine("Friday, great job! Your well-deserved weekend awaits!");
                    break;
                case 6:
                    Console.WriteLine("Saturday! Time to make some fun, lasting memories!");
                    break;
                case 7:
                    Console.WriteLine("Sunday, a treat! What will you look forward to next week?");
                    break;
            }
        }

        /// <summary>
        /// Method asking for user input, for whether to stay or leave the StringFunctions method
        /// </summary>
        /// <returns>bool answer, true or false, staying inside or exiting the loop</returns>
        private static bool RunAgain()
        {
            Console.WriteLine();
            Console.WriteLine("Do you want to continue? (y/n)");

            bool validInput;
            bool answer = false;

            do
            {
                var readResult = Console.ReadLine().ToLower().Trim();
                if (readResult == "y")
                {
                    answer = true;
                    validInput = true;
                }
                else if (readResult == "n")
                {
                    answer = false;
                    validInput = true;
                    Console.WriteLine();
                    Console.WriteLine("Exiting String Functions...");
                }
                else
                {
                    Console.WriteLine("Please try again by entering yes or no. Do you want to continue? (y/n)");
                    validInput = false;
                }
            } while (validInput == false);

            Console.WriteLine();
            HelperMethods.ConfirmationButton();
            Console.Clear();

            return answer;
        }
    }
}
