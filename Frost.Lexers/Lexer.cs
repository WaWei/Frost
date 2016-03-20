using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Frost.Lexers
{
    public class Lexer
    {
        DFA engine;
        StringBuilder str;
        Lexicon lexicon;
        SourceReader source;

        public List<Token> Tokens { get; private set; }

        public Lexer(Lexicon lexicon)
        {
            this.lexicon = lexicon;
            engine = lexicon.GenerateDFA();
        }

        public void SetSource(StreamReader s)
        {
            source = new SourceReader(s);
        }

        public void Tokenize()
        {
            SourceLocation location = source.Location;
            while (source.Peek() != -1)
            {
                char c = (char)source.Peek();
                engine.Input(c);
                if (engine.isAtStoppedState)
                {
                    engine.RollBack();
                    if (engine.isAtAcceptState)
                    {
                        var token =
                            new Token(lexicon.CategoryOf(engine.Info), str.ToString(), location);
                        Tokens.Add(token);
                        source.Read();
                        location = source.Location;
                        str.Clear();
                        engine.Reset();
                    }
                    else
                    {
                        Console.WriteLine("lex error occured in position: {0} ", source.Location);
                        return;
                    }
                }
                else
                {
                    str.Append(c);
                    source.Read();
                }
            }
        }
    }
}