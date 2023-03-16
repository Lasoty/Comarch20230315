using System;
using System.Text.RegularExpressions;

namespace ComarchZadania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KALCULATOR v1.0");
            Console.WriteLine("Podaj opcję menu:");
            Console.WriteLine(" 1. Dodawanie");
            Console.WriteLine(" 6. Tablice");
            Console.WriteLine(" 7. Sortowanie tablicy");

            Console.Write("Podaj pozycję menu: ");
            int menu = int.Parse(Console.ReadLine());
            
            Calculator calculator = new Calculator();
            
            

            int liczbaX;
            int liczbaY;
            int wynik;

            switch (menu)
            {
                case 1:
                    BierzDane(out liczbaX, out liczbaY);

                    wynik = calculator.Add(liczbaX, liczbaY);
                    Console.WriteLine($"Wynik dodawania {liczbaX} oraz {liczbaY} to {wynik}.");
                    break;
                case 2:
                    BierzDane(out liczbaX, out liczbaY);

                    wynik = calculator.Subtract(liczbaX, liczbaY);
                    Console.WriteLine($"Wynik odejmowania {liczbaX} oraz {liczbaY} to {wynik}.");
                    break;
                case 3:
                    BierzDane(out liczbaX, out liczbaY); ;

                    wynik = calculator.Multiply(liczbaX, liczbaY);
                    Console.WriteLine($"Wynik mnożenia {liczbaX} oraz {liczbaY} to {wynik}.");
                    break;
                case 4:
                    BierzDane(out liczbaX, out liczbaY);

                    wynik = calculator.Divide(liczbaX, liczbaY);
                    Console.WriteLine($"Wynik dzielenia {liczbaX} oraz {liczbaY} to {wynik}.");
                    break;
                case 5:
                    break;
                case 6:
                    ArrayOperations.ArrayInitialTask();
                    break;
                case 7:
                    ArrayOperations.Sortowanie();
                    break;
                default:
                    break;
            }



            Console.ReadLine();
        }

        private static void BierzDane(out int liczbaX, out int liczbaY)
        {
            Console.Write("Podaj x: ");
            string liczbaXstring = Console.ReadLine();

            Console.Write("Podaj y: ");
            string liczbaYstring = Console.ReadLine();

            liczbaX = int.Parse(liczbaXstring);
            liczbaY = int.Parse(liczbaYstring);
        }
    }
}