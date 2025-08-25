using System;

class Test
{
    static void Main(string[] args)
    {
        string[] testInputs = { "abc", "", "123", "12.5", "-50", "999999999999999" };

        foreach (var input in testInputs)
        {
            Console.WriteLine($"\nTesting input: \"{input}\"");
            try
            {
                InputProcess.Process(input);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Handled in Test.cs → {ex.Message}");
            }
        }
    }
}
