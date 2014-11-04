using System;

class HexToDec
{
    static void Main()
    {
        Console.WriteLine("Enter Heximal Number");
        string hexNum =Console.ReadLine();
        int num;
        long result = 0;
        for (int i = 1; i <= hexNum.Length; i++)
        {
            switch (hexNum[hexNum.Length-i])
            {
                case 'A':
                    num = 10;
                    break;
                case 'B':
                    num = 11;
                    break;
                case 'C':
                    num = 12;
                    break;
                case 'D':
                    num = 13;
                    break;
                case 'E':
                    num = 14;
                    break;
                case 'F':
                    num = 15;
                    break;
                default:
                    num = int.Parse(hexNum[hexNum.Length-i].ToString());
                    break;
            }
            result = (long)(result + (num* Math.Pow(16,i-1)));
        }
        Console.WriteLine(result);

    }
}
