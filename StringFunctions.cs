namespace MaU_C__Assignment2
{
    internal class StringFunctions
    {
        public void StringFunctionStart()
        {
            MainMenu();
        }

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

        private static void StringLength()
        {
            Console.WriteLine($"Write a text with any number of characters and press Enter.");

            var validInput = false;
            string text;

            do // makes sure user input is not null
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
            
            //prints the sentence in all-caps and its length 
            int length = text.Length;

            Console.WriteLine();
            Console.WriteLine(" ---- String Length ---- ".ToUpper());
            Console.WriteLine();
            Console.WriteLine(text.ToUpper());
            Console.WriteLine($"Number of chars = {length}");
        }

        private static void PredictMyDay()
        {
            Console.WriteLine(" ********** The Fortune Teller ********** ");
            Console.WriteLine();
            Console.WriteLine($"Let me predict your day!\nSelect a number between 1 and 7:");
            Console.Write("Your choice: ");

            var validInput = false;
            string readResult;
            int menuChoice = 0;

            do //checks for valid user input, for a number between 1 and 7
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

            //switch case with lines for the seven days
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

        private static bool RunAgain()
        {
            Console.WriteLine();
            Console.WriteLine("Do you want to continue? (y/n)");

            bool validInput = true;
            bool answer = false;

            //checks for valid user input
            do
            {
                var readResult = Console.ReadLine().ToLower().Trim();
                if (readResult == "y")
                {
                    answer = true;
                }
                else if (readResult == "n")
                {
                    answer = false;
                }
                else
                {
                    Console.WriteLine("Please try again by entering yes or no. Do you want to continue? (y/n)");
                    validInput = false;
                }
            } while (validInput == false);

            Console.WriteLine();
            Console.WriteLine("Exiting String Functions...");
            HelperMethods.ConfirmationButton();
            Console.Clear();

            return answer;
        }
    }
}
