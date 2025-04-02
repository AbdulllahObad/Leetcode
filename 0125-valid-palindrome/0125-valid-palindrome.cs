public class Solution {
    public bool IsPalindrome(string s) {

        int left = 0;
        int right = s.Length -1;
        while(left < right ){
            if(Char.IsLetterOrDigit(s[right]) && Char.IsLetterOrDigit(s[left])){
                if(Char.ToLower(s[right]) != Char.ToLower(s[left])){
                    return false;
                }else{
                    right--;
                    left++;
                }
            }    
            if(!Char.IsLetterOrDigit(s[right])){
                right--;
            }
             if(!Char.IsLetterOrDigit(s[left])){
                left++;
            }
        }
        return true;  
    }
}