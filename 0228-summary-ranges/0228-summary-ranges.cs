public class Solution {
    public IList<string> SummaryRanges(int[] nums) {

        List<String> res = new List<String>();
        if (nums.Length == 0) return res;
        int start = nums[0];
        for(int i=0;i<nums.Length;i++){
            int current = nums[i];
            // if the second num doesn't exisit or it's NOT consecutive
            if(i+1 >= nums.Length || nums[i+1] -1 != current){
                if(start != current){
                    res.Add($"{start}->{current}");             
                }else{
                    res.Add($"{start}");
                }
                if(i+1 < nums.Length){
                    start = nums[i+1];
                }
            }  
        }
        return res;  
}
}