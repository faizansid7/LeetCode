public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char, int> pool = new Dictionary<char, int>();
        for(int i=0; i<magazine.Length; i++){
            if(!pool.ContainsKey(magazine[i])){
                pool.Add(magazine[i],1);
			}
            else{
				pool.TryGetValue(magazine[i], out int val);
				pool[magazine[i]] = val + 1;
			}
        }
		for(int i=0; i<ransomNote.Length; i++){
			var charPresent = pool.TryGetValue(ransomNote[i], out int freq);
			if(!charPresent || freq == 0)
				return false;
			pool[ransomNote[i]] = freq-1;
		}
		return true;
    }
}