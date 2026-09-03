public class Solution {
    public int TakeCharacters(string s, int k) {
        int[] freq = new int[3];
        foreach(var c in s) freq[c - 'a']++;
        
        if(Math.Min(Math.Min(freq[0], freq[1]), freq[2]) < k) return -1;

        int left = 0, res = int.MaxValue;
        
        for(int right = 0; right<s.Length; right++){
            freq[s[right] - 'a']--;
            while(Math.Min(Math.Min(freq[0], freq[1]), freq[2]) < k){
                freq[s[left++] - 'a']++; 
            }
            res = Math.Min(res, s.Length - (right - left + 1));
        }
        return res;
    }
}