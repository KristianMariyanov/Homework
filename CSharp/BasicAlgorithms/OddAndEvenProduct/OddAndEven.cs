using System;

class OddAndEven
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int oddProduct = 1;
        int evenProduct = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            int number = int.Parse(numbers[i]);
            if (i%2==0)
            {
                oddProduct *= number;
            }
            else
            {
                evenProduct *= number;
            }
        }
        if (evenProduct==oddProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("The product is {0}",oddProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("Odd product is {0}",oddProduct);
            Console.WriteLine("Even product is {0}", evenProduct);
        }

    }
}

