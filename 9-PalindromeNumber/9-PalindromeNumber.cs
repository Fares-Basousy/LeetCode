// Last updated: 7/1/2025, 3:32:35 PM
public class Solution {
    public static int Reverse( int s )
    { int Rev = 0;
    while (s > 0){
        Rev *= 10;
        Rev +=  s%10;
        s /= 10;
    }
    Console.WriteLine(Rev);
    return Rev;
    }
    public bool IsPalindrome(int x) {
        if (x <0){
            return false;
        }
        else{
            int RevX = Reverse(x);
            return x == RevX ? true : false ;

            
        }
        
    }
}