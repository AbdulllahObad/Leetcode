public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        // Create a new 2D array
        // Loop over each row.
        // 1. filp it
        // 2. Invert it
        int [][] res = new int[image.Length][]; 
        for(int i =0; i< image.Length; i++){
            res[i] = new int[image[i].Length];
            int resIndex = 0;
            for(int j = image[i].Length -1; j>-1; j--){
                // Get the last element from image and filp it 
                int reversedPix = image[i][j] ==0? 1: 0;
                // Store it at incresed index in res: ex 0, 1, 2
                res[i][resIndex] = reversedPix;
                resIndex++;
            }
        }

        return res;

        
    }
}