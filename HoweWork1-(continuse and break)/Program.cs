using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 0;

        while (i < 5)
        {
            Console.WriteLine($"Outer loop iteration {i}");

            i++;

            int j = 0;
            while (j < 3)
            {
                if (j % 2 == 0)
                {
                    j++;
                    continue;
                }
                if (i >= 3)
                {
                    break; 
                }

                Console.WriteLine($"Inner loop iteration {j}");
                j++;
            }
        }

        Console.WriteLine("Program has ended.");
    }
}

