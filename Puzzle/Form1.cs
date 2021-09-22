using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class Form1 : Form
    {
        string[,] MatrizInicial = new string[3, 3];
        string[,] MatrizFinal = new string[3, 3];
        int countFinal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Embaralhar(object sender, EventArgs e)
        {
            
        }

        private void Definir(object sender, EventArgs e)
        {
            MatrizInicial[0, 0] = btnI1.Text;
            MatrizInicial[0, 1] = btnI2.Text;
            MatrizInicial[0, 2] = btnI3.Text;
            MatrizInicial[1, 0] = btnI4.Text;
            MatrizInicial[1, 1] = btnI5.Text;
            MatrizInicial[1, 2] = btnI6.Text;
            MatrizInicial[2, 0] = btnI7.Text;
            MatrizInicial[2, 1] = btnI8.Text;
            MatrizInicial[2, 2] = btnI0.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void preencherFinal(Button btn)
        {
            if (this.countFinal == 0)
            {
                btnF1.Text = btn.Text;
                this.countFinal++;
            }
            else
            if (this.countFinal == 1)
            {
                btnF2.Text = btn.Text;
                this.countFinal++;
            }
            else
            if (this.countFinal == 2)
            {
                btnF3.Text = btn.Text;
                this.countFinal++;
            }
            else
            if (this.countFinal == 3)
            {
                btnF4.Text = btn.Text;
                this.countFinal++;
            }
            else
            if (this.countFinal == 4)
            {
                btnF5.Text = btn.Text;
                this.countFinal++;
            }
            else
            if (this.countFinal == 5)
            {
                btnF6.Text = btn.Text;
                this.countFinal++;
            }
            else
            if (this.countFinal == 6)
            {
                btnF7.Text = btn.Text;
                this.countFinal++;
            }
            else
            if (this.countFinal == 7)
            {
                btnF8.Text = btn.Text;
                this.countFinal++;
            }
            else
            if(this.countFinal == 8)
            {
                btnF0.Text = btn.Text;
                this.countFinal++;
            }
        }

        private void btnEF1_Click(object sender, EventArgs e)
        {
            this.preencherFinal(btnEF1);
            btnEF1.Enabled = false;
        }

        private void btnEF2_Click(object sender, EventArgs e)
        {
            this.preencherFinal(btnEF2);
            btnEF2.Enabled = false;
        }

        private void btnEF3_Click(object sender, EventArgs e)
        {
            this.preencherFinal(btnEF3);
            btnEF3.Enabled = false;
        }

        private void btnEF4_Click(object sender, EventArgs e)
        {
            this.preencherFinal(btnEF4);
            btnEF4.Enabled = false;
        }

        private void btnEF5_Click(object sender, EventArgs e)
        {
            this.preencherFinal(btnEF5);
            btnEF5.Enabled = false;
        }

        private void btnEF6_Click(object sender, EventArgs e)
        {
            this.preencherFinal(btnEF6);
            btnEF6.Enabled = false;
        }

        private void btnEF7_Click(object sender, EventArgs e)
        {
            this.preencherFinal(btnEF7);
            btnEF7.Enabled = false;
        }

        private void btnEF_Click(object sender, EventArgs e)
        {
            this.preencherFinal(btnEF8);
            btnEF8.Enabled = false;
        }

        private void btnEF0_Click(object sender, EventArgs e)
        {
            this.preencherFinal(btnEF0);
            btnEF0.Enabled = false;
        }

        private void btnRestartEF_Click(object sender, EventArgs e)
        {
            this.countFinal = 0;
            btnEF0.Enabled = true;
            btnF0.Text = "";
            btnEF1.Enabled = true;
            btnF1.Text = "";
            btnEF2.Enabled = true;
            btnF2.Text = "";
            btnEF3.Enabled = true;
            btnF3.Text = "";
            btnEF4.Enabled = true;
            btnF4.Text = "";
            btnEF5.Enabled = true;
            btnF5.Text = "";
            btnEF6.Enabled = true;
            btnF6.Text = "";
            btnEF7.Enabled = true;
            btnF7.Text = "";
            btnEF8.Enabled = true;
            btnF8.Text = "";
        }

    }
}
