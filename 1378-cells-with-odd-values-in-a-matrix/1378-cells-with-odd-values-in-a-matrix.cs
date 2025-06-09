public class Solution {
    public int OddCells(int m, int n, int[][] indices) {

        int[,] res = new int[m,n];
        int count = 0;

        // 1. Loop over the indices matrix 
        foreach (var index in indices) {
                int row = index[0];
                int col = index[1];             
                for (int j = 0; j < n; j++) res[row, j]++;  // row increment
                for (int i = 0; i < m; i++) res[i, col]++;  // col increment  
            
        }
        return res.Cast<int>().Count(x => x % 2 != 0); // O(m * n)






    }
}