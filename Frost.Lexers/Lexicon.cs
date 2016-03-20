using Frost.Lexers.RegularExpressions;
using System.Collections.Generic;

namespace Frost.Lexers
{
    public class Lexicon
    {
        List<string> descriptions = new List<string>();
        List<RegularExpression> regxs = new List<RegularExpression>();

        public TokenInfo DefineToken(string description, RegularExpression regx)
        {
            descriptions.Add(description);
            regxs.Add(regx);
            return new TokenInfo(regxs.Count - 1, description);
        }

        public TokenInfo CategoryOf(int i)
        {
            return new TokenInfo(i, descriptions[i]);
        }

        public DFA GenerateDFA()
        {
            throw new System.NotImplementedException();
        }
    }
}