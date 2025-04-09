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

        Console.WriteLine("Игроки, которые не проиграли ни одного матча:");
        Console.WriteLine(string.Join(", ", result.Item1));

        Console.WriteLine("Игроки, которые проиграли ровно один матч:");
        Console.WriteLine(string.Join(", ", result.Item2));
    }

    public static Tuple<List<int>, List<int>> GetPlayers(int[][] matches)
    {
        // Словарь: игрок - количество поражений
        Dictionary<int, int> losses = new Dictionary<int, int>();

        // Хэш-сет всех победителей
        HashSet<int> winners = new HashSet<int>();

        // Обработка матчей
        foreach (var match in matches)
        {
            int winner = match[0];
            int loser = match[1];

            winners.Add(winner);

            if (!losses.ContainsKey(loser))
                losses[loser] = 0;

            losses[loser]++;
        }

        // Список игроков, которые не проигрывали
        List<int> noLoss = new List<int>();

        foreach (int player in winners)
        {
            if (!losses.ContainsKey(player))
                noLoss.Add(player);
        }

        // Список игроков, проигравших ровно один матч
        List<int> oneLoss = new List<int>();

        foreach (var kvp in losses)
        {
            if (kvp.Value == 1)
                oneLoss.Add(kvp.Key);
        }

        // Сортировка для стабильного вывода
        noLoss.Sort();
        oneLoss.Sort();

        return Tuple.Create(noLoss, oneLoss);
    }
}
