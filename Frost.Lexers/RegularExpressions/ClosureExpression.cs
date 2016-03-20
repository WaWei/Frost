using System;
using Frost.Lexers.FiniteAutomations;

namespace Frost.Lexers.RegularExpressions
{
    public class ClosureExpression : RegularExpression
    {
        public RegularExpression Expr;

        public override NFA ConvertToNFA()
        {
            throw new NotImplementedException();
        }
    }
}