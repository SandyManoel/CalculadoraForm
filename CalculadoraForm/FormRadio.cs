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
    public partial class CalculadoraRadio : Form
    {
        public CalculadoraRadio()
        {
            InitializeComponent();
        }

        private void radioBtn1_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(txt1.Text);
            b = int.Parse(txt2.Text);
            try
            {
                if (radioBtn1.Checked == true)
                {
                    lblResultado.Text = (a + b).ToString();

                }

                else if (radioBtn2.Checked == true)
                {
                    lblResultado.Text = (a - b).ToString();
                }
                else if (radioBtn3.Checked == true)
                {
                    lblResultado.Text = (a * b).ToString();
                }
                else if (radioBtn4.Checked == true)

                try
                {
                    {
                        lblResultado.Text = (a / b).ToString();
                    }
                    }
                    catch (DivideByZeroException)
                    {
                        MessageBox.Show("Não é possível dividir por zero");
                    }

            }
            catch (FormatException)
            {

                MessageBox.Show("Informe apenas números! ");
            }
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            
            lblResultado.Text = "";
            txt1.Focus();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CalculadoraRadio_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
    }
}

    


