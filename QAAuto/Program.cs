using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            W();
            F();
            For();

            Console.ReadLine();
        }

        private static void W()
        {
            int[] array = new int[10];
            int i = 0;

            while (i < array.Length)
            {
                array [i] = i * 2;
                Console.Write("Method WHILE");
                Console.WriteLine(array[i]);
                i++;
            }
        }
        private static void F()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int i in array)
            {
                var a = i * 2;
                Console.Write("Method FOREACH");
                Console.WriteLine(a);
            }
        }
        private static void For()
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                var m = i * 2;
                Console.Write("Method FOR");
                Console.WriteLine(m);
            }
        }
    }
}
