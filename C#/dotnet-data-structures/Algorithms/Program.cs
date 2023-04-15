public class Program
{
    public static void Main() {}

   /**
    * Given an array of integers nums which is sorted in ascending order, and an integer target,
    * write a function to search target in nums. 
    * If target exists, then return its index. Otherwise, return -1. 
    * You must write an algorithm with O(log n) runtime complexity.
    * 
    * https://leetcode.com/problems/binary-search/?envType=study-plan&id=algorithm-i
    */
    public static int Search(int[] nums, int target)
    {
        return nums.Length > 0 ?
            Search(nums, target, 0, nums.Length - 1) :
            -1;
    }

    private static int Search(int[] nums, int target, int start, int end)
    {
        // start at the middle of the array
        int middle = (end + start) / 2;

        if (end < start)
        {
            return -1;
        }
        // if the middle is the target, return it.
        else if (nums[middle] == target)
        {
            return middle;
        }
        // if the number in the middle is greater than the target then search left
        else if (nums[middle] > target)
        {
            return Search(nums, target, start, middle - 1);
        }
        // if the number in the middle is less than the target then search right
        else
        {
            return Search(nums, target, middle + 1, end);
        }
    }

}