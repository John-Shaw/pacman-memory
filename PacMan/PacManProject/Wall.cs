using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PacManProject
{
    class Wall:Block
    {
        public Wall(int r, int c)
            : base(r, c)
        { }
        public override void DrawImage(System.Drawing.Graphics g, int x, int y, int width, int height)
        {

            Point p = new Point(x , y );
            Point p1 = new Point(x + width, y );
            Point p2 = new Point(x, y + height);
            Point[] pt = { p, p1, p2 };

            Image image = Image.FromFile("wall2.jpg");
            g.DrawImage(image, pt);

            //HatchBrush br = new HatchBrush(HatchStyle.BackwardDiagonal, Color.Black, Color.Gray);
            //g.DrawRectangle(Pens.Black, x, y, width, height);
           
            //g.FillRectangle(br, x, y, width, height);
        }
        public override bool IsEatable()
        {
            return false;
        }
        public override bool IsReachable()
        {
            return false;
        }
    }
}
