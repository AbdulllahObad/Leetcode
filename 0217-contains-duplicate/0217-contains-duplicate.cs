public class Solution {
    public bool ContainsDuplicate(int[] nums) {

// Idea1: Brute force 
// Test every combination in num, check if we had the same number in the rust if the array
// Idea2 : use hashSet for quick check if had the number towic

HashSet<int> NumSeen = new HashSet<int>();
foreach(int num in nums){
    if(NumSeen.Contains(num)){
        return true;
    }
    NumSeen.Add(num);

}
return false;


        // for(int i=0; i<nums.Length;i++){
        //     for(int j = i+1; j< nums.Length;j++){
        //         if(nums[i] == nums[j]){
        //             return true;
        //         }
        //     }
        // }
        return false;  
    }
}