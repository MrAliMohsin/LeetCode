public class Solution {
    public string ReverseString(string s) {
        //Declaring a new string with no value inside it
            string reversedString=null;
            //Declaring string builder to built the string as we can not user reversedString[x] to set an indexed value because there no setter for a string 
            //This point can be checked at http://stackoverflow.com/questions/22093976/property-or-indexer-string-thisint-cannot-be-assigned-to-its-read-only
            
            StringBuilder SB = new StringBuilder(reversedString);
            for (int i = s.Length-1; i >=0; i--)
            {
                SB.Append(s[i]);
            }
            reversedString = SB.ToString();
                return reversedString;
    }
}