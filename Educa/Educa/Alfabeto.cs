using System;
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
    public partial class Alfabeto : Form
    {
        public Alfabeto()
        {
            InitializeComponent();
        }

        private void Alfabeto_Load(object sender, EventArgs e)
        {

        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Close();
            Home novo = new Home();
            novo.Show();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

    }
}
