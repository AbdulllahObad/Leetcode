public class Solution {
    public int[] GetConcatenation(int[] nums) {


        int[] res = new int[2*nums.Length];
        int count_i = 0;

        for(int i=0; i < res.Length; i++){
            if(count_i == nums.Length) {count_i=0;}
            res[i] = nums[count_i];  
            count_i++;
        }
        return res;  
    }
}