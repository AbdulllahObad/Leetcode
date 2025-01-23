public class Solution {
    public string MergeAlternately(string word1, string word2) {
    int size1 = word1.Length;
    int size2 = word2.Length;
    int size3 = Math.Max(size1, size2);
    string word3 = "";
    for(int i = 0; i<size3; i++){
        // if the current iteration is less than the first word, add it 
        if(i < size1){
            word3 += word1[i];
        }
        // if the current iteration is less than the second word, add it 
        if(i < size2){
            word3 += word2[i];
        }
        // if(i >= size1){     
        //     char letter_W2 = word2[i];
        //     word3 += letter_W2;
        // }else if (i >= size2){
        //     char letter_W1 = word1[i];
        //     word3 += letter_W1;
        // }else {
        //     char letter_W1 = word1[i];
        //     char letter_W2 = word2[i];
        //         word3 += letter_W1;
        //         word3 += letter_W2;
        // }
    }  

    return word3;
    }
}