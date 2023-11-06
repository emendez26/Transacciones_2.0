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
            txt_Sitio_Empleado.Text = string.Empty;
            txt_Area_Empleado.Text = string.Empty;
        }

        private void txt_Area_Empleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Area_Empleado_Click(object sender, EventArgs e)
        {
        }
    }
}
