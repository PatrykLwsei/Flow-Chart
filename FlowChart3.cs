using System;
using System.Diagnostics.Eventing.Reader;
using System.Xml;

namespace FlowChart
{
    internal class Program
    {
        public static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            for (int i = 0; x > 0 && y > 0; i++)
            {
                x = x - 1;
                y = y - 1;
                Console.Write("C");
            }
            if (x > 0 && y <= 0)
            {
                Console.Write("D");
                if (z > 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.Write('G');
                }
            }
            else
            {
                Console.Write("E");
                Console.Write("G");
                Console.WriteLine();
            }
        }
    }
}


/*
1 2 3 = CEG
-2 0 2 = EG
1 -1 2 = D
2 2 0 = CCEG
5 3 0 = CCCDG
*/
