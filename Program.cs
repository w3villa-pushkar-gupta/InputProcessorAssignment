using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        string userInput = Console.ReadLine();

        try
        {
            if (userInput is null)
            {
                throw new ArgumentNullException(nameof(userInput), "Input cannot be null.");
            }
            InputProcess.Process(userInput);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Sorry, something went wrong with your input.");
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
