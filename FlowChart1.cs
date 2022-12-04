using System;

namespace FlowChart
{
    internal class Program
    {
        public static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            
            beginning:
            if (x > 0)
            {
                if (y > 0)
                {
                    x = x - 1;
                    y = y - 1;
                    Console.Write("C");
                    goto beginning;
                } 
                else {
                    Console.Write("D");
                }
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