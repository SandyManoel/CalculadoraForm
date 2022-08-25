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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBotoes objFormBotoes = new FormBotoes();
            objFormBotoes.MdiParent = this;
            objFormBotoes.Show();

        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.LayoutMdi(MdiLayout.Cascade);

        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void comRadioButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculadoraRadio objFormRadio = new CalculadoraRadio();
            objFormRadio.MdiParent = this;
            objFormRadio.Show();
        }

        private void superToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNumeros objFormNumeros = new FormNumeros();
            objFormNumeros.MdiParent = this;
            objFormNumeros.Show();
        }

       

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
    }
}
