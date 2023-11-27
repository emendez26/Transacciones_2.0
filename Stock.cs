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
    public partial class Stock : Form
    {
        List<Capa_Objetos.CO_Equipos> lista_Equipos = new List<Capa_Objetos.CO_Equipos>();
        CO_Equipos equipo = new CO_Equipos();
        CN_Equipos CN_Equip = new CN_Equipos();


        private string activo_fijo = "";
        private bool Editar = false;
        public Stock()
        {
            InitializeComponent();
            dg_stock.CellFormatting += dg_stock_CellFormatting;
            equipo = new CO_Equipos();
        }

        private void cargarGrid()
        {
            dg_stock.DataSource = null;
            dg_stock.Rows.Clear();
            lista_Equipos = new List<Capa_Objetos.CO_Equipos>();
            lista_Equipos.AddRange(CN_Equip.MostrarEquip());
            CN_Equipos Equip = new CN_Equipos();
            dg_stock.DataSource = Equip.MostrarEquip();
        }

        private void txt_Buscar_Articulo_TextChanged(object sender, EventArgs e)
        {
            dg_stock.CurrentCell = null;
            foreach (DataGridViewRow r in dg_stock.Rows)
            {
                r.Visible = false;
            }
            foreach (DataGridViewRow r in dg_stock.Rows)
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

        private void Stock_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        public void mostrarDatos()
        {
            activo_fijo = (dg_stock.CurrentRow.Cells["activo_fijo"].Value.ToString());
            equipo = new CO_Equipos();
            equipo = lista_Equipos.Where(e => e.activo_fijo.Equals(activo_fijo)).FirstOrDefault();
        }

        private void dg_stock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarDatos();
        }

        private void dg_stock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 14)
            {
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double valorNumerico))
                {
                    e.Value = valorNumerico.ToString("C");
                    e.FormattingApplied = true;
                }

            }
        }

        private void dg_stock_VisibleChanged(object sender, EventArgs e)
        {
            dg_stock.CurrentCell = null;

            foreach (DataGridViewRow r in dg_stock.Rows)
            {
                r.Visible = false;
            }

            foreach (DataGridViewRow r in dg_stock.Rows)
            {
                string tipoArticulo = r.Cells["Estado"].Value.ToString();
                if (tipoArticulo.ToUpper() == "STOCK")
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txt_Buscar_Articulo.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break; 
                        }
                    }
                }
            }
        }
    }
}
