public class Solution {
    public int OddCells(int m, int n, int[][] indices) {

        int[,] res = new int[m,n];
        int count = 0;

        // 1. Loop over the indices matrix 
        for(int row =0; row < indices.Length; row++){   //O(n)
             for(int col =0; col < indices[row].Length; col++){ // O(k)
                // First elment 
                if(col == 0){
                    int r1 = indices[row][col]; // O(m)
                    for(int i=0; i< n; i++){
                         res[r1,i]++;
                    }
                }else{
                    int c1 = indices[row][col]; // O(n)
                    for(int i=0; i<m; i++){
                        res[i,c1]++;
                    }
                }
           
            }
        }
        return res.Cast<int>().Count(x => x % 2 != 0); // O(m * n)






    }
}