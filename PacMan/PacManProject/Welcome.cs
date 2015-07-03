using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Runtime.InteropServices;


namespace PacManProject
{
    public partial class Welcome : Form
    {
        public static uint SND_ASYNC = 0x0001;          // play asynchronously 
        public static uint SND_FILENAME = 0x00020000;   // name is file name
        [DllImport("winmm.dll")]
        public static extern int mciSendString(string m_strCmd, string m_strReceive, int m_v1, int m_v2);
        [DllImport("Kernel32", CharSet = CharSet.Auto)]
        static extern Int32 GetShortPathName(String path, StringBuilder shortPath, Int32 shortPathLength);

        public string name;

        public Welcome()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                name = textBox1.Text;
                mciSendString(@"close wel", null, 0, 0);
                Stream profile = new FileStream("name.txt", FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(profile, Encoding.GetEncoding("GB2312"));
                sw.WriteLine(name);
                sw.Close();

                Game start = new Game();
                start.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("«Î ‰»Î–’√˚");
            }

            
            
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            mciSendString(@"open " + @"welcome.mp3" + " alias wel", null, 0, 0);
            mciSendString("play wel repeat", null, 0, 0);
        }



    }
}