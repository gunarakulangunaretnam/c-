﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebContentGet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            webBrowser1.Document.GetElementById("se").InnerText = textBox1.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            webBrowser1.Document.GetElementById("search").InvokeMember("click");


        }
    }
}
