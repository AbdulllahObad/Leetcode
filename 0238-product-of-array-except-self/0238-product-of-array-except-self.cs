public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        int total_prod = 1;
        int zero_counter = 0;
        for(int i =0; i<nums.Length; i++){
            if(nums[i] != 0){
                total_prod *= nums[i];
            }else{
                zero_counter++;
            }
        }

        int[] res= new int[nums.Length];
        for(int i = 0; i<nums.Length;i++){   
            // if we have more than one zero -> the res contains 0
            if(zero_counter > 1){
                res[i] = 0;
            }else {
                if(zero_counter == 1){
                    // if exacly ONE zero, only the zero position gets non zero value
                    res[i] = (nums[i] == 0)? total_prod : 0;
                }else{
                    res[i] = total_prod/nums[i];
                }
            }


        }
        return res;
    }
}