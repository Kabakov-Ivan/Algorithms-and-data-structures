// Программа – это игра “Угадай число”. Компьютер загадывает
// случайное число от 1 до 100, а игрок пытается его угадать,
// получая подсказки (“больше” или “меньше”). Игра повторяется,
// пока пользователь хочет продолжать. В конце выводится статистика:
// минимальное, максимальное и среднее количество попыток за игру.

using System;
using System.ComponentModel.Design;

namespace Game_Guess_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            ConsoleKeyInfo tmp;
            int max = 0;
            int min = 0;
            int attempt = 0;
            int gamesCount = 0;
            do
            {
                int number = random.Next(1, 100);
                gamesCount++;
                int currentAttempt = 0;
                while (true)
                {
                    currentAttempt++;
                    int MysteryNumber = 0;
                    Console.WriteLine("Enter mystery number (1 - 100!)");
                    while (!int.TryParse(Console.ReadLine(), out MysteryNumber)
                        || MysteryNumber < 1 || MysteryNumber > 100)
                        Console.WriteLine("Error, Enter correct number (1;100)");
                    if (MysteryNumber > number)
                        Console.WriteLine("Guess number is less");
                    else if (MysteryNumber < number)
                        Console.WriteLine("Guess number is more");
                    else
                    {
                        Console.WriteLine("You win");
                        break;
                    }
                }
                attempt += currentAttempt;
                min = min == 0 || min > currentAttempt
                    ? currentAttempt
                    : min;
                max = max < currentAttempt ? currentAttempt : max;
                tmp = Console.ReadKey();
            } while (tmp.Key == ConsoleKey.Y);
            Console.WriteLine($"Min = {min}\n" +
                $"Max = {max}\nAvg = {Convert.ToDouble(attempt) / gamesCount}");

        }

    }
}