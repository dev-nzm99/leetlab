public class Solution {
    public int TotalFruit(int[] fruits) {
        Dictionary<int,int> m = new Dictionary<int,int>();
        int l = 0, res = int.MinValue;
        
        for(int r = 0; r < fruits.Length; r++){
            if(!m.ContainsKey(fruits[r])){
                m.Add(fruits[r], 1);
            }else{
                m[fruits[r]]++;
            }
            while(m.Count > 2 && l <= r){
                m[fruits[l]]--;
                if(m[fruits[l]] == 0) m.Remove(fruits[l]);
                l++;
            }
            res = Math.Max(res, r-l+1);
        }
        return res;
    }
}