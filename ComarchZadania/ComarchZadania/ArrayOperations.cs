using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComarchZadania
{
    public class ArrayOperations
    {
        public static void ArrayInitialTask()
        {
            Console.Clear();
            Console.WriteLine("Podaj elementy tablicy");
            string inputData = Console.ReadLine();
            string[] dataArray = inputData.Split(' ');

            Console.WriteLine("Twoja tablica to: ");

            int i = 0;
            foreach (string item in dataArray)
            {
                if (item == "0")
                {
                    dataArray[i] = "??";
                }

                i++;
            }

            foreach (var item in dataArray)
            {
                Console.WriteLine($"[{item}]");
            }

            Console.ReadLine();
        }
    }
}
