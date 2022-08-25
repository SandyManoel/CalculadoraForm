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
    public partial class FormNumeros : Form
    {
        double a, b, resultado, variavel;
        int op;
        bool res = false; //visor limpo
        bool limpar= false;
        

        public FormNumeros()
        {
            InitializeComponent();
       
        
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            btnCalcular.Focus();
            if (limpar == false)
            {
                limpar = true;
                txtResultado.Text = "";
            }
            if (res) 
               txtResultado.Text = "";
            res = false;
            if (res == false)
            {
                txtResultado.Text += Convert.ToString(0); 
                
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            btnCalcular.Focus();
            if (limpar==false)
            {
                limpar = true;
                txtResultado.Text = "";
            }
            
            if (txtResultado.Text=="0")
            {
                txtResultado.Text = "";
            }
            if (res)  
                txtResultado.Text = ""; 
            res = false;
            if (res == false) //serve para digitar o mesmo numero varias vezes
            {
                txtResultado.Text += Convert.ToString(1);
                if (a != 0)
                    b = 1;
                else 
                    a = 1;

            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btnCalcular.Focus();

            if (limpar == false)
            {
                limpar = true;
                txtResultado.Text = "";
            }
          
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }
            if (res)
                if (limpar==false)
                txtResultado.Text = "";
            res = false;
            if (res == false)
            {
                txtResultado.Text += Convert.ToString(2);
                if (a != 0)
                    b = 2;
                else
                    a = 2;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btnCalcular.Focus();
            if (limpar == false)
            {
                limpar = true;
                txtResultado.Text = "";
            }
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }
            if (res)
                if (res)
                txtResultado.Text = "";
            res = false;
            if (res == false)
            {
                txtResultado.Text += Convert.ToString(3);
                if (a != 0)
                    b = 3;
                else
                    a = 3;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btnCalcular.Focus();
            if (limpar == false)
            {
                limpar = true;
                txtResultado.Text = "";
            }
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }
            if (res)
                if (res)
                txtResultado.Text = "";
            res = false;
            if (res == false)
            {
                txtResultado.Text += Convert.ToString(4);
                if (a != 0)
                    b = 4;
                else
                    a = 4;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btnCalcular.Focus();
            if (limpar == false)
            {
                limpar = true;
                txtResultado.Text = "";
            }
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }
            if (res)
                if (res)
                txtResultado.Text = "";
            res = false;
            if (res == false)
            {
                txtResultado.Text += Convert.ToString(5);
                if (a != 0)
                    b = 5;
                else
                    a = 5;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btnCalcular.Focus();
            if (limpar == false)
            {
                limpar = true;
                txtResultado.Text = "";
            }
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }
            if (res)
                if (res)
                txtResultado.Text = "";
            res = false;
            if (res == false)
            {
                txtResultado.Text += Convert.ToString(6);
                if (a != 0)
                    b = 6;
                else
                    a = 6;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btnCalcular.Focus();
            if (limpar == false)
            {
                limpar = true;
                txtResultado.Text = "";
            }
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }
            if (res)
                if (res)
                txtResultado.Text = "";
            res = false;
            if (res == false)
            {
                txtResultado.Text += Convert.ToString(7);
                if (a != 0)
                    b = 7;
                else
                    a = 7;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btnCalcular.Focus();
            if (limpar == false)
            {
                limpar = true;
                txtResultado.Text = "";
            }
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }
            if (res)
                if (res)
                txtResultado.Text = "";
            res = false;
            if (res == false)
            {
                txtResultado.Text += Convert.ToString(8);
                if (a != 0)
                    b = 8;
                else
                    a = 8;
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            btnCalcular.Focus();
            if (limpar == false)
            {
                limpar = true;
                txtResultado.Text = "";
            }
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }
            if (res)
                if (res)
                txtResultado.Text = "";
            res = false;
            if (res == false)
            {
                txtResultado.Text += Convert.ToString(9);
                if (a != 0)
                    b = 9;
                else
                    a = 9;
            }
        }


        private void btnVirgula_Click(object sender, EventArgs e)
        {
            btnCalcular.Focus();
            int virg;
            virg = txtResultado.Text.IndexOf(",");
            if (virg >= 0) return;
            else txtResultado.Text += ",";
            
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            btnCalcular.Focus();
            op = 1;                         
            variavel = Convert.ToDouble(txtResultado.Text);
            if (limpar==true)
            {
                limpar = false;
            }

            
        }

  

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            btnCalcular.Focus();
            op = 2;                          
            variavel = Convert.ToDouble(txtResultado.Text);
            if (limpar == true)
            {
                limpar = false;
            }

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            btnCalcular.Focus();
            op = 3;
            variavel = Convert.ToDouble(txtResultado.Text);
            if (limpar == true)
            {
                limpar = false;
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            btnCalcular.Focus();
            try
            {
                op = 4;
                variavel = Convert.ToDouble(txtResultado.Text);
                if (limpar == true)
                {
                    limpar = false;
                }
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Não é possível dividir por zero! ");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            btnCalcular.Focus();
            b = Convert.ToDouble(txtResultado.Text);
            if (op ==1)
            {
                resultado = variavel + b;
                txtResultado.Text = (resultado).ToString();
                lbl1.Text = (variavel).ToString() + ("+") + (b);

            }
            else if (op==2) 
            {
                resultado = variavel - b;
                txtResultado.Text = (resultado).ToString();
                lbl1.Text = (variavel).ToString() + ("-") + (b);

            }
            else if (op == 3)
            {
                resultado = variavel * b;
                txtResultado.Text = (resultado).ToString();
                lbl1.Text = (variavel).ToString() + ("*") + (b);

            }
            else if (op == 4)
            {
                resultado = variavel / b;
                txtResultado.Text = (resultado).ToString();
                lbl1.Text = (variavel).ToString() + ("/") + (b);

            }
        }

        private void FormNumeros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void FormNumeros_Load(object sender, EventArgs e)

        {
            txtResultado.Focus();
            txtResultado.Text = "0";
        }



        private void btnFechar_Click(object sender, EventArgs e)
        {
            btnCalcular.Focus();
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            btnCalcular.Focus();
            txtResultado.Text=("0");
            lbl1.Text = "";
            
        }
    }
}
