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

            Console.Write("Podaj pozycję menu: ");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.Write("Podaj x: ");
                    string liczbaXstring = Console.ReadLine();

                    Console.Write("Podaj y: ");
                    string liczbaYstring = Console.ReadLine();

                    string sumaString = liczbaXstring + liczbaYstring;

                    int liczbaX = 0;
                    int liczbaY = 0;

                    if (int.TryParse(liczbaXstring, out liczbaX)
                        && int.TryParse(liczbaYstring, out liczbaY))
                    {
                        int wynik = liczbaX + liczbaY;
                        Console.WriteLine($"Suma liczb {liczbaXstring} oraz {liczbaYstring} to {wynik}");
                    }
                    else
                    {
                        Console.WriteLine("Błędna liczba");
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    ArrayOperations.ArrayInitialTask();
                    break;
                default:
                    break;
            }



            Console.ReadLine();
        }
    }
}