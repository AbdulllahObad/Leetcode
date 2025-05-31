public class Solution {
    public int[] Shuffle(int[] nums, int n) {

        int[] res = new int[n*2];
        int x = 0;
        int y = n;
        for(int i=0; i<n*2;i+=2){
            res[i] = nums[x];
            res[i+1] = nums[y];
            x++;
            y++;
        }
        return res;
    }
}