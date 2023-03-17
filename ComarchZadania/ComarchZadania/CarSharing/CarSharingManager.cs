using System;
using System.Collections.Generic;
using System.IO;
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
                    case 4:
                        SaveFile();
                        break;
                    case 5:
                        ReadFile();
                        break;
                }

                Console.ReadLine();
            } while (true);
        }

        private void ReadFile()
        {
            throw new NotImplementedException();
        }

        private void SaveFile()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Auto auto in carList)
            {
                string type = string.Empty;
                sb.Append(auto.Id).Append(";");
                sb.Append(auto.IsBorrowed).Append(";");
                sb.Append(auto.Maker).Append(";");
                sb.Append(auto.Model).Append(";");
                
                if (auto is Car)
                {
                    sb.Append(((Car)auto).CarType); ;
                    type = nameof(Car);
                }
                sb.Append(";");

                if (auto is Truck)
                {
                    sb.Append(((Truck)auto).Capacity);
                    type = nameof(Truck);
                }
                sb.Append(";");

                if (auto is Bus)
                {
                    sb.Append(((Bus)auto).SeatsCount);
                    type = nameof(Bus);
                }
                sb.Append(";");
                sb.Append(type).AppendLine(";");
            }

            File.WriteAllText("carSharingDb.csv",sb.ToString());
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
            Console.WriteLine(" 4. Zapisz do pliku");
            Console.WriteLine(" 5. Odczytaj plik");
            Console.WriteLine(" 0. Wyjdź");
        }
    }
}
