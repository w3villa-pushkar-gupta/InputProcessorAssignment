using System;

public static class InputProcess
{
    public static void Process(string input)
    {
        try
        {
            if (!int.TryParse(input, out int number))
            {
                throw new ArgumentException("Input is not a valid number.");
            }

            Console.WriteLine($"You entered a valid number: {number}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Sorry, something went wrong with your input.");
            LogError(input, ex);
        }
    }

    private static void LogError(string input, Exception ex)
    {
        string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] " +
                          $"Input: {input} | " +
                          $"ErrorType: {ex.GetType().Name} | " +
                          $"Message: {ex.Message}";
        Console.WriteLine(logEntry);
    }
}
