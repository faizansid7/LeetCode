public class Solution {
    public int[] TwoSum(int[] arr, int k) {
        for (int i = 0; i < arr.Length; i++)
		{
			for (int j = i + 1; j < arr.Length; j++)
			{
				if (arr[i] + arr[j] == k)
				{
					return [i,j];
				}
			}
		}
        return [0,0];
    }
}