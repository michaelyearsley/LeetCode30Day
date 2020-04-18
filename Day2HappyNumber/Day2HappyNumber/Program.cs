using System;

namespace Day2HappyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsHappy(7));
        }
        public static bool IsHappy(int n)
        {
            bool happyNum = true;
            int num = n;
            int count = 0;
            while (num != 1)
            {
                if (count > 50)
                {
                    return false;
                }
                else
                {
                    string strNum = Convert.ToString(num);
                    num = 0;
                    int num2;
                    for (int i = 0; i < strNum.Length; i++)
                    {
                        num2 = int.Parse(Convert.ToString(strNum[i]));
                        double power = Math.Pow(num2, 2);
                        num = Convert.ToInt32(power) + num;
                    }
                    count++;
                }
            }
            return happyNum;
        }
    }
}
