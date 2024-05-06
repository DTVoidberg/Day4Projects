
class LeapYearChecker
{
    public static void Main(String[] args)
    {
        bool retry = true;
        while (retry)
        {


            Console.WriteLine("Please enter a year: ");
            string? userYear = Console.ReadLine();
            var valid = int.TryParse(userYear, out var year);
            if (!valid)
            {
                Console.WriteLine("error");
                return;
            }

            bool isDivisibleByFour = year % 4 == 0;
            bool isDivisibleByHundred = year % 10 == 0;
            bool isDivisibleByFourHundred = year % 400 == 0;

            /* This is how the Gregorian calendar calculates leap years: 
             * If the year is divisible by four, it's a leap year. 
             * But if the year can be divided by 100 as well as four, 
             * it's not a leap year.However, if the year is divisible by 400, it is a leap year */

            string leapYear = isDivisibleByFour ?
                "This is a leap year" : isDivisibleByHundred ?
                "This is not a leap year" : isDivisibleByFourHundred ?
                "This is a Leap Year!" : "This is not a Leap Year";

            Console.WriteLine(leapYear);

            Console.WriteLine("Would you like to try again?:\ny or n");
            string? userReply = Console.ReadLine();
            if (userReply == "n") 
            {
                retry = false;
            }
        }
    }
}