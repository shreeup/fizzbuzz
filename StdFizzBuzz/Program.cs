// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
        // int row = 0;

        // do
        // {
        //     if (row == 0 || row >= 25)
        //         ResetConsole();

        //     string? input = Console.ReadLine();
        //     if (string.IsNullOrEmpty(input)) break;
        //     Console.WriteLine($"Input: {input}");
        //     Console.WriteLine("Begins with uppercase? " +
        //          $"{(input.StartsWithUpper() ? "Yes" : "No")}");
        //     Console.WriteLine();
        //     row += 4;
        // } while (true);
        // return;

        // // Declare a ResetConsole local method
        // void ResetConsole()
        // {
        //     if (row > 0)
        //     {
        //         Console.WriteLine("Press any key to continue...");
        //         Console.ReadKey();
        //     }
        //     Console.Clear();
        //     Console.WriteLine($"{Environment.NewLine}Press <Enter> only to exit; otherwise, enter a string and press <Enter>:{Environment.NewLine}");
        //     row = 3;
        // }

        Console.Clear();
            Console.WriteLine($" This program print standard FizzBuzz to console  - {Environment.NewLine}");
           
         
            List<string> resultofFizzBuzz=new TwistedFizzBuzz().FizzBuzzForRange(0,100);
            foreach(string s in resultofFizzBuzz){
                Console.WriteLine(s);
            }
            return;
    }
}