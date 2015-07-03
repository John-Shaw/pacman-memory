using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace PacManProject
{
    public partial class Rank : Form
    {

        private  string first, second, third;
        public Rank()
        {
            InitializeComponent();
        }


        private void Rank_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("score.txt", System.Text.Encoding.GetEncoding("GB2312"));
            first = sr.ReadLine();
            second = sr.ReadLine();
            third = sr.ReadLine();
            label4.Text = first;
            label5.Text = second;
            label6.Text = third;
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}