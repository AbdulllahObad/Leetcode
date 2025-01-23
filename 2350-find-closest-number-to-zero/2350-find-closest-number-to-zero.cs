public class Solution {
    public int FindClosestNumber(int[] nums) {
        int closest = nums[0];
        int currentValue = 0;
        for (int i = 0; i < nums.Count(); i++)
        {
            currentValue = Math.Abs(nums[i]);
            if (currentValue == 0)
            {
                closest = currentValue;
            }
            else if (currentValue < Math.Abs(closest))
            {
                closest = nums[i];
            }
        }

        if(closest < 0 && nums.Contains(Math.Abs(closest))){
            return Math.Abs(closest);
        } else{
            return closest;
        }
    }
}