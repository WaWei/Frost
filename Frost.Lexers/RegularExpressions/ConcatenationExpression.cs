using System;
using Frost.Lexers.FiniteAutomations;

namespace Frost.Lexers.RegularExpressions
{
    public class ConcatenationExpression : RegularExpression
    {
        public RegularExpression Left;
        public RegularExpression Right;

        public override NFA ConvertToNFA()
        {
            throw new NotImplementedException();
        }
    }
}