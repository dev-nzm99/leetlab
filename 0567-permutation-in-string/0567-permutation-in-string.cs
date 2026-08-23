public class Solution {
    private bool IsFreqSame(int[] freq,int[] winFreq){
        for(int i = 0; i < freq.Length; ++i){
            if(freq[i] != winFreq[i]) return false;
        }
        return true;
    }

    public bool CheckInclusion(string s1, string s2) {
        int n = s2.Length;
        int winSize = s1.Length;
        int[] freq = new int[26];
        int[] winFreq = new int[26];

        foreach(var ch in s1) ++freq[ch - 'a'];

        int i = 0, j = 0;
        while(j < n){
            ++winFreq[s2[j] - 'a'];
            int s = j - i + 1;
            if(s == winSize && IsFreqSame(freq, winFreq))
                return true;
            else if(s < winSize) j++;
            else{
                --winFreq[s2[i] - 'a'];
                i++;j++;
            }
        }
        return false;
    }
}