public class Solution {
    public int[] SortedSquares(int[] nums) {

        // int[] numsArry = new int[nums.Length];        
        // for(int i=0;i<nums.Length;i++){
        //     numsArry[i] = nums[i]*nums[i];
        // }
        // int[] numsArray = nums.Select(n => n*n).ToArray();
        // Array.Sort(numsArray);
        int right = 0;
        int left = nums.Length -1;
        List<int> res = new List<int>();
        while (right <= left){
            if(Math.Abs(nums[right]) < Math.Abs(nums[left])){
                res.Add(nums[left]*nums[left]);
                left--;
            }else{
                res.Add(nums[right]*nums[right]);
                right++;
                }
        } 
        res.Reverse();
        return res.ToArray();
    }
}