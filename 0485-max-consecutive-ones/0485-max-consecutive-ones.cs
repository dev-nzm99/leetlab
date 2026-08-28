public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxCons = 0, currCons = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 1) ++currCons;
            else currCons = 0;
            maxCons = Math.Max(maxCons, currCons);
        }
        return maxCons;
    }
}