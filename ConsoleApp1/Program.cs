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
    const double bananasize = 18;
    static void Main(string[] args)
    {
        SetupGui();
        while(true)
        {
            StartHere();
            Console.WriteLine("Try again (Y/N)");
            if(Console.ReadKey().Key == ConsoleKey.N)
            {
                break;
            }
            Console.Clear();
        }

        static void StartHere()
        {
            Console.WriteLine("Convert Banana to cm.");
            Console.Write("Indtaste mængde af banana:");
            double amountbanana = GetInput();
            double result = ConvertToCm(amountbanana);
            ShowResult(amountbanana, result);
        }

        static double GetInput()
        {
            double amount;
            while (!double.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Error. Try again.");
            }
            return amount;
        }

        static double ConvertToCm(double banana)
        {
            return bananasize * bananasize; 
        }

        static void ShowResult(double amountbanana, double result)
        {
            Console.WriteLine(amountbanana + " banana equals " + result + " cm. with a standard size of banana equal " + bananasize);
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