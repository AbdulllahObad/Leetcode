public class Solution {
    public int RomanToInt(string s) {

        int res = 0; 

        // IV = 4 
        // IX = 9
        //--------
        // XL = 40
        // XC = 90
        //--------
        // CD = 400
        // CM = 900
        for(int i = 0; i< s.Length; i++){
            // if c is I; 
            if( s[i] == 'I'){
                if(i+1<s.Length && s[i+1]=='V'){
                        res += 4;
                        i   += 1;
                }else  if(i+1 < s.Length && s[i+1] == 'X'){
                        res += 9;
                        i   += 1;
                } else {
                        res += 1;
                }
            }else if( s[i] == 'V'){
                    res +=5;
                }
             else if( s[i] == 'X'){
                if( i+1 < s.Length && s[i+1] == 'L' ){
                    res += 40;
                    i +=1;
                }else  if( i+1 < s.Length && s[i+1] == 'C' ){
                     res += 90;
                     i +=1;
                }else {
                       res +=10;
                }
            }else if(s[i] == 'C'){
                 if( i+1 < s.Length && s[i+1] == 'D' ){
                    res += 400;
                    i +=1;
                }else  if( i+1 < s.Length && s[i+1] == 'M' ){
                    res += 900;
                    i +=1;
                }else{
                res +=100;
                }}
            else if( s[i] == 'L'){
                res +=50;
            }else if(s[i] == 'D'){
                res +=500;
            }else if(s[i] == 'M'){
                res +=1000;
            }
        }
        return res;
        
    }
}