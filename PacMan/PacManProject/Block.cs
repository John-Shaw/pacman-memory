using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace PacManProject
{
    abstract class Block:Cell
    {
        public Block():this(0,0) { }
        public Block(int r, int c)
            : base(r, c)
        { }
        
        public abstract bool IsEatable();
        public abstract bool IsReachable();
        
    }
}
