public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        string longest_pre = "";
        for(int i=0; i<strs[0].Length;i++){
            char letter = strs[0][i];
            for(int j=1; j<strs.Length;j++){
                if(strs[j].Length -1 < i || letter != strs[j][i]){
                    return longest_pre;
                }
            }

            longest_pre+= letter;

        }
        return longest_pre;

        
    }
}