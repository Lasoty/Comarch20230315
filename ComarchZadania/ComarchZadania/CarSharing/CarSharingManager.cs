﻿using System;
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
                        AddAuto();
                        break;
                    case 3:
                        ShareOwnCar();
                        break;
                }

                Console.ReadLine();
            } while (true);
        }

        private void ShareOwnCar()
        {
            Console.Write("Podaj id auta: ");
            Auto auto = FindAuto(int.Parse(Console.ReadLine()));

            if (auto != null) 
            {
                auto.ShareCar();
            }
            else
            {
                Console.WriteLine("Nie ma takiego auta");
            }
        }

        private Auto FindAuto(int id)
        {
            Auto auto = carList.FirstOrDefault(auto => auto.Id == id);
            return auto;
        }

        private void AddAuto()
        {
            Console.Clear();
            Console.WriteLine("Jakie chcesz dodać auto: ");
            Console.WriteLine(" 1. Osobowe");
            Console.WriteLine(" 2. Ciężarowe");
            Console.WriteLine(" 3. Bus");

            switch (Console.ReadLine())
            {
                case "1":
                    AddCar();
                    break;
                case "2":
                    AddTruck();
                    break;
                case "3":
                    AddBus();
                    break;
            }
        }

        private void AddBus()
        {
            Bus bus = new Bus();
            bus.Id = carList.Count + 1;

            Console.Write("Podaj markę: ");
            bus.Maker = Console.ReadLine();

            Console.Write("Podaj model: ");
            bus.Model = Console.ReadLine();

            bus.TankCar(200);

            carList.Add(bus);
        }

        private void AddTruck()
        {
            Truck truck = new Truck();
            truck.Id = carList.Count + 1;
            Console.Write("Podaj markę: ");
            truck.Maker = Console.ReadLine();

            Console.Write("Podaj model: ");
            truck.Model = Console.ReadLine();

            truck.TankCar(250);

            carList.Add(truck);
        }

        private void AddCar()
        {
            Car car = new Car();
            car.Id = carList.Count + 1;
            Console.Write("Podaj markę: ");
            car.Maker = Console.ReadLine();

            Console.Write("Podaj model: ");
            car.Model = Console.ReadLine();

            car.TankCar(50);

            carList.Add(car);
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
