using System.ComponentModel.Design;

class TempConverter
{
    public static void Main(string[] args)
    {
        bool retry = true;
        while (retry)
        {

            Console.WriteLine("What temperature scaler are you using? (Celsius, Farenheit, Kelvin)");
            string? userScale = Console.ReadLine();

            Console.WriteLine("What is the temperature number?: ");
            string? userNumber = Console.ReadLine();
            double.TryParse(userNumber, out double temperature);
            Console.WriteLine("Which temperature scale would you like?\n(Celsius, Farenheit, Kelvin)");
            string? userConvert = Console.ReadLine();

            /* To convert temperatures in degrees Celsius to Fahrenheit, multiply by 1.8 (or 9/5) and add 32. Example: (30°C x 1.8) + 32 = 86°F'. */
            /* The conversion of Celsius to Kelvin: Kelvin = Celsius + 273.15.*/


            if (userScale == "Celcius")
            {
                if (userConvert == "Farenheit")
                {
                    double Farenheit = temperature * 1.8 + 32;
                    Console.WriteLine($"The Farenheit conversion is {Farenheit} degrees");
                }
                else if (userConvert == "Kelvin")
                {
                    double Kelvin = temperature + 273.15;
                    Console.WriteLine($"The Kelvin conversion is {Kelvin} degrees");
                }
                /* Fahrenheit to Celsius = (Fahrenheit - 32) / 1.8 */
                /* Fahrenheit to Kelvin = (Fahrenheit - 32) * 5 / 9 + 273.15 */

            }
            else if (userScale == "Farenheit")
            {
                if (userConvert == "Celcius")
                {
                    double Celcius = (temperature - 32) / 1.8;
                    Console.WriteLine($"The Celcius conversion is {Celcius}");
                }
                else if (userConvert == "Kelvin")
                {
                    double Kelvin = (temperature - 32) * 5 / 9 + 273.15;
                    Console.WriteLine($"The Kelvin conversion is {Kelvin}");
                }
            }
            /* Kelvin to Celcius = Kelvin - 273.15 */
            /* Farenheit to Kelvin = (Kelvin - 273.15) x 1.8 + 32 */

            else if (userScale == "Kelvin")
            {
                if (userConvert == "Celcius")
                {
                    double Celcius = temperature - 273.15;
                    Console.WriteLine($"The Celcius concersion is {Celcius}");
                }
                else if (userConvert == "Farenheit")
                {
                    double Farenheit = (temperature - 32) * 1.8 + 32;
                    Console.WriteLine($"The Farenheit conversion is {Farenheit}");
                }
                else
                    Console.WriteLine("You did not enter correct information, please try again.");
            }

            Console.WriteLine("Would you like to convert another scale?\nyes or no");
            string? userReply = Console.ReadLine();
            if (userReply == "no")
            {
                retry = false;
            }
        }
    }
}