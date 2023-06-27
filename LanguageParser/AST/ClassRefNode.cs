﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageParser.AST
{
    internal class ClassRefNode : RefNode
    {
        public string Name { get; }
        public bool IsCurrentClass { get; }

        public ClassRefNode(bool isCurrentClass, string name = "this")
        {
            Name = name;
            IsCurrentClass = isCurrentClass;
        }
    }
}
