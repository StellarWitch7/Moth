﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moth.AST.Node;

public class DecrementVarNode : ExpressionNode
{
    public RefNode RefNode { get; set; }

    public DecrementVarNode(RefNode refNode)
    {
        RefNode = refNode;
    }
}
