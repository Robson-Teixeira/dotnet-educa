namespace EDUCA
{
    partial class Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SairU = new System.Windows.Forms.Button();
            this.Cadastar = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EDUCA.Properties.Resources.assinatura_5;
            this.pictureBox1.Location = new System.Drawing.Point(481, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SairU
            // 
            this.SairU.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SairU.BackgroundImage = global::EDUCA.Properties.Resources.images__3_;
            this.SairU.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SairU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SairU.Location = new System.Drawing.Point(1108, 620);
            this.SairU.Name = "SairU";
            this.SairU.Size = new System.Drawing.Size(123, 40);
            this.SairU.TabIndex = 12;
            this.SairU.Text = "Sair";
            this.SairU.UseVisualStyleBackColor = true;
            this.SairU.Click += new System.EventHandler(this.SairU_Click);
            // 
            // Cadastar
            // 
            this.Cadastar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Cadastar.BackgroundImage = global::EDUCA.Properties.Resources.images__3_;
            this.Cadastar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cadastar.Location = new System.Drawing.Point(825, 620);
            this.Cadastar.Name = "Cadastar";
            this.Cadastar.Size = new System.Drawing.Size(123, 40);
            this.Cadastar.TabIndex = 13;
            this.Cadastar.Text = "Cadastrar";
            this.Cadastar.UseVisualStyleBackColor = true;
            this.Cadastar.Click += new System.EventHandler(this.Cadastar_Click);
            // 
            // Home
            // 
            this.Home.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Home.BackgroundImage = global::EDUCA.Properties.Resources.images__3_;
            this.Home.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Home.Location = new System.Drawing.Point(969, 623);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(123, 40);
            this.Home.TabIndex = 14;
            this.Home.Text = "Iniciar";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = global::EDUCA.Properties.Resources.Frame_6724;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 690);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Cadastar);
            this.Controls.Add(this.SairU);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SairU;
        private System.Windows.Forms.Button Cadastar;
        private System.Windows.Forms.Button Home;

    }
}