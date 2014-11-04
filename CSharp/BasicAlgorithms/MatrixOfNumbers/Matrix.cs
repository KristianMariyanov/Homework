using System;

class Matrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            
            for (int k = i; k < n+i; k++)
            {
                Console.Write(k);
            }
            Console.WriteLine();
            
        }
    }
}

