// Написать метод класса, который на вход получает массив положительных целых
// чисел и положительное целое число targer. Вернуть минимальную длину подмассива,
// сумма которых больше либо равна targer. Если такого подмассива нет, то вернуть 0.

// Пример 1: targer = 7[2, 3, 1, 2, 4, 3] - выведет - 2
// Пример 2: targer = 4[1, 4, 4] - выведет - 1
// Пример 3: targer = 11 х[1, 4, 4] - выведет - 0

using System;

class Program
{
    public static int MinSubArrayLen(int target, int[] nums)
    {
        int minLength = int.MaxValue;
        int left = 0;
        int sum = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            sum += nums[right];

            while (sum >= target)
            {
                minLength = Math.Min(minLength, right - left + 1);
                sum -= nums[left];
                left++;
            }
        }

        return minLength == int.MaxValue ? 0 : minLength;
    }

    static void Main(string[] args)
    {
        int target = 7;
        int[] nums = { 2, 3, 1, 2, 4, 3 };
        Console.WriteLine(MinSubArrayLen(target, nums));
    }
}