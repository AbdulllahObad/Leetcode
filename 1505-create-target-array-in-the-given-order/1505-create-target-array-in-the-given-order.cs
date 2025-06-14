public class Solution {
    public int[] CreateTargetArray(int[] nums, int[] index) {

        List<int> res = new List<int>();
        for(int i=0; i<nums.Length; i++){
            res.Insert(index[i], nums[i]); // Automatically shifts as needed
        }
        return res.ToArray();      
    }
}