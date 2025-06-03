public class Solution {
    public int LargestAltitude(int[] gain) {

        int currentAltitude = 0;
        int maxAltitude = 0;
        foreach(var change in gain){
             maxAltitude =  Math.Max(maxAltitude, change + currentAltitude);
             currentAltitude = change + currentAltitude;
        }
        return maxAltitude;
        
    }
}