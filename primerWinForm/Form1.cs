using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primerWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //algo();
        }

        private void algo() {

            MessageBox.Show("Hola " + txtNombre.Text + ", Bienvenido.");
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            algo();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Gracias por usar la app");
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            frmSegundaVentana ventana = new frmSegundaVentana();
            ventana.Show();
        }
    }
}
