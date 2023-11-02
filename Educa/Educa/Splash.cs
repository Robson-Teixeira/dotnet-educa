using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EDUCA
{
    public partial class Splash : Form
    {
        System.Media.SoundPlayer Player = new System.Media.SoundPlayer(@"C:\Users\Ágatha\Desktop\EDUCA\EDUCA\Resources\music.wav");
        public Splash()
        {
            InitializeComponent();
            Player.Play();
            backgroundWorker1.RunWorkerAsync();
         }

      
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
                progressBar1.Value = progressBar1.Value + 1;
            else
            {

                timer1.Enabled = false;
                this.Visible = false;
                Usuarios novo = new Usuarios();
                novo.ShowDialog();
                this.Close();

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                simulacao();
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            porcentagem.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        private void simulacao()
        {
            Thread.Sleep(100);
        }
    }
}
