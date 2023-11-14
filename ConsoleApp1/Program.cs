using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
namespace ConsoleApp1;
internal class Program
{
    // Constant - Value cannot be changed or modified. It is set in Compiling, not runtime.
    const double bananasize = 18;

    // Static void Main is run at program startup. string[] args is used to
    // intercept cli commands.
    static void Main(string[] args)
    {
        // Small method that sets up the color and size. 
        SetupGui();

        // Writes out the commandline interface (CLI) coammands.
        // Foreach is one of the loops together with For, While and Do While.
        foreach (var arg in args)
        {
            Console.WriteLine(arg);
        }

        // Infinite loop (while(true)) There should ALWAYS be an exit
        // strategy to exit a program.
        while(true)
        {
            StartHere();
            Console.WriteLine("Try again (Y/N)");
            if(Console.ReadKey().Key == ConsoleKey.N)
            {
                //Environment.Exit(0);
                break;
            }
            Console.Clear();
        }
        /// <summary>
        /// Our main method in the bananaconverter
        /// </summary>
        static void StartHere()
        {
            Console.WriteLine("Convert Banana to cm.");
            Console.Write("Indtaste mængde af banana:");
            double amountbanana = GetInput();
            double result = ConvertToCm(amountbanana);
            ShowResult(amountbanana, result);
        }

        /// <summary>
        /// Gets User input andd converts to double
        /// </summary>
        /// <returns></returns>
        static double GetInput()
        {
            double amount;
            // TryParse returns a bool. True if it can parse the string value,
            // otherwise false. Since WHILE runs if true we false
            // the method with logical NOT operator (!), os it becomes true
            // if not possible to convert, thus continuing the loop.
            while (!double.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Error. Try again.");
            }
            return amount;
        }

        /// <summary>
        /// Simple calculation that multiplies amount of banana with standard banana size.
        /// </summary>
        /// <param name="banana"></param>
        /// <returns>size in cm.</returns>
        static double ConvertToCm(double banana)
        {
            return bananasize * bananasize; 
        }

        /// <summary>
        /// Prints out the result in console.
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="result"></param>
        static void ShowResult(double amountbanana, double result)
        {
            //String interpolation examples
            //Console.WriteLine("{0} banana equals {1} cm. with a standard size of banana equal {2}", amountbanana, result, bananasize);
            string s2 = $"{amountbanana} banana equals {result} cm. with a standard size of banana equal {bananasize}";
            Console.WriteLine(s2);
        }
    }

    private static void SetupGui()
    {
        Console.SetWindowSize(30, 10);
        Console.SetBufferSize(30, 10);
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
    }
}