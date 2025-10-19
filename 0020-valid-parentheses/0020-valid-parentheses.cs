public class Solution {
    public bool IsValid(string str) {
        Stack<char> stack = new Stack<char>();
        for(int i=0; i<str.Length; i++)
		{
			if(str[i]=='(' || str[i]=='{' || str[i]=='[')
			{
				stack.Push(str[i]);
			}
			else
			{
                if(stack.Count == 0)
					return false; 
				var bracket = stack.Pop();
				if((bracket == '(' && str[i] != ')') || 
                (bracket == '{' && str[i] != '}') || 
                (bracket == '[' && str[i] != ']'))
				{
					return false;
				}
			}	
		}
        return stack.Count == 0;
    }
}