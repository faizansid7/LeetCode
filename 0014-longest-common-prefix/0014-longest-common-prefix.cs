public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            var iLength = Math.Min(prefix.Length, strs[i].Length);
            prefix = prefix.Substring(0, iLength);
            for (int j = 0; j < iLength; j++)
            {
                if (prefix[j] != strs[i][j])
                {
                    prefix = prefix.Substring(0, j);
                    break;
                }
            }
        }

        return prefix;
    }
}