﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessAllController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AccessAll(this.Controls);
        }


        void AccessAll(Control.ControlCollection cc) {

            foreach (Control c in cc) {

                c.Enabled = false;//Disabled all controllers.

                if (c.HasChildren) {

                    AccessAll(c.Controls);
                }
            }
        }
    }
}


