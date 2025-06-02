public class Solution {
    public int[] CreateTargetArray(int[] nums, int[] index) {

        List<int> res = Enumerable.Repeat(-1, nums.Length).ToList();
        for(int i=0; i<nums.Length; i++){
               int x = index[i]; // At this index x
               int y = nums[i]; // Insert this y
               if(res[x] != -1){
                    // try to insert to an already filled cell.
                    res.Insert(x,y);
                    res.RemoveAt(res.Count-1);
               }else{
                    res[i] = y;
               }
        }
        return res.ToArray();      
    }
}