using System;

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

        public static void Sortowanie()
        {
            Console.Clear();
            Console.Write("Podaj liczby rozdzielone spacją: ");
            string[] sLiczby = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int[] liczby = new int[sLiczby.Length];
            int i = 0;
            foreach (var item in sLiczby)
            {
                liczby[i] = int.Parse(item);
                i++;
            }

            int n = liczby.Length;

            for (i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (liczby[j] > liczby[j + 1])
                    {
                        int tmp = liczby[j];
                        liczby[j] = liczby[j + 1];
                        liczby[j + 1] = tmp;
                    }
                }
            }

            Console.WriteLine("Posortowane wartości: " + string.Join(", ", liczby));
        }
    }
}