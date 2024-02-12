namespace MaU_C__Assignment2
{
    internal class TemperatureConverter
    {
        private bool exitApplication = false;

        public void TemperatureConverterStart()
        {
            do
            {
                Console.Clear();
                MainMenu();
            } while (exitApplication == false);
        }

        private void MainMenu()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Main Menu".ToUpper());
            Console.WriteLine("----------");
            Console.WriteLine();
            Console.WriteLine("Pick a number to enter the Temperature Converter");
            Console.WriteLine("\t[1] Convert Fahrenheit to Celsius\n\t[2] Convert Celsius to Fahrenheit\n\t[0] Exit the Converter");
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
                //check for valid user input
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

            switch (menuChoice)
            {
                case 1:
                    FahrenheitToCelcius();
                    break;
                case 2:
                    CelciusToFahrenheit();
                    break;
                case 0:
                    Console.WriteLine("Exiting Converter...");
                    HelperMethods.ConfirmationButton();
                    exitApplication = true;
                    Console.Clear();
                    break;
            }
        }

        //two methods for conversion, adjusting the values, conversion calculations, and display intervals

        private static void FahrenheitToCelcius()
        {
            Console.WriteLine();

            int fahrenheit = 0;
            int counter = 0;
            int columns = 3;

            for (var i = 0; fahrenheit <= 210; i++)
            {
                float celsius = 5f / 9f * (fahrenheit - 32f);
                string textOut = string.Format($"{fahrenheit,16:f2} F = {celsius,6:f2} C");

                Console.Write(textOut);
                counter++;
                if ((counter % columns == 0) && (counter >= columns))
                {
                    Console.WriteLine();
                }
                fahrenheit += 10;
            }
            Console.WriteLine();
            Console.WriteLine();
            HelperMethods.ConfirmationButton();
        }
        private static void CelciusToFahrenheit()
        {
            Console.WriteLine();

            int celsius = 0;
            int counter = 0;
            int columns = 3;

            for (var i = 0; celsius <= 100; i++)
            {
                float fahrenheit = 9f / 5f * celsius + 32f;
                string textOut = string.Format($"{celsius,16:f2} C = {fahrenheit,6:f2} F");

                Console.Write(textOut);
                counter++;
                if ((counter % columns == 0) && (counter >= columns))
                {
                    Console.WriteLine();
                }
                celsius += 5;
            }
            Console.WriteLine();
            Console.WriteLine();
            HelperMethods.ConfirmationButton();
        }
    }
}
