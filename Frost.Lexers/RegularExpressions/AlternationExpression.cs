using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frost.Lexers.RegularExpressions
{
    public class AlternationExpression : RegularExpression
    {
        public RegularExpression Left;
        public RegularExpression Right;
    }
}