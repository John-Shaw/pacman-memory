using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PacMan
{
    public class MyPanel : Panel
    {
        public MyPanel()
        {
            //启用双重缓冲,因为Panel类中不能修改
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }
    }
}
