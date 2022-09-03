public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i = 0;
        int length = 0;
        foreach(int item in nums)
        {
            length++;
        }
    for (int j = 0; j < length; j++) {
        if (nums[j] != val) {
            nums[i] = nums[j];
            i++;
        }
    }
    return i;
    }
}