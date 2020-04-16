using System;

namespace Day1SingleNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] num;
            Console.WriteLine(SingleNumber(num = new int[] { 1, 2, 1, 2, 4 }));
        }
        public static int SingleNumber(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            while( right >= 0)
            {
                if( right == left)
                {
                    right--;
                }
                else if(nums[left] == nums[right])
                {
                    left++;
                    right = nums.Length - 1;
                }
                else if(nums[left] != nums[right])
                {
                    right--;
                }
            }
            return nums[left];
        }
    }
}
