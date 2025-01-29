public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        //Idea1: 
        //Brute force: Try every char in jewels and count how many time it apears in stones. 
        int count = 0;
        foreach(char j in jewels){
            foreach(char s in stones){
                if(j == s){
                    count++;
                }
            }
        }
        return count;
  
        
    }
}