namespace Frost.Lexers.RegularExpressions
{
    public class ConcatenationExpression : RegularExpression
    {
        public RegularExpression Left;
        public RegularExpression Right;
    }
}