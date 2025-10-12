public class Solution {
    public int SingleNumber(int[] nums) {
        var a = 0;
        for(int i=0; i< nums.Length; i++){
            a ^= nums[i];
        }
        return a;
    }
}