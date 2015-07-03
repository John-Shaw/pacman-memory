using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace PacManProject
{
    class Monster : Cell
    {
        public Direction dir;
        private string str; 
        public Monster(int r, int c)
            : base(r, c)
        {
            dir = Direction.RIGHT;
            Random rd = new Random();
            str = Convert.ToString((rd.Next(12)+r)%12);
        }
        public override void DrawImage(Graphics g, int x, int y, int width, int height)
        {

            Point p = new Point(x+5, y+5);
            Point p1 = new Point(x+width, y+5);
            Point p2 = new Point(x+5, y+height);
            Point[] pt = { p,p1,p2 };

            Image image = Image.FromFile("monster" + str + ".jpg");
            g.DrawImage(image, pt);
            //g.FillEllipse(Brushes.Black, x, y, width, height);
            //g.FillRectangle(Brushes.Red, x + 5, y + 5, width / 4, height / 10);
            //g.FillRectangle(Brushes.Red, x + width - width / 4 - 5, y + 5, width / 4, height / 10);
            //g.FillRectangle(Brushes.Red, x + width / 2 - width / 4, y + height / 2 + 5, width / 2, height / 10);
        }

        private Block Next(Scene scene)
        {
            
            switch (dir)
            {
                default:
                case Direction.UP:
                    return scene[r - 1, c];
                case Direction.DOWN:
                    return scene[r + 1, c];
                case Direction.LEFT:
                    return scene[r, c - 1];
                case Direction.RIGHT:
                    return scene[r, c + 1];
            }
        }

        public void Move(Scene scene)
        {
                Block nextBlock = Next(scene);
                if (nextBlock.IsReachable())
                {
                    this.r = nextBlock.R;
                    this.c = nextBlock.C;
                }
                else
                {
                    //当遇墙后，随机给定一个方向
                    Random random = new Random();
                    dir = (Direction)random.Next(0, 4);
                    
                }

        }
    }
}