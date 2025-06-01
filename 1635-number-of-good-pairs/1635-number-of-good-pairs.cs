public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        
        Dictionary<int, int> Freq = new Dictionary<int, int>(); 
        int count = 0;
        for(int i =0; i< nums.Length; i++){
            if(Freq.ContainsKey(nums[i])){
                count += Freq[nums[i]];
                Freq[nums[i]]++;
            }else{
                Freq[nums[i]] = 1;
            }
            
        }
        return count;
        // Time: O(n^2)    
    }
}