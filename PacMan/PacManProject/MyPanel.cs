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
            //����˫�ػ���,��ΪPanel���в����޸�
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }
    }
}
