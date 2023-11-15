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
            this.ttmensaje.SetToolTip(this.ibtn_limpiar, "Limpiar");
            equipo = new CO_Equipos();
        }


        private void cargarGrid()
        {
            dg_equipos.DataSource = null;
            dg_equipos.Rows.Clear();
            lista_Equipos = new List<Capa_Objetos.CO_Equipos>();
            lista_Equipos.AddRange(CN_Equip.MostrarEquip());
            dg_equipos.DataSource = lista_Equipos;
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
            dt_Fcompra.Value = equipo.fecha_compra;
            txt_costo.Text = equipo.costo.ToString();
            txt_tipo_adquisicion.Text = equipo.tipo_adquisicion.ToString();
        }

        public void mostrarDatos()
        {
            activo_fijo = (dg_equipos.CurrentRow.Cells["EquipID"].Value.ToString());
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
            if (MessageBox.Show("Estas seguro de Limpiar el formulario", "Mood Test", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
    }
}

//public CO_Equipos GetData()
//{

//equipo = new CO_Equipos();
//equipo.usuario = "Admin";
//equipo.activo_fijo = txt_activo_fijo.Text;
//equipo.sitio = txt_sitio.Text;
//equipo.sede = txt_sede.Text;
//equipo.descripcion = txt_descrip.Text;
//equipo.modelo = txt_modelo.Text;
//equipo.fabricante = txt_fabricante.Text;
//equipo.sub_tipo = txt_sub_tipo.Text;
//equipo.tipo = txt_tipo.Text;
//equipo.area = txt_area.Text;
//equipo.fecha_servicio = DateTime.Parse(dt_Fservicio.Value.ToLongDateString());
//equipo.ubicacion = txt_ubicacion.Text;
//equipo.costo = double.Parse(txt_costo.Text);
//equipo.tipo_adquisicion = txt_tipo_adquisicion.Text;
//equipo.id_empleado = txt_responsable;
//equipo.estado = txt_estado;
//equipo.serial = txt_serial.Text;

//return equipo;
//}