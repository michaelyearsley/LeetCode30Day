using System;

namespace Day4MoveZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 0, 1, 0, 0, 3, 12 };
           MoveZeroes(num);
        }
        public static void MoveZeroes(int[] nums)
        {
            if (nums.Length == 0)
            {
                Console.WriteLine("null");
            }
            else if (nums.Length == 1)
            {
                Console.WriteLine(nums[0]);
            }
            else
            {
                int pointer1 = 0, pointer2 = 0;
                int temp = 0;
                while (pointer2 < nums.Length)
                {
                    if (nums[pointer2] == 0)
                    {
                        pointer2++;
                    }
                    else
                    {
                        temp = nums[pointer1];
                        nums[pointer1] = nums[pointer2];
                        nums[pointer2] = temp;
                        pointer1++;
                        pointer2++;
                    }
                }
                foreach (var item in nums)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}

