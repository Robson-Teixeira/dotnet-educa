﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDUCA
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alfabeto novo = new Alfabeto();
            novo.Show();
            this.Hide();
        }
    }
}
