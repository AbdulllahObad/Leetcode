public class Solution {
    public void ReverseString(char[] s) {
        // ["h","e","l","l","o"]
        int size = s.Length;
        for(int i = 0; i<size/2;i++){
            char start = s[i];
            char end = s[(s.Length -1) - i];
            s[i] = end;
            s[(s.Length -1) - i] = start;   
        }



        
    }
}