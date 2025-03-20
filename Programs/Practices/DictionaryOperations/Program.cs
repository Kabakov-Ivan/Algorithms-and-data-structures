// Программа создаёт словарь, добавляет в него три элемента,
// проверяет наличие одного из них, удаляет его и выводит оставшиеся данные.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Создаем пустой словарь
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        // Заполняем словарь тремя элементами
        dictionary.Add("apple", 1);
        dictionary.Add("banana", 2);
        dictionary.Add("cherry", 3);

        // Проверяем, есть ли элемент с ключом "banana" в словаре
        string keyToCheck = "banana";
        if (dictionary.ContainsKey(keyToCheck))
        {
            Console.WriteLine($"Элемент с ключом '{keyToCheck}' найден. Значение: {dictionary[keyToCheck]}");
        }
        else
        {
            Console.WriteLine($"Элемент с ключом '{keyToCheck}' не найден.");
        }

        // Удаляем элемент с ключом "banana" из словаря
        string keyToRemove = "banana";
        if (dictionary.Remove(keyToRemove))
        {
            Console.WriteLine($"Элемент с ключом '{keyToRemove}' успешно удален.");
        }
        else
        {
            Console.WriteLine($"Элемент с ключом '{keyToRemove}' не найден, удаление не выполнено.");
        }

        // Выводим оставшиеся элементы словаря
        Console.WriteLine("Оставшиеся элементы в словаре:");
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}