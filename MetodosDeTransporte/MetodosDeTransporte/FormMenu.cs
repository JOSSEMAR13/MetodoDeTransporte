using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosDeTransporte
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnCrearMatriz_Click(object sender, EventArgs e)
        {
            if (txtNumeroOrigenes.Text.Equals(""))
            {
                MessageBox.Show("Ingrese Número de Orígenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNumeroDestinos.Text.Equals(""))
            {
                MessageBox.Show("Ingrese Número de Destinos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(int.Parse(txtNumeroOrigenes.Text) >=1 && int.Parse(txtNumeroOrigenes.Text) <= 15))
            {
                MessageBox.Show("Ingrese el número de orígenes mayor o igual a 1 y menor o igual a 15", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!(int.Parse(txtNumeroDestinos.Text) >= 1 && int.Parse(txtNumeroDestinos.Text) <= 15))
            {
                MessageBox.Show("Ingrese el número de destinos mayor o igual a 1 y menor o igual a 15", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                int numeroorigenes = int.Parse(txtNumeroOrigenes.Text);
                int numerodestinos = int.Parse(txtNumeroDestinos.Text);
                FormGenerarTabla matrizgenerada = new FormGenerarTabla(numeroorigenes, numerodestinos);
                matrizgenerada.ShowDialog();
            }

        }
    }
}
