// Last updated: 7/1/2025, 3:02:45 PM
public class Solution {
    public static string Reverse( string s )
    {
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
    }
    public bool IsPalindrome(int x) {
        if (x <0){
            return false;
        }
        else{
            string XString = x.ToString();
            string RevString = Reverse(XString);
            return XString == RevString ? true : false ;

            
        }
        
    }
}