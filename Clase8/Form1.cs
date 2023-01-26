using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtEstado.Enabled = false;
            txtNF.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int NF, n1, n2, n3, n4;

            n1 = int.Parse(maskedTextBox1.Text);
            n2 = int.Parse(maskedTextBox4.Text);
            n3 = int.Parse(maskedTextBox3.Text);
            n4 = int.Parse(maskedTextBox2.Text);


            if (n1 < 0 || n1 > 25)
            {
                MessageBox.Show("El rango debe estar entre 0 y 25 ");
                maskedTextBox1.Text = "";
                maskedTextBox1.Focus();
            }
            if (n2 < 0 || n2 > 25)
            {
                MessageBox.Show("El rango debe estar entre 0 y 25 ");
                maskedTextBox4.Text = "";
                maskedTextBox4.Focus();
            }
            if (n3 < 0 || n3 > 25)
            {
                MessageBox.Show("El rango debe estar entre 0 y 25 ");
                maskedTextBox3.Text = "";
                maskedTextBox3.Focus();
            }
            if (n4 < 0 || n4 > 25)
            {
                MessageBox.Show("El rango debe estar entre 0 y 25 ");
                maskedTextBox2.Text = "";
                maskedTextBox2.Focus();
            }

            NF = n1 + n2 + n3 + n4;
            string a = "APROBADO", r = "REPROBADO";

            if (NF > 60)
            {
                txtEstado.Text = a;
            }
            else { txtEstado.Text = r; }

            txtNF.Text = NF.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            maskedTextBox4.Clear();
            maskedTextBox3.Clear();
            maskedTextBox2.Clear();
            txtNF.Clear();
            txtEstado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


