using System;
namespace HomeTask_5._2.NET
{
    internal class Program
    {
        static int Maximum(int[] mas)
        {
            int max = mas[0];
            foreach (int i in mas)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            Console.Write("Введiть кількість елементів списку: ");
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введіть {i + 1} елемент списку: ");
                mas[i] = int.Parse(Console.ReadLine());
            }
            int maxi = Maximum(mas);
            Console.WriteLine($"Максимальний елемент: {maxi}");
        }
    }
}

