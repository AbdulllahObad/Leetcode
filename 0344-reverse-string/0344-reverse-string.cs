public class Solution {
    public void ReverseString(char[] s) {

        int right = 0;
        int left = s.Length -1;
        while(right <= left){
            char char_right = s[right];
            char char_left = s[left];
            s[right] = char_left;
            s[left] =char_right; 
            right++;
            left--;
        }
        
    }
}