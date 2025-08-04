using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class ValidParenthesisSolution
    {
        public bool IsValidParenthesis(string s)
        {
            var stack = new Stack<char>();
            var map = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            foreach (char c in s)
            {
                if (map.ContainsKey(c))
                {
                    char topElement = stack.Count == 0 ? '#' : stack.Pop();
                    if (topElement != map[c])
                        return false;
                }
                else
                {
                    stack.Push(c);
                }
            }
            return stack.Count == 0;
        }
    }
}