using System;

namespace DigitOccurance
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int num1, num2,temp,count=0;
            Console.WriteLine("Enter a number 1");
            num1= Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter a number 2");
            num2 = Convert.ToInt32( Console.ReadLine());

            while (num1 > 0)
            {
                temp = num1 % 10;
                if (temp == num2)
                    count++;
                num1 = num1 / 10;
            }
            Console.WriteLine("Occurance {0} times", count);

        }
    }
}
