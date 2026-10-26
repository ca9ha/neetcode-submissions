public class Solution {
    public bool IsValid(string s) {
        
            var expectedClosings = new Stack<char>();

            foreach (var character in s)
            {
                switch (character)
                {
                    case '(':
                        expectedClosings.Push(')');
                        break;

                    case '{':
                        expectedClosings.Push('}');
                        break;

                    case '[':
                        expectedClosings.Push(']');
                        break;

                    case ')':
                    case '}':
                    case ']':
                        if (expectedClosings.Count == 0 ||
                            expectedClosings.Pop() != character)
                        {
                            return false;
                        }

                        break;
                }
            }

            return expectedClosings.Count == 0;
    }
}
