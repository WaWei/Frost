namespace Frost.Lexers
{
    public struct SourceLocation
    {
        public int Line;
        public int Column;

        public SourceLocation(int line, int column)
        {
            Line = line;
            Column = column;
        }

        public override string ToString()
        {
            return string.Format("Line={0}, Column={1}", Line, Column);
        }
    }
}