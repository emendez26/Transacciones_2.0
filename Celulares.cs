using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_inventario
{
    public partial class Celulares : Form
    {
        public Celulares()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            textBoxTel.Text = string.Empty;
            textBoxImei1.Text = string.Empty;
            texboxImei2.Text = string.Empty;
            textBoxNum1.Text = string.Empty;
            textBoxNum2.Text = string.Empty;
            textBoxCaract.Text = string.Empty;
            textBoxCost.Text = string.Empty;
            textBoxObser.Text = string.Empty;
            textBoxDescrip.Text = string.Empty;
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guardando");
        }

        private void Celulares_Load(object sender, EventArgs e)
        {

        }
    }
}
