public class Solution {
    public int LargestAltitude(int[] gain) {

        int currentAltitude = 0;
        int maxAltitude = 0;
        foreach(var chain in gain){
             maxAltitude =  Math.Max(maxAltitude, chain + currentAltitude);
             currentAltitude = chain + currentAltitude;
        }
        return maxAltitude;
        
    }
}