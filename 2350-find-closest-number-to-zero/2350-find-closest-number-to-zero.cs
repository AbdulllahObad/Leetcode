public class Solution {
    public int FindClosestNumber(int[] nums) {
      int closest = nums[0];// set the first element to be closest

      foreach(int num in nums){
            if(Math.Abs(num) < Math.Abs(closest)){
                closest = num;
            }else if(Math.Abs(num) == Math.Abs(closest) && num > 0){
                closest = num;
            }
      }

      return closest;
}
}