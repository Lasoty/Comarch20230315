using ComarchZadania.CarSharing;
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
            Console.WriteLine(" 2. Odejmowanie");
            Console.WriteLine(" 3. Mnożenie");
            Console.WriteLine(" 4. Dzielenie");
            Console.WriteLine(" 5. Modulo");
            Console.WriteLine(" 6. Tablice");
            Console.WriteLine(" 7. Sortowanie tablicy");
            Console.WriteLine(" 8. Wypożyczalnia");

            Console.Write("Podaj pozycję menu: ");

            if (!int.TryParse(Console.ReadLine(), out int menu))
            {
                Console.WriteLine("Nieprawidłowy wybór");
                Console.ReadLine();
                return;
            }
            Calculator calculator = new Calculator();



            int liczbaX;
            int liczbaY;
            float wynik = 0;

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

                    try
                    {
                        wynik = calculator.Divide(liczbaX, liczbaY);
                        Console.WriteLine($"Wynik dzielenia {liczbaX} oraz {liczbaY} to {wynik}.");
                    }
                    catch (DivideByZeroException ex)
                    {
                        ShowError("Pamiętaj holero! Nie dziel przez zero!");
                    }
                    catch (Exception ex)
                    {
                        ShowError("Wystąpił problem z aplikacją");
                    }

                    break;
                case 5:
                    break;
                case 6:
                    ArrayOperations.ArrayInitialTask();
                    break;
                case 7:
                    ArrayOperations.Sortowanie();
                    break;
                case 8:
                    CarSharingManager carManager = new CarSharingManager();
                    carManager.Run();
                    break;
                default:
                    break;
            }



            Console.ReadLine();
        }

        private static void ShowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
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