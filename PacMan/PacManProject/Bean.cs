using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace PacManProject
{
    class Bean:Block
    {
        public Bean(int r, int c)
            : base(r, c)
        { }
        public override void DrawImage(System.Drawing.Graphics g, int x, int y, int width, int height)
        {
            Point p = new Point(x + 5, y + 5);
            Point p1 = new Point(x + width-5, y + 5);
            Point p2 = new Point(x + 5, y + height-5);
            Point[] pt = { p, p1, p2 };

            Image image = Image.FromFile("bean.jpg");
            g.DrawImage(image, pt);
            
            //int diameter = Math.Min(width, height)-10;
            //int xPos = x+(width-diameter)/2;
            //int yPos = y + (height - diameter) / 2;
            //g.FillEllipse(Brushes.Gold, xPos+5, yPos+5, diameter/2, diameter/2);
            
        }
        public override bool IsEatable()
        {
            return true;
        }

        public override bool IsReachable()
        {
            return true;
        }
    }
}
