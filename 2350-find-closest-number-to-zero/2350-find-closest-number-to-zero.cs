// Thoughts...
// Thoughts...
// 1. Iterate through each element in the array.
// 2. Assume the first element is the closest to zero.
// 3. For each number in the loop:
//    3.1 Compare its absolute value with the current closest number.
//        - If it's smaller, update the closest number.
//    3.2 If absolute values are equal, prefer the positive number.
//        - If the current number is positive and equal in absolute value, update it.



public class Solution {
    public int FindClosestNumber(int[] nums) {
      int closest = nums[0];// set the first element to be closest
      foreach(int num in nums){
        // if abs(num) is smaller than abs(closest), update it 
        if(Math.Abs(num) < Math.Abs(closest)){
            closest = num;
        }else if(Math.Abs(num)==Math.Abs(closest) && num> 0){
            closest = num;
        }
      }
      return closest;
}
}