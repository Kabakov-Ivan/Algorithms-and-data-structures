// Написать метод класса, который на вход получает отсортированный по
// неубыванию массив целых чисел и целое число target. Метод возвращения
// массива из двух элементов находящихся в этом массиве, сумма которых равна targer.
// Если таких элементов нет, то возв

// Пример 1: 
// массив = (-10, -2, 0, 3, 6, 12, 20)
// target = 1
// вернет: [-2,3]

// Пример 2: 
// массив = (-10, -2, 0, 3, 6, 12, 20)
// target = -1
// вернет: []

using System;

class Program
{
    static int[] FindTwoSum(int[] nums, int target)
    {

        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int sum = nums[left] + nums[right];

            if (sum == target) return new int[] { nums[left], nums[right] };
            else if (sum < target) left++;
            else right--;
        }

        return new int[] { };
    }

    static void Main(string[] args)
    {
        int[] array1 = { -10, -2, 0, 3, 6, 12, 20 };
        int target1 = 1;
        int[] result1 = FindTwoSum(array1, target1);
        Console.WriteLine("Пример 1: [" + string.Join(", ", result1) + "]");
    }
}