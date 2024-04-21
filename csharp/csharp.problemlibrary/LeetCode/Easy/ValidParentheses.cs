namespace csharp.problemlibrary.LeetCode.Easy
{
    public class ValidParentheses
    {
        // Method can be optimized, consume less memory, method implementation from chatGPT
        public static bool IsValidGPT(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> mapping = new Dictionary<char, char> {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };

            foreach (char c in s)
            {
                if (mapping.ContainsValue(c))
                {
                    stack.Push(c);
                }
                else if (mapping.ContainsKey(c))
                {
                    if (stack.Count == 0 || stack.Pop() != mapping[c]) return false;
                }
            }

            return stack.Count == 0;

        }
    }
}