﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageParser.AST;

public class ReturnNode : StatementNode
{
    public ExpressionNode ReturnValue { get; }

    public ReturnNode(ExpressionNode returnValue)
    {
        ReturnValue = returnValue;
    }
}
