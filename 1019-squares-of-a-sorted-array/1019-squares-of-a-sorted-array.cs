public class Solution {
    public int[] SortedSquares(int[] nums) {

        // int[] numsArry = new int[nums.Length];        
        // for(int i=0;i<nums.Length;i++){
        //     numsArry[i] = nums[i]*nums[i];
        // }
        int[] numsArray = nums.Select(n => n*n).ToArray();
        Array.Sort(numsArray);
        return numsArray;

    }
}