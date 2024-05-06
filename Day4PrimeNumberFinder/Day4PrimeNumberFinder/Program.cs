using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class PrimeNumberFinder
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Up to which number to search for Prime Numbers?:");
        string? userReply = Console.ReadLine();
        int.TryParse(userReply, out int userPrime);
        for (int i = 2; i <= userPrime; i++)
        {
            if (IsPrimeNumber(i))
            {
                Console.WriteLine($"{i} is a Prime Number");
            }
            else
            {
                Console.WriteLine($"{i} is not a Prime Number");
            }
        }



    }
    public static bool IsPrimeNumber(int prime)
    {
        if (prime <= 1) return false;
        if (prime == 2) return true;
        if (prime % 2 == 0) return false;

        var number2 = (int)Math.Floor(Math.Sqrt(prime));

        for (int i = 3; i <= number2; i += 2)
            if (prime % i == 0)  
                return false;

        return true;
    }
}
