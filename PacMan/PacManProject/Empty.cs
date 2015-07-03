using System;
using System.Collections.Generic;
using System.Text;

namespace PacManProject
{
    class Empty : Block
    {
        public Empty(int r, int c)
            : base(r, c)
        { }
        public override void DrawImage(System.Drawing.Graphics g, int x, int y, int width, int height)
        {
            
        }
        public override bool IsEatable()
        {
            return false;
        }
        public override bool IsReachable()
        {
            return true;
        }
    }
}
