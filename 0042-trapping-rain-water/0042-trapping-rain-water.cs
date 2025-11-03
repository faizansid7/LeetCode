public class Solution {
    public int Trap(int[] height) {
        var sMan = Sman(height);
		var pMan = Pman(height);
		int count = 0;
		for(int i=0; i<height.Length; i++){
			var min = Math.Min(sMan[i],pMan[i]);
			if(min > height[i])
				count += min-height[i];
		}
		return count;
    }
    private static int[] Sman(int[] arr)
	{
		var arr2 = (int[])arr.Clone();
		int max = 0;
		for (int i = 0; i < arr.Length; i++)
		{
			if (arr2[i] > max)
			{
				max = arr2[i];
			}
			else
			{
				arr2[i] = max;
			}
		}

		return arr2;
	}
    private static int[] Pman(int[] arr)
	{
		var arr2 = (int[])arr.Clone();
		int max = 0;
		for (int i = arr2.Length - 1; i > 0; i--)
		{
			if (arr2[i] > max)
			{
				max = arr2[i];
			}
			else
			{
				arr2[i] = max;
			}
		}

		return arr2;
	}
}