using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter Decimal number");
        int decNum = int.Parse(Console.ReadLine());
        int reminder;
        string result = "";
        while (decNum>0)
        {
            reminder = decNum % 2;
            decNum /= 2;
            result = reminder.ToString() + result;
        }
        Console.WriteLine(result);
    }
}

