using System;

namespace PayrollCalculator
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 10);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            PrintReverse(array, array.Length - 1);
        }

        static void PrintReverse(int[] arr, int index)
        {
            if (index < 0) return; // Базовый случай: достигли начала массива
            Console.WriteLine(arr[index]); // Вывод текущего элемента
            PrintReverse(arr, index - 1); // Рекурсивный вызов для предыдущего элемента
        }
            
        }
}