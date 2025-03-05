using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[14];

            InPut("Введите элемент массива ", mas);
            int evenCount = Count(mas);
            Console.WriteLine($"Количество чётных элементов: {evenCount}");
            Console.ReadKey();
        }

        static void InPut(string message, int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(message);
                Console.Write($"mas[{i}]: ");
                mas[i] = int.Parse(Console.ReadLine());
            }
        }
        static int Count(int[] mas)
        {
            int count = 0;
            foreach (int element in mas)
            {
                if (element % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
