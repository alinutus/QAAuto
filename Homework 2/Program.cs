using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)

        {
            Point city1 = new Point("Minsk", 53, 27);
            Point city2 = new Point("Warsaw", 52, 21);
            Point city3 = new Point("Vilnius", 54, 25);
            Point city4 = new Point("Wroclaw", 51, 17);
            Point city5 = new Point("New York", 40, -73);
            Point city6 = new Point("Berlin", 52, 13);
            Point city7 = new Point("Washington", 46, -123);
            Point city8 = new Point("London", 51, -0);
            Point city9 = new Point("Paris", 48, 2);
            Point city10 = new Point("Copenhagen", 55, 12);

            Point[] cities = { city1, city2, city3, city4, city5, city6, city7, city8, city9, city10 };

            //Point[] cities =
            //{
            //    new Point("Minsk", 53, 27),
            //    new Point("Warsaw", 52, 21),
            //    new Point("Vilnius", 54, 25),
            //    new Point("Wroclaw", 51, 17),
            //    new Point("New York", 40, -73),
            //    new Point("Berlin", 52, 13),
            //    new Point("Washington", 46, -123),
            //    new Point("London", 51, -0),
            //    new Point("Paris", 48, 2),
            //    new Point("Copenhagen", 55, 12)
            //};

            foreach (Point po in cities)
            {
                Console.WriteLine(po.Print());
            }
        }
    }
}