// Last updated: 7/30/2025, 3:13:54 PM
public class Solution {
    public int Reverse(int x) {
        bool isNeg = false;
        if( x <= Math.Pow(-2,31) || x > Math.Pow(2,31))
            return 0;
        
        if (x<0) 
            isNeg = true;
        // get the absolute value
        int PosNum  = isNeg? x*-1 : x ;
        // Convert number to string then to char array 
        char[] charArray =  PosNum.ToString().ToCharArray(); 
        // Reverse the array 
        Array.Reverse(charArray);              
        string str = new string(charArray);
        // Convert string to number
        try{
        int number = int.Parse(str);
        return isNeg? number*-1 : number;
        }
        catch(Exception e){
            return 0;
        }
        

    }
}