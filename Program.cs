namespace BracketSequence
{
    class Program
    {
        static bool CheckBracketSequence(string sequence)
        {
            bool sequenceIsValid = true;
            Stack<char> checkStack = new Stack<char>();

            for (int i = 0; i < sequence.Length && sequenceIsValid; i++)
            {
                char bracket_i = sequence[i];
                char prev_bracket_i = i - 1 < 0
                    ? bracket_i
                    : sequence[i - 1];

                switch (bracket_i)
                {
                    case '(':
                        checkStack.Push(bracket_i);
                        break;
                    case ')':
                        if (
                            // Guarantees there is a bracket to be closed by the iteration one
                            !sequence.Substring(0, i).Contains('(') ||
                            // and that the previous bracket follows the containment rules
                            (prev_bracket_i == '[' || prev_bracket_i == '{')
                        )
                            sequenceIsValid = false;
                        else
                            checkStack.Pop();
                        break;
                    case '[':
                        checkStack.Push(bracket_i);
                        break;
                    case ']':
                        if (
                            // Guarantees there is a bracket to be closed by the iteration one
                            !sequence.Substring(0, i).Contains('[') ||
                            // and that the previous bracket follows the containment rules
                            (prev_bracket_i == '(' || prev_bracket_i == '{')
                        )
                            sequenceIsValid = false;
                        else
                            checkStack.Pop();
                        break;
                    case '{':
                        checkStack.Push(bracket_i);
                        break;
                    case '}':
                        if (
                            // Guarantees there is a bracket to be closed by the iteration one
                            !sequence.Substring(0, i).Contains('{') ||
                            // and that the previous bracket follows the containment rules
                            (prev_bracket_i == '[' || prev_bracket_i == '(')
                        )
                            sequenceIsValid = false;
                        else
                            checkStack.Pop();
                        break;
                }
            }

            if (sequenceIsValid && checkStack.Count() != 0)
                sequenceIsValid = false;

            return sequenceIsValid;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(" ===== Testing cases ===== ");
            Console.WriteLine("is (){}[] valid?: " + CheckBracketSequence("(){}[]"));
            Console.WriteLine("is [{()}](){} valid?: " + CheckBracketSequence("[{()}](){}"));
            Console.WriteLine("is []{() valid?: " + CheckBracketSequence("[]{()"));
            Console.WriteLine("is [{)] valid?: " + CheckBracketSequence("[{)]"));
        }
    }
}