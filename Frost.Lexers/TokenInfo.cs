using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frost.Lexers
{
    public class TokenInfo
    {
        int type;
        string description;

        public TokenInfo(int type, string description)
        {
            this.type = type;
            this.description = description;
        }

        public override string ToString()
        {
            return description;
        }

        public override bool Equals(object obj)
        {
            TokenInfo o = (TokenInfo)obj;
            return o.type == type;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}