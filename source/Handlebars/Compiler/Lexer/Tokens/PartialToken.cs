﻿namespace HandlebarsDotNet.Compiler.Lexer
{
    public class PartialToken : Token
    {
        public override TokenType Type
        {
            get { return TokenType.Partial; }
        }

        public override string Value
        {
            get { return ">"; }
        }

        public override string ToString()
        {
            return Value;
        }
    }
}

