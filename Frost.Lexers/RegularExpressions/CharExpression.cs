using System;
using Frost.Lexers.FiniteAutomations;

namespace Frost.Lexers.RegularExpressions
{
    public class CharExpression : RegularExpression
    {
        public char Value;

        public override NFA ConvertToNFA()
        {
            throw new NotImplementedException();
        }
    }
}