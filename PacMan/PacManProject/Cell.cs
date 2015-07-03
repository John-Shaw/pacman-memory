using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace PacManProject
{
    abstract class Cell
    {
        protected int r, c;

        public Cell() : this(0, 0) { }

        public Cell(int r, int c)
        {
            this.r = r;
            this.c = c;
        }
        public void Draw(Graphics g,int cellWidth,int cellHeight)
        {
            Draw(g, 0, 0, cellWidth, cellHeight);
        }
        public void Draw(Graphics g,int left,int top,int cellWidth,int cellHeight)
        {
            int x, y;
            x = left+c*cellWidth;
            y = top+r*cellHeight;
            DrawImage(g,x,y,cellWidth,cellHeight);
        }
        public int R 
        {
            get {
                return r;
            }
            set {
                r = value;
            }
        
        }
        public int C
        {
            get {
                return c;
            }
            set {

                c = value;
            }
        }

        public abstract void DrawImage(Graphics g,int x,int y,int width,int height);
    }
}
