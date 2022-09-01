public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int length = 0;
        foreach(int num in nums)
        {
            length++;
        }
        for(int i=0;i<length;i++)
        {
            for(int a=i+1;a<length;a++)
            {
                if(nums[i] + nums[a] == target)
                {
                    int[] array = {i,a};
                    return array;
                }
            }
        }
        return null;
    }
}