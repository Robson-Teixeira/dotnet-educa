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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();

            idade.Items.Add("");
            idade.Items.Add(" ADMINISTRADOR.");
            idade.Items.Add(" 5 Anos.");
            idade.Items.Add(" 6 Anos.");
            idade.Items.Add(" 7 Anos.");
            idade.Items.Add(" 8 Anos.");
            idade.Items.Add(" 9 Anos.");
            idade.Items.Add(" 10 Anos.");
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt1.Text = openFileDialog1.FileName;
                foto.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void sairC_Click(object sender, EventArgs e)
        {
            this.Close();
                        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void limpar_Click(object sender, EventArgs e)
        {
            txtnome.Text = "";
            txt1.Text = "";
            idade.Text = "";
            foto.ImageLocation = "";
        }
    }
}
