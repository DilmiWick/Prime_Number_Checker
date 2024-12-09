using System;
class Program
{
    static void Main()
    {
        Console.Write("Hey, Enter Your Number: ");
        string? input = Console.ReadLine();

        // Check null inputs
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Input is empty or null. Please enter a valid number.");
            return;
        }

        if (int.TryParse(input, out int userInput)) // Handle invalid inputs
        {
            bool primeChecker = primeCheckerFunc(userInput);
            if(primeChecker)
            {
                Console.WriteLine($"{userInput} is a PRIME NUMBER!");
            }
            else
            {
                Console.WriteLine($"{userInput} is NOT a prime number!");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid integer.");
        }

        Console.WriteLine("The End! Tack!");
    }

    static bool primeCheckerFunc(int number)
    {
        if(number <= 1)
        {
            return false;
        }
        else if(number == 2 || number == 3)
        {
            return true;
        }
        if(number % 2 == 0 || number % 3 == 0)
        {
            return false;
        }
        
        for(int i = 5; i * i <= number; i+=6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }

        return true;

    }

}
