using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComarchZadania.CarSharing
{
    public abstract class Auto
    {
        protected int accualGasState;

        public int Id { get; set; }

        public bool IsBorrowed { get; set; }

        public string Maker { get; set; }

        public string Model { get; set; }

        public abstract void ShareCar();

        public void TankCar(int count)
        {
            accualGasState += count;
        }
    }

    public class Car : Auto
    {
        public CarTypes CarType { get; set; }

        public override void ShareCar()
        {
            Console.WriteLine("Jakie chcesz auto: ");
            Console.WriteLine(" 1: Małe");
            Console.WriteLine(" 2. Średnie");
            Console.WriteLine(" 3. Duże");
            Console.Write("Wybór: ");

            CarType = (CarTypes)int.Parse(Console.ReadLine());

            IsBorrowed = true;
        }


        public enum CarTypes
        {
            Small = 1,
            Medium,
            Large,
        }
    }


    public class Bus : Car
    {
        public int SeatsCount { get; set; }

        public override void ShareCar()
        {
            Console.WriteLine("Podaj pojemność autobusu: ");
            SeatsCount = int.Parse(Console.ReadLine());

            IsBorrowed = true;
        }
    }

    public class Truck : Car
    {
        public int Capacity { get; set; }

        public override void ShareCar()
        {
            Console.WriteLine("Podaj ładowność ciężarówki: ");
            Capacity = int.Parse(Console.ReadLine());

            IsBorrowed = true;
        }
    }

}
