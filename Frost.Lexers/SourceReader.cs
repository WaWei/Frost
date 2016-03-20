using System.IO;

namespace Frost.Lexers
{
    public class SourceReader
    {
        StreamReader source;
        public SourceLocation Location;

        public SourceReader(StreamReader source)
        {
            this.source = source;
        }

        public int Peek()
        {
            if (source.Peek() == '\r') // 跳过'\r'
            {
                source.Read();
            }
            return source.Peek();
        }

        public int Read()
        {
            int c = Peek();
            if (c == '\n')
            {
                Location.Line += 1;
                Location.Column = 0;
            }
            else
            {
                Location.Column += 1;
            }
            source.Read();
            return c;
        }
    }
}