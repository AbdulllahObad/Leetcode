class Solution {

    public boolean containsDuplicate(int[] nums) {
    
        Set<Integer> set = new HashSet<>();        
        for (int c : nums) {
            if (set.contains(c)) return true;   
            set.add(c);
        }
        return false;
    
}
}