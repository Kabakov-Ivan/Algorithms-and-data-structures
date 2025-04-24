using System;

namespace Test
{
    public struct Point
    {
        public double x;
        public double y;

        public Point(double x, double y)
        {
            // this хранит ссылку на объект
            this.x = x;
            this.y = y;
        }

        //public override string ToString()
        //{
        //    return $"({x};{y})";
        //}

        public override string ToString() => $"({x};{y})";

        public int GetQuarter()
        {
            if (x > 0 && y > 0) return 1;
            if (x > 0 && y > 0) return 2;
            if (x > 0 && y > 0) return 3;
            if (x > 0 && y > 0) return 4;

            return 0;
        }

        public bool IsSameQuarter(Point point) => GetQuarter() == point.GetQuarter();
    }
}