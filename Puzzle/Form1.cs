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

        public Form1()
        {
            InitializeComponent();
        }

        private void Embaralhar(object sender, EventArgs e)
        {
            
        }

        private void Definir(object sender, EventArgs e)
        {
            tb1.Enabled = false;
            tb2.Enabled = false;
            tb3.Enabled = false;
            tb4.Enabled = false;
            tb5.Enabled = false;
            tb6.Enabled = false;
            tb7.Enabled = false;
            tb8.Enabled = false;
            tb9.Enabled = false;

            MatrizInicial[0, 0] = btn1.Text = tb1.Text;
            MatrizInicial[0, 1] = btn2.Text = tb2.Text;
            MatrizInicial[0, 2] = btn3.Text = tb3.Text;
            MatrizInicial[1, 0] = btn4.Text = tb4.Text;
            MatrizInicial[1, 1] = btn5.Text = tb5.Text;
            MatrizInicial[1, 2] = btn6.Text = tb6.Text;
            MatrizInicial[2, 0] = btn7.Text = tb7.Text;
            MatrizInicial[2, 1] = btn8.Text = tb8.Text;
            MatrizInicial[2, 2] = btn9.Text = tb9.Text;
        }
    }
}
