using System;
class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter num in binary format");
        string binaryNum = Console.ReadLine();
        long decNumber = 0;
        for (int i = 0; i < binaryNum.Length; i++)
        {
            int position = binaryNum.Length - i -1;
            int num = int.Parse(binaryNum[position].ToString());
            if (num==1)
            {
                decNumber = (long)(decNumber + Math.Pow(2,i));
            }
        }
        Console.WriteLine(decNumber);
    }
}

