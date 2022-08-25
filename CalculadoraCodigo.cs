using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForm
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                lbl1.Text = "+";
                a = int.Parse(txt1.Text);
                b = int.Parse(txt2.Text);
                lblResultado.Text = (a + b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                lbl1.Text = "-";
                a = int.Parse(txt1.Text);
                b = int.Parse(txt2.Text);
                lblResultado.Text = (a - b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                lbl1.Text = "*";
                a = int.Parse(txt1.Text);
                b = int.Parse(txt2.Text);
                lblResultado.Text = (a * b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            { 
            int a, b;
            lbl1.Text = "/";
            a = int.Parse(txt1.Text);
            b = int.Parse(txt2.Text);
            lblResultado.Text = (a / b).ToString();
        
            }catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Não é possível dividir por zero");
            }
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                lbl1.Text = "C";
                a = int.Parse(txt1.Text);
                b = int.Parse(txt2.Text);
                if (a > b)
                {
                    lblResultado.Text = (a + " é o maior e " + b + " menor");
                }
                else if (b > a)
                {
                    lblResultado.Text = (b + " é o maior e " + a + " menor");
                }
              

            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void btnParImpar_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                lbl1.Text = "P-I";
                a = int.Parse(txt1.Text);
                b = int.Parse(txt2.Text);
                if (a % 2 == 0 & b % 2 == 0)
                {
                    lblResultado.Text = (a + " e " + b + " são pares ");
                }
                else if (a % 2 == 0 & b % 2 != 0)
                {
                    lblResultado.Text = (a + " e " + b + " são impares ");
                }
                else if (a % 2 == 0 & b % 2 != 0)
                {
                    lblResultado.Text = (a + " é par e " + b + " é impar");
                }
                else if (a % 2 != 0 & b % 2 == 0)
                {
                    lblResultado.Text = (a + " é impar e " + b + " é par");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            lbl1.Text = "?";
            lblResultado.Text = "";
            txt1.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

