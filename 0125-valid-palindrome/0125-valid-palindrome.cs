public class Solution {
    public bool IsPalindrome(string s) {

        string trimmed = new String(s.ToLower().Where(char.IsLetterOrDigit).ToArray());
        int right = 0;
        int left = trimmed.Length -1;
        while( right <= left){

            if(trimmed[right] != trimmed[left]){
                return false;
            }else {
                right++;
                left--;
            }
        }

        return true;

        
    }
}