public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        //Idea1: 
        //Brute force: Try every char in jewels and count how many time it apears in stones. 
        //Idea2: HashSet: loop through the stones and check if each one one the hash.

        HashSet<char> jewelsSet = new HashSet<char>(jewels);
        int count = 0;
        foreach(char s in stones){
            if(jewelsSet.Contains(s)){
                count++;
            }
            // foreach(char s in stones){
            //     if(j == s){
            //         count++;
            //     }
            // }
        }
        return count;    
    }
}