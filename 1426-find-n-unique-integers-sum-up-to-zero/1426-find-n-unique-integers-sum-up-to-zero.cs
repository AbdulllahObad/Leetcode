public class Solution {
    public int[] SumZero(int n) {

        // create an array of size n
        int[] res = new int[n];

        for(int i = 0; i < n/2; i++){
            res[i] =  (i + 1);
            res[(n - 1) - i] = -(i + 1);
        }   

        // If Odd
        if(n%2 != 0){
            res[n/2] = 0;
        }

        return res;
        
    }
}

/*

- Create an array of size n.
- if n = 1 -> [0].
- if n = 2 -> [x,-x]
- if n = n -> [x,y,z,-x,-y,-z]

*/