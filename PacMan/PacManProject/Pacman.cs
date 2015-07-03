using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
namespace PacManProject
{
    public enum Direction { UP,DOWN,LEFT,RIGHT};
    class Pacman:Cell
    {
        private Direction direction;
        private bool isRunning;
        private int degree;
        private bool eatBean;
        

        public Pacman(int r, int c)
            : base(r, c)
        {
            direction = Direction.RIGHT;
            isRunning = false;
            degree = 300;
            eatBean = false;
        }


        public override void DrawImage(Graphics g,int x, int y,int width,int height)
        {
            switch (direction)
            {
                default:
                case Direction.UP:
                    g.FillPie(Brushes.Gold, x + 5, y + 5, width - 10, height - 10, (180 - degree) / 2, degree);
                    g.FillEllipse(Brushes.Black, x  + 8, y + height/2-3, 3, 3);
                    break;
                case Direction.DOWN:
                    g.FillPie(Brushes.Gold, x + 5, y + 5, width - 10, height - 10, (degree - 180) / 2, -degree);
                    g.FillEllipse(Brushes.Black, x + 8, y + height / 2 + 3, 3, 3);
                    break;
                case Direction.RIGHT:
                    g.FillPie(Brushes.Gold, x + 5, y + 5, width - 10, height - 10, (360 - degree) / 2, degree);
                    g.FillEllipse(Brushes.Black, x + width / 2 + 3, y + 8, 3, 3);
                    break;
                case Direction.LEFT:
                    g.FillPie(Brushes.Gold, x + 5, y + 5, width - 10, height - 10, degree / 2, -degree);
                    g.FillEllipse(Brushes.Black, x + width / 2 - 3, y + 8, 3, 3);
                    break;
            }
        }

        private Block Next(Scene scene)
        {
            switch (direction)
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
            if (isRunning)
            {
                Block nextBlock = Next(scene);
                if (nextBlock.IsEatable() && nextBlock.IsReachable())
                {
                    eatBean = true;
                    //将pacman所在块清空
                    scene[r, c] = new Empty(r, c);
                    //pacman移动到下一位置
                    this.r = nextBlock.R;
                    this.c = nextBlock.C;
                    //下一位置置为空块
                    scene[r, c] = new Empty(r, c);
                    //吃金豆，并加分
                    scene.BeanNum--;
                    scene.Score += 10;
                    
                }
                else if (nextBlock.IsReachable())
                {
                    this.r = nextBlock.R;
                    this.c = nextBlock.C;
                }
                else 
                {
                    isRunning = false;
                }
            }
        }

        //是否死亡
        public bool BeEat(Monster monster)
        {
            if (monster.C == this.c && monster.R == this.r)
                return true;
            else
                return false;
        }

        public void ChangeDirection(Keys keyData, Scene scene)
        {
            Block nextBlock=null;
            Direction  newDir=direction;
            switch (keyData)
            {
                case Keys.Up:
                    nextBlock = scene[r - 1, c];
                    newDir = Direction.UP;
                    break;
                case Keys.Down:
                    nextBlock = scene[r + 1, c];
                    newDir = Direction.DOWN;
                    break;
                case Keys.Left:
                    nextBlock = scene[r, c - 1];
                    newDir = Direction.LEFT;
                    break;
                case Keys.Right:
                    nextBlock = scene[r, c + 1];
                    newDir = Direction.RIGHT;
                    break;
            }
            if (nextBlock != null) {
                if (nextBlock.IsReachable())
                {
                    direction = newDir;
                    IsRunning = true;

                }
            }


        }
        public Direction CurDirection
        {
            get { return direction; }
            set { direction = value; }
        }
        public bool IsRunning
        {
            get { return isRunning;}
            set { isRunning = value;}
        }
        public bool EatBean
        {
            get { return eatBean; }
            set { eatBean  = value; }
        }
        public int  Degree
        {
            get { return degree; }
            set { degree = value; }
        }
    }
}
