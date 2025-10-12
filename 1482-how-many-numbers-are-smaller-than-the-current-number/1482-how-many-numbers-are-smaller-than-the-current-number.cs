public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums)
	{
		var a = (int[])nums.Clone();
		Array.Sort<int>(nums);
		var res = new int[nums.Length];
		Dictionary<int, int> dic = new Dictionary<int, int>();
		for (int i = 0; i < nums.Length; i++)
		{
			if(!dic.ContainsKey(nums[i]))
				dic.Add(nums[i],i);
		}
		for(int j =0; j<nums.Length; j++){
			dic.TryGetValue(a[j], out res[j]);
		}

		return res;
	}
}