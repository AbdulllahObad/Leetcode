public class Solution {
    public string MergeAlternately(string word1, string word2) {

        int word1_l = word1.Length;
        int word2_l = word2.Length;

        int merged_word_length = Math.Max(word1_l,word2_l);

        //string merged_word = "";
        StringBuilder Merged_word = new StringBuilder();

        for(int i= 0; i<merged_word_length; i++){
             //if we still have letters to merge in word1
             if(i< word1_l ){
             //Place the ith letter in word1
              char word1_letter = word1[i];
             // Merge the letters
             Merged_word.Append(word1_letter);
            }
             //if we still have letters to merge in word2
             if(i< word2_l ){    
            //Get the ith letter in word2
             char word2_letter = word2[i];
             Merged_word.Append(word2_letter);
            }
        }
        string result = Merged_word.ToString();

        return result;
        
    }
}