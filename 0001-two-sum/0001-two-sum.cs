public class Solution {
    public int[] TwoSum(int[] nums, int target) {

    Dictionary<int,int> seen = new Dictionary<int,int>();

    for(int i=0; i<nums.Length;i++){
        int complement = target - nums[i];
        if(seen.ContainsKey(complement)){
            // Found a pair that'd sum up to target 
            return new int[] {i, seen[complement]};
        }
        seen[nums[i]] = i;

    } 
    return null;
        // for(int i=0; i<nums.Length; i++){
        //     for(int j=i+1; j<nums.Length; j++){
        //         if( nums[i] + nums[j] == target){
        //             return new int[]{ i, j };
        //         }
        //     }
        // }
        // return null;
    }
}