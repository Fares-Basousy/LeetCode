// Last updated: 7/3/2025, 5:50:23 PM
public class Solution {
    public int[][] MatrixBlockSum(int[][] mat, int k) {
        int MatL = mat.Length;
        int MatW = mat[0].Length;
        int[][] PrefixSum = new int[MatL + 1][];
        
        for (int i = 0; i <= MatL ; i++)
            PrefixSum[i] = new int[MatW + 1];
            
        int[][] result = new int[MatL][];    //intiate result and prefix  matrices
        for (int i = 0; i < MatL; i++)
            result[i] = new int[MatW];
            
        
        
        for(int i = 1; i <= MatL; i++){
            for(int j = 1; j <= MatW; j++){
                PrefixSum[i][j] = mat[i-1][j-1] +
                                  PrefixSum[i][j-1] +
                                  PrefixSum[i-1][j] -
                                  PrefixSum[i-1][j-1] ;
                }
        }
        for(int i = 0; i < MatL; i++){
            for(int j = 0; j < MatW; j++){
               int UpperRow = Math.Max(0,i-k);
               int LowerRow = Math.Min(MatL-1,i+k);
               int LeftCol  = Math.Max(0,j-k);
               int RightCol = Math.Min(MatW-1,j+k);
               result[i][j] = PrefixSum[LowerRow+1][RightCol+1] -
                              PrefixSum[UpperRow][RightCol+1] - 
                              PrefixSum[LowerRow+1][LeftCol] +
                              PrefixSum[UpperRow][LeftCol];

                            
                }
        }
        

        return result;
    }
}