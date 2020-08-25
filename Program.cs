using System;

namespace Brackeys_Csharp_Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Brackeys Story Challenge (Episode 1)";
            Console.WindowHeight = 60;
                    
            Console.WriteLine("Screams could be heard as a ...");
            
            Console.ReadLine();

            Console.WriteLine("... walked into a ...");

            Console.ReadLine();

            Console.WriteLine("... to shelter from the rain lashing down outside.\n'You're all in grave danger!' shouted the ...");

            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            
            Console.WriteLine("But... it was too late!\nA Huge ...");

            Console.ReadLine();

            Console.WriteLine("... ripped off the roof, and devoured everyone in one gulp!");

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("The End!\nPress any button to Continue");
                               
            Console.ReadKey();
        }
    }
}
