﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class Account_Create : Form
    {
        public Account_Create()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form form = new Register();
            form.ShowDialog();
        }

        private void btnCarSearch_Click(object sender, EventArgs e)
        {
            Form car=new Car_Brands();
            car.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form parts=new Car_parts(); 
            parts.ShowDialog();
        }
    }
}
