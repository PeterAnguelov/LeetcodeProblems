using System.Net.Sockets;

namespace _1._Two_Sum;

class Program
{
    static void Main(string[] args)
    {
        int target = 6;
        int[] nums = new int[]
        {
            3,2,4
        };

        Console.WriteLine(TwoSum(nums, target));
    }

    static int[] TwoSum(int[] nums, int target)
    {
        List<int> result = new List<int>();

        int count = 0;
        bool targetReached = false;

        while (!targetReached)
        {
            System.Console.WriteLine($"count: {count}");
            int adder = nums[count];
            int secondCount = 0;
            result.Add(nums[count]);
            while (adder != target)
            {
                System.Console.WriteLine($"i: {secondCount}");
                if (count != secondCount)
                {
                    adder+= nums[secondCount];
                    result.Add(nums[secondCount]);
                    System.Console.WriteLine($"adder: {adder}");
                }
                secondCount++;
            }

            if (adder == target)
            {
                targetReached = true;
            }

            count++;
        }
        /*for (int i = 0; i < nums.Length; i++)
        {
            int adder = 0;
            adder = nums[i];
            result.Add(nums[i]);

            Console.WriteLine($"Result: {result[i]}");

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    continue;
                }
                else
                {
                    adder += nums[j];
                    result.Add(nums[j]);
                    Console.WriteLine($"Adder: {adder}");
                    if (adder >= target)
                    {
                        break;
                    }
                }
            }

            if (adder == target)
            {
                Console.WriteLine(result.Count);
                break;
            }

            result.Clear();
        }*/

        int[] finalNums = new int[result.Count];

        for (int i = 0; i < result.Count; i++)
        {
            finalNums[i] = result[i];
        }

        foreach (int item in finalNums)
        {
            System.Console.Write(item);
        }

        return finalNums;
    }

    static int Adder()
    {
        
    }
}


/*
1. Two Sum
Given an array of integers nums and an integer target, return 
indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, 
and you may not use the same element twice.

You can return the answer in any order.

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 

Constraints:

2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.
 

Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
*/