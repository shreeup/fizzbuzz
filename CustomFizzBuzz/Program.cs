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
            
        //     string? input = Console.ReadLine();
        //     if (string.IsNullOrEmpty(input)) break;
        //     Console.WriteLine($"Input: {input}");
        //     List<string> resultofFizzBuzz=FizzBuzzForRange(0,100);
        //     foreach(string s in resultofFizzBuzz){
        //         Console.WriteLine(s);
        //     }
        //     Console.WriteLine();
        //     break;
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
            Console.WriteLine($" This program print Custom FizzBuzz to console  ");
            Console.WriteLine($" Output values from -20 to 127  ");
           
            List<string> resultofFizzBuzz=new TwistedFizzBuzz().FizzBuzzForRange(-20,127);
            foreach(string s in resultofFizzBuzz){
                Console.WriteLine(s);
            }

             Console.WriteLine($" For multiples of 5 print \"Fizz\" ");
           
            resultofFizzBuzz=new TwistedFizzBuzz("Fizz","Fizz",5,5).FizzBuzzForRange(new int[]{5,10,15,20,25,30,35,40,45,50});
            foreach(string s in resultofFizzBuzz){
                Console.WriteLine(s);
            }

            Console.WriteLine($" For multiples of 9 print \"Buzz\" ");
           
            resultofFizzBuzz=new TwistedFizzBuzz("Buzz","Buzz",9,9).FizzBuzzForRange(new int[]{9,18,27,36,45,54,63,72,81,90});
            foreach(string s in resultofFizzBuzz){
                Console.WriteLine(s);
            }

            Console.WriteLine($" For multiples of 27 print \"Bar\" ");
           
            resultofFizzBuzz=new TwistedFizzBuzz("Bar","Bar",27,27).FizzBuzzForRange(new int[]{27, 54, 81, 108, 135, 162, 189, 216, 243,270});
            foreach(string s in resultofFizzBuzz){
                Console.WriteLine(s);
            }

            Console.WriteLine($" For multiples where more than one number from above matches, print the appropriate concatenated tokens ");
           Console.WriteLine("Not clear on requirement");
           
            return;
    }
}