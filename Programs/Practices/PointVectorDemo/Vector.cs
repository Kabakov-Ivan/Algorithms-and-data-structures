using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public struct Vector
    {
        public Point beggining;
        public Point end;

        public Vector(Point beggining, Point end)
        {
            this.beggining = beggining;
            this.end = end;
        }

        public Vector(double x1, double y1, double x2, double y2)
        {
            beggining = new Point(x1, y1);
            end = new Point(x2, y2);
        }

        private double lenhth;
        public double Lenght
        {
            get
            {
                return lenhth;
            }
            private set
            {
                lenhth = Math.Sqrt(Math.Pow(end.x - beggining.x, 2)
                    + Math.Pow(end.y - beggining.y, 2));

            }
        }
    }
}
