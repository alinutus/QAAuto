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
            int[] myArray = new int[10];
            for (int a = 0; a < myArray.Length; a++)
            
            {
                myArray[a] = a * 2;
                Console.WriteLine(myArray[a]);
            }


            foreach (int b in myArray)
            {
                Console.WriteLine(b);
            }


            int m = 0;
            
            
            while (m < myArray.Length)
            {
                  
                int temp = m * 2;
                Console.WriteLine(temp);
                m++;

            }
        }

    }
}
