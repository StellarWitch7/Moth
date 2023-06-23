﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageParser.Token
{
    internal class NameToken : ParsedToken
    {
        private string _name;

        public NameToken(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return $"(name {_name})";
        }
    }
}
