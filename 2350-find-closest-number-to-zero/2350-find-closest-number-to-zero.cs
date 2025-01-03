public class Solution {
    public int FindClosestNumber(int[] nums) {

        int clst_to_zero =  nums[0];
        foreach(int num in nums){
            if (Math.Abs(num) < Math.Abs(clst_to_zero)) {
                clst_to_zero = num;
            }
            else if (Math.Abs(num) == Math.Abs(clst_to_zero) && num > clst_to_zero ) {
                clst_to_zero = num;
            }
        } 

        return clst_to_zero;
    }
}