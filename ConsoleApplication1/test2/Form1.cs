﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool b = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                b = true;
                button1.Text = "停止";
                Thread th = new Thread(PlayGame);
                th.IsBackground = true;
                th.Start();
                //th.Join();
            }
            else
            {
                b = false;
                button1.Text = "开始";
            }
          
           

            //PlayGame();
        }

        private void PlayGame() {
            Random r = new Random();
            while (b) {
                label1.Text = r.Next(0, 9).ToString();
                label2.Text = r.Next(0, 9).ToString();
                label3.Text = r.Next(0, 9).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
