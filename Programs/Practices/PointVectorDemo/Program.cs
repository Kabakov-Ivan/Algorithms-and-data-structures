// Программа создает точки и векторы на плоскости, выводит их координаты,
// определяет четверти и проверяет, находятся ли точки в одной четверти,
// а также рассчитывает длину вектора.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point_a = new Point();
            Point point_b = new Point(2, 4);
            Console.WriteLine(point_a.ToString());
            Console.WriteLine(point_b.ToString());
            bool a = point_b.IsSameQuarter(point_a);
            int b = point_a.GetQuarter();
            int c = point_b.GetQuarter();
            Console.WriteLine($"a = {a} b = {b} c = {c}");
            Vector vector = new Vector();
            Console.WriteLine(vector.beggining);
            Console.WriteLine(vector.end);
            Console.WriteLine(vector.Lenght);
        }
    }
}