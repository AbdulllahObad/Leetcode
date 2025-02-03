public class Solution {
    public bool IsPalindrome(string s) {

        // string trimmed = new String(s.ToLower().Where(char.IsLetterOrDigit).ToArray());
        // int right = 0;
        // int left = trimmed.Length -1;
        // while( right <= left){

        //     if(trimmed[right] != trimmed[left]){
        //         return false;
        //     }else {
        //         right++;
        //         left--;
        //     }
        // }


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