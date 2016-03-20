using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frost.Lexers
{
    public class Token
    {
        public readonly TokenInfo Category;
        public readonly string Text;
        public readonly SourceLocation Location;

        public Token(TokenInfo category, string text, SourceLocation location)
        {
            Category = category;
            Text = text;
            Location = location;
        }
    }
}