using System;

namespace ReverseArray
{
    internal class SolutionSlidingWindow
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 5, 1, 7, 8, 3, 1, 2, 12 };
            ReverseArray(arr);
            Console.WriteLine(string.Join(", ", arr));
        }

        static void ReverseArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                // Меняем местами элементы
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                // Сдвигаем указатели
                start++;
                end--;
            }
        }
    }
}