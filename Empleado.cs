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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Nombre_Empleado.Text = string.Empty;
            txt_Apellido_Empleado.Text = string.Empty;
            txt_Identificacion_Empleado.Text = string.Empty;
            txt_Ubicacion_Empleado.Text = string.Empty;
            txt_Area_Empleado.Text = string.Empty;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
        }

        private void txt_Area_Empleado_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbl_Area_Empleado_Click(object sender, EventArgs e)
        {
        }

        private void lbl_Ubicacion_Empleado_Click(object sender, EventArgs e)
        {
        }

        private void lbl_Identificacion_Empleado_Click(object sender, EventArgs e)
        {
        }

        private void lbl_Apellido_Empleado_Click(object sender, EventArgs e)
        {
        }

        private void lbl_Nombre_Empleado_Click(object sender, EventArgs e)
        {
        }

        private void txt_Apellido_Empleado_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_Identificacion_Empleado_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_Ubicacion_Empleado_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_Nombre_Empleado_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_Apellido_Empleado_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
