using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace PacManProject
{
    public partial class Game : Form
    {

        public static uint SND_ASYNC = 0x0001;          // play asynchronously 
        public static uint SND_FILENAME = 0x00020000;   // name is file name
        [DllImport("winmm.dll")]
        public static extern int mciSendString(string m_strCmd, string m_strReceive, int m_v1, int m_v2);
        [DllImport("Kernel32", CharSet = CharSet.Auto)]
        static extern Int32 GetShortPathName(String path, StringBuilder shortPath, Int32 shortPathLength);

        string name = "";                       //用户名
        int first_score, second_score, third_score;//存储一二三名的得分
        string first_name, second_name, third_name;//存储一二三名的名字


        private Scene myScene;
        private int type;
        private int lev;

        private int score=0;

        public int Score
        {
            get { return myScene.Score * (lev + type) / 2; }
            set { score = value; }
        }
        
       

        public Game()
        {
            InitializeComponent();
            type = 1;
            lev = 2;
            Lev2();
            
        }


        private void Game_Load(object sender, EventArgs e)
        {
            myScene = new Scene(Play.BackColor, type);
            EatBean.Interval = 400;
            ReadScore_Name();
            mciSendString(@"open " + @"win.mp3" + " alias win", null, 0, 0);
            mciSendString("play win repeat", null, 0, 0);
        }


        public bool Die()
        {
            for (int i = 0; i < this.type; i++)
            {
                if (myScene.GetPacman().BeEat(myScene.GetMonster(i)))
                    return true;
            }
            return false;
        }

        public void GameStart()
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            mciSendString(@"close lost", null, 0, 0);
            mciSendString(@"close win", null, 0, 0);
            mciSendString(@"open " + @"BGM.mp3" + " alias bgm", null, 0, 0);
            mciSendString("play bgm repeat", null, 0, 0);
        }

        public void GameOver()
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            mciSendString(@"close bgm", null, 0, 0);
            myScene = new Scene(Play.BackColor, type);
        }
        public void GameStop()
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            mciSendString(@"stop bgm", null, 0, 0);
        }


        public void Lev1()
        {
            timer1.Interval = 250;
            timer2.Interval = 400;
            timer3.Interval = 1200;
        }

        public void Lev2()
        {
            timer1.Interval = 200;
            timer2.Interval = 100;
            timer3.Interval = 500;
        }

        public void Lev3()
        {
            timer1.Interval = 100;
            timer2.Interval = 1;
            timer3.Interval = 10;
        }
        

        private void Play_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            if(!timer1.Enabled)
            {
                Point p = new Point(0, 0);
                Point p1 = new Point(Play.Width, 0);
                Point p2 = new Point(0, Play.Height);
                Point[] pt = { p,p1,p2 };
                Image image = Image.FromFile("Back.jpg");
                g.DrawImage(image, pt);
                
                StreamReader sr = new StreamReader("name.txt", System.Text.Encoding.GetEncoding("GB2312"));
                name = sr.ReadLine();
                g.DrawString(String.Format("welcome"), new Font("华文新魏", 50), Brushes.Gold, 325, 100);
                g.DrawString(String.Format(name), new Font("华文新魏", 50), Brushes.White, 400, 450);
            }
            else if (Die())
            {
                GameOver();
                Point p = new Point(0, 0);
                Point p1 = new Point(Play.Width, 0);
                Point p2 = new Point(0, Play.Height);
                Point[] pt = { p, p1, p2 };
                Image image = Image.FromFile("GameOver.jpg");
                g.DrawImage(image, pt);
                mciSendString(@"open " + @"lost.mp3" + " alias lost", null, 0, 0);
                mciSendString("play lost", null, 0, 0);
                //myScene.Draw(g, e.ClipRectangle);
                //g.DrawString(String.Format("你被吃掉了"), new Font("微软雅黑", 50), Brushes.Red, 200, 150);
                //g.DrawString(String.Format("~~(╯﹏╰)b"), new Font("微软雅黑", 50), Brushes.Red, 200, 250);
            }
            else if (myScene.BeanNum == 0)
            {
                SaveScore();
                GameOver();
                Point p = new Point(0, 0);
                Point p1 = new Point(Play.Width, 0);
                Point p2 = new Point(0, Play.Height);
                Point[] pt = { p, p1, p2 };
                Image image = Image.FromFile("win.jpg");
                g.DrawImage(image, pt);
                mciSendString(@"open " + @"win.mp3" + " alias win", null, 0, 0);
                mciSendString("play win", null, 0, 0);
                //myScene.Draw(g, Play.ClientRectangle,type);
                //g.DrawString(String.Format("你赢了哈哈"), new Font("微软雅黑", 50), Brushes.Orange, 200, 150);
                //g.DrawString(String.Format("O(∩_∩)O~"), new Font("微软雅黑", 50), Brushes.Orange, 200, 250);
            }
            else
            {
                myScene.Draw(g, Play.ClientRectangle,type);
                g.DrawString(String.Format("剩余金豆：{0}", myScene.BeanNum), new Font("微软雅黑", 15), Brushes.Goldenrod, 800, 0);
                g.DrawString(String.Format("得分 ： {0}", Score), new Font("微软雅黑", 15), Brushes.Goldenrod, 800, 30);
                
            }   
        }


        private void MouthChange()
        {
            if (myScene.GetPacman().Degree == 270)
            { myScene.GetPacman().Degree = 300; }
            else if (myScene.GetPacman().Degree == 300)
            {
                myScene.GetPacman().Degree = 330;
            }
            else
                myScene.GetPacman().Degree = 270;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            MouthChange();
            if (myScene.GetPacman().EatBean)           
            {
                mciSendString(@"open " + @"eatBean.mp3" + " alias eatBean", null, 0, 0);
                mciSendString("play eatBean", null, 0, 0);
                myScene.GetPacman().EatBean=false;
                EatBean.Start();
            }

            myScene.GetPacman().Move(myScene);

            Play.Invalidate();
            Play.Update();

        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (timer1.Enabled)
            {
                switch (keyData)
                {
                    case Keys.Up:
                    case Keys.Down:
                    case Keys.Left:
                    case Keys.Right:
                        myScene.GetPacman().ChangeDirection(keyData, myScene);
                        break;
                    case Keys.Space:
                        GameStop();
                        break;
                    default: break;
                }
                Console.WriteLine(keyData);
                return true;
            }
            else
            {
                switch (keyData)
                {
                    case Keys.Enter:
                        GameStart();
                        break;
                    default: break;
                }
                Console.WriteLine(keyData);
                return true;
            }
            
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < this.type; i++)
            {
                myScene.GetMonster(i).Move(myScene);
                Play.Invalidate();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < this.type; i++)
            {
                myScene.GetMonster(i).dir = (Direction)random.Next(0, 4);
            }
            
        }

        private void 开始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameStart();
            
        }

        private void 暂停ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameStop();
        }

        private void 重玩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameOver();
            Play.Invalidate();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //这里将关闭键重写，因为直接关闭无法将调用的音乐资源，和原来的Welcome窗口关闭
        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EatBean_Tick(object sender, EventArgs e)
        {
            mciSendString(@"close eatBean", null, 0, 0);
            EatBean.Stop();
        }

        private void 美利坚ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = 1;
            myScene = new Scene(Play.BackColor, type);
            GameStart();
        }

        private void 伊拉克ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = 2;
            myScene = new Scene(Play.BackColor, type);
            GameStart();
        }

        private void 天朝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = 3;
            myScene = new Scene(Play.BackColor, type);
            GameStart();
        }


        //读取用户名和前三名的名字和分数
        public void ReadScore_Name()
        {
            StreamReader sr1 = new StreamReader("name.txt", System.Text.Encoding.GetEncoding("GB2312"));
            name = sr1.ReadLine();                                //读取用户名

            sr1 = new StreamReader("score.txt", System.Text.Encoding.GetEncoding("GB2312"));
            string temps = "";                      //n用来存储名字
            int k = 0;                               //全局变量k用来记录读到line的那一个字符
            string line = sr1.ReadLine();
            for (k = 0; line[k] != ' '; k++)          //读取name 
            {
                temps += line[k].ToString();
            }
            first_name = temps;
            k++;
            temps = "";
            for (; k < line.Length; k++)               // 读取分数
            {
                temps += line[k].ToString();
            }
            first_score = Convert.ToInt32(temps);

            k = 0;
            temps = "";
            line = sr1.ReadLine();
            for (k = 0; line[k] != ' '; k++)          //读取name 
            {
                temps += line[k].ToString();
            }
            second_name = temps;
            temps = "";
            k++;
            for (; k < line.Length; k++)               // 读取分数
            {
                temps += line[k].ToString();
            }
            second_score = Convert.ToInt32(temps);

            k = 0;
            temps = "";
            line = sr1.ReadLine();
            for (k = 0; line[k] != ' '; k++)          //读取name 
            {
                temps += line[k].ToString();
            }
            third_name = temps;
            temps = "";
            k++;
            for (; k < line.Length; k++)               // 读取分数
            {
                temps += line[k].ToString();
            }
            third_score = Convert.ToInt32(temps);

            sr1.Close();
           
        }

        //储存分数（如果进前三的话）
        public void SaveScore()
        {
            if (Score > first_score)
            {
                third_name = second_name;       //第二变成第三
                third_score = second_score;
                second_name = first_name;       //第一变成第二
                second_score = first_score;
                first_name = name;              //当前的为第一名
                first_score = Score;
            }
            else if ((Score <= first_score) && (Score > second_score))
            {
                third_name = second_name;      //第二变成第三
                third_score = second_score;
                second_name = name;            //当前的为第二名
                second_score = Score;
            }
            else if ((Score <= second_score) && (Score > third_score))
            {
                third_name = name;              //当前的为第三名
                third_score = Score;
            }
            else
            {
                goto label;
            }

            //写文件
            Stream name_file = new FileStream("score.txt", FileMode.Create);
            StreamWriter dataSetStreamWriter = new StreamWriter(name_file, Encoding.GetEncoding("GB2312"));
            string tx = "";
            tx = (first_name + " " + Convert.ToString(first_score));
            dataSetStreamWriter.WriteLine(tx);
            tx = "";
            tx = (second_name + " " + Convert.ToString(second_score));
            dataSetStreamWriter.WriteLine(tx);
            tx = "";
            tx = (third_name + " " + Convert.ToString(third_score));
            dataSetStreamWriter.WriteLine(tx);

            dataSetStreamWriter.Close();
            name_file.Close();
        label: ;
        }

        private void 排行榜ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rank form = new Rank();
            form.Show();
        }

        private void 虐菜ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lev1();
            lev = 1;
            myScene = new Scene(Play.BackColor, type);
        }

        private void 鏖战ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lev2();
            lev = 2;
            myScene = new Scene(Play.BackColor, type);
        }

        private void 自杀ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lev3();
            lev = 3;
            myScene = new Scene(Play.BackColor, type);
        }

        private void 帮助ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }

        
        

    }
}