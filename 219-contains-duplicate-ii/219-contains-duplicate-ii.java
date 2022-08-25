class Solution {
    public boolean containsNearbyDuplicate(int[] nums, int k) {
        
        Set<Integer> set = new HashSet<>();       
        
        for(int i = 0; i< nums.length ;i++){
            if (!set.add(nums[i])){
               return true;
            }
             if (set.size() == k+1){
            // Remove the last visited element from the set...
                set.remove(nums[i-k]);
                 
             }
        }
        return false;
        
    }
}