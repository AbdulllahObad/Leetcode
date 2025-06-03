public class Solution {
    public int LargestAltitude(int[] gain) {

        int PreHigh = 0;
        int maxHight = 0;
        foreach(var h in gain){
             maxHight =  Math.Max(maxHight, h + PreHigh);
             PreHigh = h + PreHigh;
        }
        return maxHight;
        
    }
}