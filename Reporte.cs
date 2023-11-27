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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void txt_Buscar_Articulo_TextChanged(object sender, EventArgs e)
        {
            dg_reporte.CurrentCell = null;
            foreach (DataGridViewRow r in dg_reporte.Rows)
            {
                r.Visible = false;
            }
            foreach (DataGridViewRow r in dg_reporte.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    if ((c.Value.ToString().ToUpper()).IndexOf(txt_Buscar_Articulo.Text.ToUpper()) == 0)
                    {
                        r.Visible = true;
                    }
                }
            }
        }
    }
}
