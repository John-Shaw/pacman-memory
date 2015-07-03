using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace PacManProject
{
    class Scene
    {
        private Block[,] map;
        private int row, col;
        private Pacman pacman;
        private int beanNum=0;
        private int score = 0;
        private Color backColor;
        public Monster []monster;


        public Scene(Color backColor,int type)
        {
            this.backColor = backColor;
            monster = new Monster[type];
            switch (type)
            {
                default:
                case 1:
                    InitMember1();
                    break;
                case 2:
                    InitMember2();
                    break;
                case 3:
                    InitMember3();
                    break;
            }
        }
        
        
        //初始化地图1
        private int[,] data1 ={ 
                               {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},   //此处第0行
                               {1,0,2,2,2,0,2,0,2,1,0,2,0,1,2,1},
                               {1,2,1,0,2,0,2,2,0,2,1,2,2,0,2,1},
                               {1,0,2,1,2,2,2,0,1,2,0,2,1,2,0,1},
                               {1,2,2,0,2,1,0,2,0,2,2,2,0,2,2,1},
                               {1,2,2,0,0,1,2,2,0,2,1,2,2,2,2,1},
                               {1,0,2,2,2,0,0,1,0,2,2,0,1,0,0,1},
                               {1,1,0,1,2,1,0,1,0,1,0,1,1,2,1,1},
                               {1,0,0,0,2,2,2,2,2,2,2,2,2,2,2,1},
                               {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
                             };
        public void InitMember1()
        {
            row = data1.GetLength(0);
            col = data1.GetLength(1);
            map = new Block[row,col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (data1[i, j] == 0)
                    {
                        map[i, j] = new Empty(i, j);
                    }
                    if (data1[i, j] == 1) {
                        map[i,j] = new Wall(i,j);
                    }
                    if(data1[i, j] == 2)
                    {
                        map[i,j] = new Bean(i,j);
                        beanNum++;
                    }
                }
            }
            pacman = new Pacman(1,1);
            monster[0] = new Monster(8, 2);
        }

        //初始化地图2
        private int[,] data2 ={ 
                               {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
                               {1,0,2,2,0,0,0,0,0,2,0,2,0,0,0,1},
                               {1,2,0,0,2,0,1,1,0,1,0,2,1,1,2,1},
                               {1,1,1,0,1,2,2,0,0,2,0,1,1,1,0,1},
                               {1,2,2,0,2,1,0,1,0,1,2,1,0,0,2,1},
                               {1,2,1,0,0,2,1,2,0,1,1,2,2,1,1,1},
                               {1,0,2,2,2,0,0,1,0,1,0,0,1,0,0,1},
                               {1,2,0,0,1,0,0,0,1,0,0,2,0,0,2,1},
                               {1,0,0,0,0,2,0,0,0,1,0,2,2,0,2,1},
                               {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
                             };
        public void InitMember2()
        {
            row = data2.GetLength(0);
            col = data2.GetLength(1);
            map = new Block[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (data2[i, j] == 0)
                    {
                        map[i, j] = new Empty(i, j);
                    }
                    if (data2[i, j] == 1)
                    {
                        map[i, j] = new Wall(i, j);
                    }
                    if (data2[i, j] == 2)
                    {
                        map[i, j] = new Bean(i, j);
                        beanNum++;
                    }
                }
            }
            pacman = new Pacman(1, 1);
            monster[0] = new Monster(8, 2);
            monster[1] = new Monster(6, 10);
        }

        //初始化地图3
        private int[,] data3 ={ 
                               {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
                               {1,0,2,2,1,2,2,2,2,1,2,2,2,2,2,1},
                               {1,2,1,2,1,2,1,1,2,1,2,2,1,2,2,1},
                               {1,2,2,1,2,2,1,2,2,2,2,1,2,1,2,1},
                               {1,1,2,2,1,2,2,1,2,1,2,2,2,2,2,1},
                               {1,2,2,2,2,1,2,2,2,1,1,2,2,2,1,1},
                               {1,1,2,2,2,2,1,1,2,2,2,2,1,2,2,1},
                               {1,2,2,2,1,2,2,2,2,2,2,2,1,2,2,1},
                               {1,2,2,1,2,2,1,2,2,1,2,2,2,2,1,1},
                               {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
                             };
        public void InitMember3()
        {
            row = data3.GetLength(0);
            col = data3.GetLength(1);
            map = new Block[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (data3[i, j] == 0)
                    {
                        map[i, j] = new Empty(i, j);
                    }
                    if (data3[i, j] == 1)
                    {
                        map[i, j] = new Wall(i, j);
                    }
                    if (data3[i, j] == 2)
                    {
                        map[i, j] = new Bean(i, j);
                        beanNum++;
                    }
                }
            }
            pacman = new Pacman(1, 1);
            monster[0] = new Monster(7, 2);
            monster[1] = new Monster(6, 1);
            monster[2] = new Monster(8, 10);
        }

        public void Draw(Graphics g, Rectangle room,int type)
        {
            int blockWidth = room.Width / col;
            int blockHeight = room.Height / row;
            
            for (int i = 0; i < map.GetLength(0); i++) 
            {
                for (int j = 0; j < map.GetLength(1); j++) 
                {
                    map[i, j].Draw(g, 0, 0, blockWidth, blockHeight);
                }
            
            }
            pacman.Draw(g, blockWidth, blockHeight);
            for (int i = 0; i < type; i++)
            {
                monster[i].Draw(g, blockWidth, blockHeight);
            }

        }
        public Color BackColor
        {
            get {
                return backColor;
            }
            set {
                backColor = value;
            }
        }
        public int BeanNum
        {
            get {
                return beanNum;
            }
            set {
                beanNum = value;
            }
        }
        public int Score
        {
            get{
               return score;
            }
            set{
               score = value;
            }
        }
        public Block this[int r, int c]
        {
            get 
            {
                return map[r, c];
            }
            set {

                map[r, c] = value;
            }
        }

        public Pacman GetPacman()
        {
            return this.pacman;
        }

        public Monster GetMonster(int type)
        {
            return this.monster[type];
        }

    }
}
