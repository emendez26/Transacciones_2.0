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
            //string coincidencia = txt_Buscar_Articulo.Text;
            //var results = lista_Reportes.Where(X => X.caracteristicas.Contains(coincidencia) || X.proveedor.Contains(coincidencia)).Select(X => X).ToList();
            //dg_reporte.DataSource = results;
        }
    }
}
