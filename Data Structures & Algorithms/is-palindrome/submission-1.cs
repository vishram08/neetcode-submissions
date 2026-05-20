public class Solution {
    public bool IsPalindrome(string s) {
        bool ans = true;
        string str = Regex.Replace(s, "[^a-zA-Z0-9]","").ToLower();

        for(int i=0; i<str.Length/2; i++) {
            if(str[i] != str[str.Length - i - 1]) {
                ans = false;
                break;
            }
        }

        return ans;
    }
}
