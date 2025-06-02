public class Solution {
    public bool CheckIfPangram(string sentence) {
        
        Dictionary<char, int> seen = new Dictionary<char, int>();
        int count = 0;
        foreach(var str in sentence){
            // Check if the element is already counted.
            if(!seen.ContainsKey(str)) {
                // If seen for the first time
                count++;   // increase the count 
                seen[str] = 1; // add it to dic
            }
        }
        return count == 26;
    }
}