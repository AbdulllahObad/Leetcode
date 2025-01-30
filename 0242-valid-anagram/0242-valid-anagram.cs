public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length) return false;

        List<Char> SChar = new List<Char>(s);
        foreach(char tt in t){
            if(SChar.Contains(tt)){
                SChar.Remove(tt);
            }else{
                return false;
            }
        }
        return true;
        
    }
}