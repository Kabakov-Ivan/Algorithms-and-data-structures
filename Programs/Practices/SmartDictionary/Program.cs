// Пример 1:1 Сумма двух
// Учитывая массив целых чисел nums и целое число target,
// верните индексы двух чисел, сумма которых равна target
// Нельзя использовать один и тот же индекс дважды

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { 2, -4, 5, 5, 10, 0, 7 };
        int[] answer = SumOfTwo(arr, 6);
        if (answer != null)
            Console.WriteLine(answer[0] + " " + answer[1]);
        else
            Console.WriteLine("Таких нет!");

        if (TryGetFirstDuplicate(" a sfd", out char ch))
            Console.WriteLine($"Первый символ, который встречается дважды '{ch}'");
        else Console.WriteLine("Все символы униальны" + ch);

        Console.WriteLine("Result: " + MaxKSubstring("abbuifudhjgu", 2));
    }

    static int[] SumOfTwo(int[] nums, int target)
    {
        // if (nums == null) return null;
        // Ключ - значение элемента, а значение - это индекс элемента
        Dictionary<int, int> pairs = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) // Была ошибка в условии цикла (1 < nums.Length)
        {
            int key = target - nums[i];
            if (pairs.TryGetValue(key, out int value))
                return new int[] { value, i };

            if (!pairs.ContainsKey(nums[i]))
                pairs.Add(nums[i], i); // Была ошибка - добавляли индекс как ключ и значение
        }

        return null;
    }

    // Пример 2: 2351. Первая буква должна появиться дважды
    // Учитывая строку s, верните первый символ, 
    // который встречается дважды.
    static bool TryGetFirstDuplicate(string s, out char value)
    {
        value = '\0';
        if (string.IsNullOrEmpty(s)) return false;

        HashSet<char> charcters = new HashSet<char>();

        foreach (char ch in s)
        {
            if (charcters.Contains(ch))
            {
                value = ch;
                return true;
            }
            charcters.Add(ch);
        }

        return false;
    }
    
    // Пример 3. Вам дана строка s и целое число к.
    // Найдите длину самой длинной подстроки, // содержащей не более k различных символов.
    // Например, если даны 5 = "eceba" и k = 2, верните 3.
    // Самая длинная подстрока,
    // содержащая не более 2 различных символов, - "есе" .
    static int MaxKSubstring(string s, int k)
    {
        if (String.IsNullOrEmpty(s) || k <= 0) return -1;
        if (s.Length < k) return s.Length;

        Dictionary<char, int> pairs = new Dictionary<char, int>();
        int left = 0, right = 0, max = 0;
        for (; right < s.Length; right++)
        {
            char rightKey = s[right];
            if (pairs.ContainsKey(rightKey))
                pairs[rightKey]++;
            else
            {
                pairs[rightKey] = 1;
                max = Math.Max(max, right - left);
            }

            for (; pairs.Count > k; left++)
            {
                char leftKey = s[left];
                pairs[leftKey]--;
                if (pairs[leftKey] == 0)
                    pairs.Remove(leftKey);

            }

            return max;
        }

    }

}