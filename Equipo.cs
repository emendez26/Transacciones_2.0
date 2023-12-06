using Capa_Datos;
using Capa_Negocios;
using Capa_Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_inventario
{
    public partial class Equipo : Form
    {
        List<Capa_Objetos.CO_Equipos> lista_Equipos = new List<Capa_Objetos.CO_Equipos>();
        CO_Equipos equipo = new CO_Equipos();
        CN_Equipos CN_Equip = new CN_Equipos();


        private string activo_fijo = "";
        private bool Editar = false;

        public Equipo()
        {
            InitializeComponent();
            dg_equipos.CellFormatting += dg_equipos_CellFormatting;
            this.ttmensaje.SetToolTip(this.ibtn_limpiar, "Limpiar");
            equipo = new CO_Equipos();
        }


        private void cargarGrid()
        {
            dg_equipos.DataSource = null;
            dg_equipos.Rows.Clear();
            lista_Equipos = new List<Capa_Objetos.CO_Equipos>();
            lista_Equipos.AddRange(CN_Equip.MostrarEquip());
            CN_Equipos Equip = new CN_Equipos();
            dg_equipos.DataSource = Equip.MostrarEquip();
        }

        private void Equipo_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        public void SetData()
        {
            txt_activo_fijo.Text = equipo.activo_fijo;
            txt_estado.Text = equipo.estado;
            txt_tipo.Text = equipo.tipo;
            txt_sub_tipo.Text = equipo.sub_tipo;
            txt_marca.Text = equipo.marca;
            txt_modelo.Text = equipo.modelo;
            txt_descrip.Text = equipo.descripcion;
            txt_serial.Text = equipo.serial;
            txt_responsable.Text = equipo.responsable;
            txt_ubicacion.Text = equipo.ubicacion;
            txt_depart.Text = equipo.departamento;
            txt_area.Text = equipo.area;
            cb_inactivo.Checked = equipo.inactive;
            dt_Fcompra.Value = equipo.fecha_compra == null ? DateTime.Now : (DateTime)equipo.fecha_compra;
            txt_costo.Text = equipo.costo.ToString();
            txt_tipo_adquisicion.Text = equipo.tipo_adquisicion.ToString();
        }

        public void mostrarDatos()
        {
            activo_fijo = (dg_equipos.CurrentRow.Cells["activo_fijo"].Value.ToString());
            equipo = new CO_Equipos();
            equipo = lista_Equipos.Where(e => e.activo_fijo.Equals(activo_fijo)).FirstOrDefault();
            SetData();
        }

        private void txt_activo_fijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dg_equipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarDatos();
        }

        private void limpiar()
        {
            if (MessageBox.Show("Estas seguro de Limpiar el formulario", "Confirmar accion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                equipo = new CO_Equipos();
                txt_activo_fijo.Text = string.Empty;
                txt_estado.Text = string.Empty;
                txt_tipo.Text = string.Empty;
                txt_sub_tipo.Text = string.Empty;
                txt_marca.Text = string.Empty;
                txt_modelo.Text = string.Empty;
                txt_descrip.Text = string.Empty;
                txt_serial.Text = string.Empty;
                txt_responsable.Text = string.Empty;
                txt_ubicacion.Text = string.Empty;
                txt_depart.Text = string.Empty;
                txt_area.Text = string.Empty;
                cb_inactivo.Checked = false;
                dt_Fcompra.Text = string.Empty;
                txt_costo.Text = string.Empty;
                txt_tipo_adquisicion.Text = string.Empty;

                txt_activo_fijo.Enabled = true;
            }
        }

        private void ibtn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dg_equipos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void txt_costo_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_costo.Text, out decimal costo))
            {
                formato_moneda(costo);
                txt_costo.SelectionStart = txt_costo.Text.Length;
            }
        }
        private void formato_moneda(decimal numero)
        {
            txt_costo.Text = numero.ToString("N0");
        }

        private void txt_buscar_equipos_TextChanged(object sender, EventArgs e)
        {
            string coincidencia = txt_buscar_equipos.Text;
            var results = lista_Equipos.Where(X => X.descripcion.Contains(coincidencia) || X.activo_fijo.Contains(coincidencia)).Select(X => X).ToList();
            dg_equipos.DataSource = results;

        }


        public void countar()
        {
            int total = dg_equipos.RowCount;
            lbl_count.Text = "Total Registro: " + total;
        }

        private void dg_equipos_DataSourceChanged(object sender, EventArgs e)
        {
            countar();
        }
    }
}

