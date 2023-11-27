using Capa_Negocios;
using Capa_Objetos;
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
    public partial class Toner : Form
    {
        public Toner()
        {
            InitializeComponent();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            dg_toner.CurrentCell = null;
            foreach (DataGridViewRow r in dg_toner.Rows)
            {
                r.Visible = false;
            }
            foreach (DataGridViewRow r in dg_toner.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    if ((c.Value.ToString().ToUpper()).IndexOf(txt_buscar.Text.ToUpper()) == 0)
                    {
                        r.Visible = true;
                    }
                }
            }
        }
    }
}
