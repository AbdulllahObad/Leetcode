public class Solution {
    public int FindClosestNumber(int[] nums) {
      int closest = nums[0]; // set the variable to the fst ele of the arr
      // Return the smallest abs value
        foreach(int num in nums){
            // If the current num is less than the closet to zero
            if(Math.Abs(num) < Math.Abs(closest)){
                closest = num; 
            }else{
                 if(Math.Abs(num) == Math.Abs(closest) &&
                 num >0){
                    closest = num;

                 }

            }
        }
        
        return closest;
  

    }
}