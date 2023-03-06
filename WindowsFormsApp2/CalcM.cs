using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class CalcM : Form
    {
        public CalcM()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butCalc_Click(object sender, EventArgs e)
        {
            aluno ALUNO = new aluno();

            ALUNO.Nome = txtNome.Text;
            ALUNO.Ra = txtRA.Text;
            ALUNO.P1 = double.Parse(txtP1.Text) ;
            ALUNO.P2 = double.Parse(txtP2.Text);

            txtMedia.Visible = false;

        }

        private void CalcM_Load(object sender, EventArgs e)
        {
            txtMedia.Visible = false;
        }
    }

    internal class aluno
    {
        public string Nome { get; internal set; }
        public string Ra { get; internal set; }
        public double P1 { get; internal set; }
        public double P2 { get; internal set; }
    }
}
