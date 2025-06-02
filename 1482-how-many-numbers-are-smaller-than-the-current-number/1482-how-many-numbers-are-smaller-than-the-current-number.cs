public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {

        int[] res = new int[nums.Length];

        for(int i=0; i<nums.Length; i++){
            int countSmaller = 0;
            for(int j=0; j<nums.Length; j++){
                if(nums[i] > nums[j]){
                    countSmaller++;
                }
            }
            res[i] = countSmaller;
        }
        return res;
        
    }
}