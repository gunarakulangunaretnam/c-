﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitwse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            short myShort = 15 << 1;//1111 << 1 == 11110
            MessageBox.Show(Convert.ToString(myShort,2));//2 means binary.
    
           //Right Shift

        }
    }
}
