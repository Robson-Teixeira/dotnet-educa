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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            /*this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.TopMost = true;*/
        }

        private void SairU_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home novo = new Home();
            novo.Show();
        }

        private void Cadastar_Click(object sender, EventArgs e)
        {
            Cadastro novo = new Cadastro();
            novo.Show();
                        
        }
    }
}
