using System;
using System.ComponentModel.DataAnnotations;

namespace Day3MaximumSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { -2, -1};
            Console.WriteLine(MaxSubArray(num));
        }
        public static int MaxSubArray(int[] nums)
        {
            int maxNum = 0;
            int MaxSoFar = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                maxNum = maxNum + nums[i];
                if (maxNum < 0)
                {
                    maxNum = 0;
                    if(MaxSoFar < nums[i])
                    {
                        MaxSoFar = nums[i];
                    }
                }
                else if (maxNum > MaxSoFar)
                {
                    MaxSoFar = maxNum;
                }
                
            }
            return MaxSoFar;
        }
    }
}
