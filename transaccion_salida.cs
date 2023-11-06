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
    public partial class transaccion_salida : Form
    {
        public transaccion_salida()
        {
            InitializeComponent();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            textBoxId.Text = string.Empty;
            comboBox_switch.Text = string.Empty;
            textBoxCod.Text = string.Empty;
            comboBoxMot.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            dateTimePicker2.Text = string.Empty;
            textBoxProv.Text = string.Empty;
            textBoxSerial.Text = string.Empty;
            textBoxObser.Text = string.Empty;
            textBoxRuta.Text = string.Empty;

        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guardando");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
