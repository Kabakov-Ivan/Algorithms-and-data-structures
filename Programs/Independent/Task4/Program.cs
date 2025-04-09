// Написать метод класса, который на вход поучает целочисленный двумерный массив
// matches, где каждая строчка matches[i] = [winner, loser], указывает на то что
// игрок winner победил игрока loser в i-ом матче. Метод возвращает два значения:
// массив всех игроков, которые не проиграли ни одного матча.
// список всех игроков, которые проиграли ровно один матч.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[][] matches = new int[][]
        {
            new int[] { 1, 3 },
            new int[] { 2, 3 },
            new int[] { 3, 6 },
            new int[] { 5, 6 },
            new int[] { 5, 7 },
            new int[] { 4, 5 },
            new int[] { 4, 8 },
            new int[] { 4, 9 },
            new int[] { 10, 4 },
            new int[] { 10, 9 }
        };

        var result = GetPlayers(matches);

        Console.WriteLine("Players who never lost a match:");
        Console.WriteLine(string.Join(", ", result.Item1));

        Console.WriteLine("Players who lost exactly one match:");
        Console.WriteLine(string.Join(", ", result.Item2));
    }

    public static Tuple<List<int>, List<int>> GetPlayers(int[][] matches)
    {
        // Словарь для хранения количества поражений у каждого игрока
        Dictionary<int, int> lossCount = new Dictionary<int, int>();

        // Хэш-сет для хранения всех игроков, которые проигрывали хотя бы один матч
        HashSet<int> allLosers = new HashSet<int>();

        // Хэш-сет для хранения всех игроков, которые хотя бы один раз выигрывали
        HashSet<int> allWinners = new HashSet<int>();

        // Обрабатываем каждый матч
        foreach (var match in matches)
        {
            int winner = match[0];
            int loser = match[1];

            // Добавляем игрока в хэш-сет победителей
            allWinners.Add(winner);
            // Добавляем игрока в хэш-сет проигравших
            allLosers.Add(loser);

            // Обновляем количество поражений для проигравшего игрока
            if (!lossCount.ContainsKey(loser))
                lossCount[loser] = 0;
            lossCount[loser]++;
        }

        // Список игроков, которые не проиграли ни одного матча
        List<int> noLosses = new List<int>();
        foreach (var player in allWinners)
        {
            // Если игрок выиграл хотя бы один матч, но не был в хэш-сете проигравших
            if (!allLosers.Contains(player))
                noLosses.Add(player);
        }

        // Список игроков, которые проиграли ровно один матч
        List<int> oneLoss = new List<int>();
        foreach (var player in lossCount)
        {
            if (player.Value == 1)
                oneLoss.Add(player.Key);
        }

        return new Tuple<List<int>, List<int>>(noLosses, oneLoss);
    }
}