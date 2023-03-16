using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComarchZadania.CarSharing
{
    public class CarSharingManager
    {
        List<Auto> carList = new List<Auto>();

        public void Run()
        {
            do
            {
                ShowMenu();
                int menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 0:
                        return;
                    case 1:
                        ShowCars();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }

                Console.ReadLine();
            } while (true);
        }

        private void ShowCars()
        {
            if (carList.Count > 0)
            {
                foreach (Auto c in carList)
                {
                    Console.WriteLine($"{c.Id}\t{c.Maker} {c.Model}\t Wypożyczony: {c.IsBorrowed}");
                }
            }
            else { Console.WriteLine("Brak aut."); }

        }

        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Wypożyczalnia aut 1.0");
            Console.WriteLine(" 1. Pokaż auta");
            Console.WriteLine(" 2. Dodaj auto");
            Console.WriteLine(" 3. Wypożycz auto");
            Console.WriteLine(" 0. Wyjdź");
        }
    }
}
