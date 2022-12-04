using System;

class Program {
    public static void Main()
    {
        Console.Write("Program running");
        Console.WriteLine();
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());


        do
        {
            x = x - 1;
            y = y - 1;
            Console.Write('C');
        } while (y > 0);
        if (x > 0)
        {
            if (y < 0) 
            {
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
