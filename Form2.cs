﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koleso
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            string psw = "12345678";
            if (psw == password.Text)
            {
                
                Form3 Reg = new Form3();
                Reg.ShowDialog();
            }
            

            else
            {
                Form4 Reg = new Form4();
                Reg.ShowDialog();
                
            }
            this.Close();
        }
    }
}
