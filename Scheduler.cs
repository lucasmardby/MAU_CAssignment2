namespace MaU_C__Assignment2
{
    internal class Scheduler
    {
        public void SchedulerStart()
        {
            MainMenu();
        }
        private void MainMenu()
        {
            Console.WriteLine("++++++++++ The Scheduler ++++++++++");
            Console.WriteLine("----------");
            Console.WriteLine("Your work schedule".ToUpper());
            Console.WriteLine("----------");
            Console.WriteLine();
            Console.WriteLine("\t[1] Show a list of the weekends to work\n\t[2] Show a list of the nights to work\n\t[0] Exit the Scheduler");
            Console.WriteLine();

            MenuChoices();
        }
        private void MenuChoices()
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

                    if (menuChoice == 0 || menuChoice == 1 || menuChoice == 2)
                    {
                        validInput = true;
                    }
                }
                else
                {
                    Console.WriteLine("Try again. Enter a proper number to choose options.");
                }
            } while (validInput == false);

            const int endWeek = 52;

            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("Work-weekends");
                    DisplayWorkSchedule(2, endWeek, 2);
                    HelperMethods.ConfirmationButton();
                    break;
                case 2:
                    Console.WriteLine("Work-nights");
                    DisplayWorkSchedule(1, endWeek, 4);
                    HelperMethods.ConfirmationButton();
                    break;
                case 0:
                    Console.WriteLine("Exiting application");
                    HelperMethods.ConfirmationButton();
                    Console.Clear();
                    break;
            }
            
        }
        private static void UserInput()
        { 
        
        }
        private static void DisplayWorkSchedule(int startWeek, int endWeek, int intervals)
        {
            int counter = 0;

            for (int i = startWeek; startWeek <= endWeek; i++)
            {
                string textOut = string.Format($"{startWeek,2}");
                int columns = 4;

                Console.Write($" Week {textOut}  ");
                counter++;

                if ((counter % columns == 0) && (counter >= columns))
                {
                    Console.WriteLine();
                }
                startWeek += intervals;
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
