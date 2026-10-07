using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_вектора
{
    public struct Vector
    {
        public Point Start;
        public Point End;

        public Vector(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public static Vector CreateVector(Point start, Point end)
        {
            return new Vector(start, end);
        }

        public static bool IsEquals(Vector v1, Vector v2)
        {
            return v1.Start.X_ == v2.Start.X_ &&
                   v1.Start.Y_ == v2.Start.Y_ &&
                   v1.End.X_ == v2.End.X_ &&
                   v1.End.Y_ == v2.End.Y_;
        }
    }
}
