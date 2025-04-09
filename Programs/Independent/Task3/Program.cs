// Панграмма (с греч. - «все буквы»), или разнобуквица, - короткий текст,
// использующий все буквы алфавита, каждая буква встречается один раз.
// Написать метод класса, который на вход принимает строку, состоящую из букв
// латинского алфавита (помните, что есть аски код и каждой букве соответствует число)
// Метод возвращает true, если входная строка - панграмма, иначе false.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string input = "qwertYUIOOPAaaaSDFGHJKLZzxcvvbNm";
        Console.WriteLine(CheckSimvol(input));

        input = "TYughhhfa";
        Console.WriteLine(CheckSimvol(input));
    }


    static bool CheckSimvol(string str)
    {
        if (string.IsNullOrEmpty(str)) return false;
        HashSet<char> letters = new HashSet<char>();

        foreach (char ch in str.ToLower())
        {
            if (char.IsLetter(ch))
                letters.Add(ch);
        }

        return letters.Count == 26;
    }
}