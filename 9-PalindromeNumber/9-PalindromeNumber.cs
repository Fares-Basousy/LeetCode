// Last updated: 7/1/2025, 5:50:26 PM
public class Solution {
    public string[] IntoSubstrings (string s){
        char[] CharArray = s.ToCharArray();
        string LoopVar = "";
        int StartingPoint = 0;
        List<string> NoDup = new List<string>();
        for (int i = 0; i < CharArray.Length; i++) {
           // Console.WriteLine(i);
            if(!LoopVar.Contains(CharArray[i]))
                LoopVar += CharArray[i];
            else{
                NoDup.Add(new string(LoopVar));
                StartingPoint +=1 ; 
                //Console.WriteLine(i);
                //Console.WriteLine(StartingPoint);
                i = StartingPoint-1;
                //Console.WriteLine(string.Join(", ", NoDup));
                LoopVar = "";
            }
        }
        NoDup.Add(new string(LoopVar)); //Put last substring
        return NoDup.ToArray();
    }
    public int LengthOfLongestSubstring(string s) {
        string[] NoDups = IntoSubstrings(s);
        int Longest = 0;
        for (int i = 0; i < NoDups.Length; i++){
            if(NoDups[i].Length > Longest)
                Longest = NoDups[i].Length;
        }
        return Longest;
    }
}