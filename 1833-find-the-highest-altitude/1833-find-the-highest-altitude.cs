public class Solution {
    public int LargestAltitude(int[] gain) {

        int currentAltitude = 0;
        int maxAltitude = 0;
        foreach(var change in gain){
            // At each step, we add or loss to our current altitude.
             maxAltitude =  Math.Max(maxAltitude, change + currentAltitude);// Update the max altitiude if we go higher
             currentAltitude = change + currentAltitude;// Keep track of the current altitude
        }
        //  [-5,1] -> max is 0, current 0
        // first step:  we lost -5, at this point our max is 0 
        // our current state now is -5, 
        // second step: we gained 1 from our current, our max still the 0 we moved from at the begining, 
        // our current altitude is -4, cause we were at -5 and we  moved on step up. 
        return maxAltitude;
        
    }
}