using System;

namespace ReverseArray
{
    internal class SolutionSlidingWindow
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 2, 1, 7, 3, 10, 1, 2, 11, 15, 4, 3 };
            Console.WriteLine(BadSolution(arr1,20));

            int[] arr2 = new int[] { 2, 1, 7, 3, 10, 1, 2, 11, 15, 4, 3 };
            Console.WriteLine(GoodSolution(arr2, 20));
        }

        static int BadSolution(int[] array, int targer)
        {
            int ans = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int j = i;
                int sum = 0;
                while(j<array.Length && sum + array[j] <= targer)
                {
                    sum += array[j++];
                }
                ans = Math.Max(ans, j - i);
            }

            return ans;
        }

        static int GoodSolution(int[] array, int target)
        {
            int ans = 0;
            int left = 0, right = 0;
            int current = 0;
            while (right < array.Length)
            {
                current += array[right++];
                while (current > target)
                    current -= array[left++];

                ans = Math.Max(ans, right - left);
            }

            return ans;
        }
    }
}