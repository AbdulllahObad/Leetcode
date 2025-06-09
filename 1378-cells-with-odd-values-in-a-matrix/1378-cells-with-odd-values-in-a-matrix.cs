public class Solution {
    public int OddCells(int m, int n, int[][] indices) {

        int[,] res = new int[m,n];
        int count = 0;

        // 1. Loop over the indices matrix 
        for(int row =0; row < indices.Length; row++){
             for(int col =0; col < indices[row].Length; col++){
                // First elment 
                if(col == 0){
                    int r1 = indices[row][col]; // 1
                    for(int i=0; i< n; i++){
                         res[r1,i]++;
                    }
                }else{
                    int c1 = indices[row][col];
                    for(int i=0; i<m; i++){
                        res[i,c1]++;
                    }
                }
           
            }
        }
        return res.Cast<int>().Count(x => x % 2 != 0);

        // 0 -> increment the res matrix in : res[1][0],res[1][1], res[1][2] 
        // 1 -> inrement the res matrix in : res[0][c1], res[1][c1], res[2][c1]




    }
}