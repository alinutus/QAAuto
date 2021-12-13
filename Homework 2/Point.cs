using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Point
    {
        string City;
        int CoordinateX;
        int CoordinateY;

        public Point(string ci, int x, int y)
        {
            City = ci;
            CoordinateX = x;
            CoordinateY = y;
        }

        public string Print()
        {
            //return $"{City} Coordinate X-{CoordinateX} Coordinate Y-{CoordinateY}";
            return City + " " + "Coordinate X-" + " " + CoordinateX + " " + "Coordinate Y-" + CoordinateY;
        }
    }
}
