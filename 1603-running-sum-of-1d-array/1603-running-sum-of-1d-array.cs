public class Solution {
    public int[] RunningSum(int[] nums) {

        int count = 0;
        for(int i =0; i<= nums.Length-1; i++){
            nums[i] += count;
            count = nums[i];
        }
        return nums;
    
        
    }
}