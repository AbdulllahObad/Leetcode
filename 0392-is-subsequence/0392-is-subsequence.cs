public class Solution {
    public bool IsSubsequence(string s, string t) {

        int count = 0;
        int index_found =0; // track the starting index in t
          for (int i=0; i<s.Length; i++){
                for(int j =index_found; j<t.Length; j++){
                    if(s[i] == t[j]){
                        count++;
                        index_found = j + 1;
                        break;
                    }
                }
           }
           return count == s.Length;
        
    }
}