namespace PacManProject
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重玩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.美利坚ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.伊拉克ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.天朝ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.排行榜ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.难度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.虐菜ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.鏖战ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自杀ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EatBean = new System.Windows.Forms.Timer(this.components);
            this.Play = new PacMan.MyPanel();
            this.帮助ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.游戏ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.难度ToolStripMenuItem,
            this.排行榜ToolStripMenuItem,
            this.帮助ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 游戏ToolStripMenuItem
            // 
            this.游戏ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.暂停ToolStripMenuItem,
            this.重玩ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.游戏ToolStripMenuItem.Name = "游戏ToolStripMenuItem";
            this.游戏ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.游戏ToolStripMenuItem.Text = "游戏";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.开始ToolStripMenuItem.Text = "开始";
            this.开始ToolStripMenuItem.Click += new System.EventHandler(this.开始ToolStripMenuItem_Click);
            // 
            // 暂停ToolStripMenuItem
            // 
            this.暂停ToolStripMenuItem.Name = "暂停ToolStripMenuItem";
            this.暂停ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.暂停ToolStripMenuItem.Text = "暂停";
            this.暂停ToolStripMenuItem.Click += new System.EventHandler(this.暂停ToolStripMenuItem_Click);
            // 
            // 重玩ToolStripMenuItem
            // 
            this.重玩ToolStripMenuItem.Name = "重玩ToolStripMenuItem";
            this.重玩ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.重玩ToolStripMenuItem.Text = "重玩";
            this.重玩ToolStripMenuItem.Click += new System.EventHandler(this.重玩ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.美利坚ToolStripMenuItem,
            this.伊拉克ToolStripMenuItem,
            this.天朝ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.帮助ToolStripMenuItem.Text = "关卡";
            // 
            // 美利坚ToolStripMenuItem
            // 
            this.美利坚ToolStripMenuItem.Name = "美利坚ToolStripMenuItem";
            this.美利坚ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.美利坚ToolStripMenuItem.Text = "美利坚";
            this.美利坚ToolStripMenuItem.Click += new System.EventHandler(this.美利坚ToolStripMenuItem_Click);
            // 
            // 伊拉克ToolStripMenuItem
            // 
            this.伊拉克ToolStripMenuItem.Name = "伊拉克ToolStripMenuItem";
            this.伊拉克ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.伊拉克ToolStripMenuItem.Text = "伊拉克";
            this.伊拉克ToolStripMenuItem.Click += new System.EventHandler(this.伊拉克ToolStripMenuItem_Click);
            // 
            // 天朝ToolStripMenuItem
            // 
            this.天朝ToolStripMenuItem.Name = "天朝ToolStripMenuItem";
            this.天朝ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.天朝ToolStripMenuItem.Text = "天朝";
            this.天朝ToolStripMenuItem.Click += new System.EventHandler(this.天朝ToolStripMenuItem_Click);
            // 
            // 排行榜ToolStripMenuItem
            // 
            this.排行榜ToolStripMenuItem.Name = "排行榜ToolStripMenuItem";
            this.排行榜ToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.排行榜ToolStripMenuItem.Text = "排行榜";
            this.排行榜ToolStripMenuItem.Click += new System.EventHandler(this.排行榜ToolStripMenuItem_Click);
            // 
            // 难度ToolStripMenuItem
            // 
            this.难度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.虐菜ToolStripMenuItem,
            this.鏖战ToolStripMenuItem,
            this.自杀ToolStripMenuItem});
            this.难度ToolStripMenuItem.Name = "难度ToolStripMenuItem";
            this.难度ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.难度ToolStripMenuItem.Text = "难度";
            // 
            // 虐菜ToolStripMenuItem
            // 
            this.虐菜ToolStripMenuItem.Name = "虐菜ToolStripMenuItem";
            this.虐菜ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.虐菜ToolStripMenuItem.Text = "虐菜娱乐";
            this.虐菜ToolStripMenuItem.Click += new System.EventHandler(this.虐菜ToolStripMenuItem_Click);
            // 
            // 鏖战ToolStripMenuItem
            // 
            this.鏖战ToolStripMenuItem.Name = "鏖战ToolStripMenuItem";
            this.鏖战ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.鏖战ToolStripMenuItem.Text = "可堪一战";
            this.鏖战ToolStripMenuItem.Click += new System.EventHandler(this.鏖战ToolStripMenuItem_Click);
            // 
            // 自杀ToolStripMenuItem
            // 
            this.自杀ToolStripMenuItem.Name = "自杀ToolStripMenuItem";
            this.自杀ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.自杀ToolStripMenuItem.Text = "过来领死";
            this.自杀ToolStripMenuItem.Click += new System.EventHandler(this.自杀ToolStripMenuItem_Click);
            // 
            // EatBean
            // 
            this.EatBean.Tick += new System.EventHandler(this.EatBean_Tick);
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.SystemColors.Window;
            this.Play.Location = new System.Drawing.Point(12, 28);
            this.Play.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(960, 600);
            this.Play.TabIndex = 5;
            this.Play.Paint += new System.Windows.Forms.PaintEventHandler(this.Play_Paint);
            // 
            // 帮助ToolStripMenuItem1
            // 
            this.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1";
            this.帮助ToolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.帮助ToolStripMenuItem1.Text = "帮助";
            this.帮助ToolStripMenuItem1.Click += new System.EventHandler(this.帮助ToolStripMenuItem1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(985, 644);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Game";
            this.Text = "Pacman - Code by John Shaw";
            this.Load += new System.EventHandler(this.Game_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private PacMan.MyPanel Play;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重玩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.Timer EatBean;
        private System.Windows.Forms.ToolStripMenuItem 美利坚ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 伊拉克ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 天朝ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 排行榜ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 难度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 虐菜ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 鏖战ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自杀ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem1;
    }
}

