using Frost.Lexers.FiniteAutomations;

namespace Frost.Lexers.RegularExpressions
{
    public abstract class RegularExpression
    {
        public abstract NFA ConvertToNFA();
    }
}