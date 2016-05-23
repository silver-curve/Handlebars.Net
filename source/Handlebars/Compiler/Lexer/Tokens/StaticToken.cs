﻿using System;

namespace HandlebarsDotNet.Compiler.Lexer
{
    public class StaticToken : Token
    {
        private readonly string _value;

        internal StaticToken(string value)
        {
            _value = value;
        }

        public override TokenType Type
        {
            get { return TokenType.Static; }
        }

        public override string Value
        {
            get { return _value; }
        }
    }
}

