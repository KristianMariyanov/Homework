using System;
using System.Linq;

class DecToHex
{
    static void Main()
    {
        int decValue = int.Parse(Console.ReadLine());
        string hexValue = string.Empty;
        int currentDigit = 0;
        while (decValue>0)
        {
            if (currentDigit>16)
            {
                currentDigit = (decValue % 16);
            }
            currentDigit = (decValue % 16);
            decValue /= 16;
            switch (currentDigit)
            {
                case 10: hexValue += "A"; break;
                case 11: hexValue += "B"; break;
                case 12: hexValue += "C"; break;
                case 13: hexValue += "D"; break;
                case 14: hexValue += "E"; break;
                case 15: hexValue += "F"; break;
                default: hexValue+= currentDigit.ToString(); break;
            }
            
        }
        Console.WriteLine(string.Join("",hexValue.Reverse()));
    }
}

