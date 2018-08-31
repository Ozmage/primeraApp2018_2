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
    public partial class frmSegundaVentana : Form
    {
        private const string nombre = "MAXI";

        public frmSegundaVentana()
        {
            InitializeComponent();
        }

        private void frmSegundaVentana_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hola " + nombre);
            Text = "Segunda Ventana";
        }
    }
}
