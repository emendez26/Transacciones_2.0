using Capa_Negocios;
using Capa_Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyecto_inventario


{

    public partial class Celulares : Form
    {
        List<Capa_Objetos.CO_Celular> lista_celulares = new List<Capa_Objetos.CO_Celular>();
        CO_Celular celular = new CO_Celular();
        CN_celulares CN_cell = new CN_celulares();

        private int id = 0;
        private bool Editar = false;


        public Celulares()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.ibtn_limpiar, "Limpiar");
            this.ttmensaje.SetToolTip(this.ibtn_delete, "Eliminar");
            this.ttmensaje.SetToolTip(this.ibtn_save, "Guardar");
            this.ttmensaje.SetToolTip(this.ibtn_update, "Editar");
            celular = new CO_Celular();
        }

        private void Celulares_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }


        public CO_Celular GetData()
        {

            celular = new CO_Celular();

            celular.usuario = "Admin";
            celular.activo_fijo = txt_activoFijo.Text;
            celular.serial = txt_serial.Text;
            celular.imei1 = txt_imei1.Text;
            celular.imei2 = txt_imei2.Text;
            celular.marca = txt_marca.Text;
            celular.modelo = txt_modelo.Text;
            celular.descripcion = txt_descrip.Text;
            celular.fecha_compra = DateTime.Parse(dtp_fcompra.Value.ToShortDateString());
            celular.proveedor = txt_proveedor.Text;
            celular.costo = double.Parse(txt_costo.Text);
            celular.garantia_anos = int.Parse(txt_garantia.Text);
            celular.observacion = txt_observ.Text;
            celular.responsable = txt_responsable.Text;

            return celular;
        }

        public void SetData()
        {
            txt_activoFijo.Text = celular.activo_fijo;
            txt_serial.Text = celular.serial;
            txt_imei1.Text = celular.imei1;
            txt_imei2.Text = celular.imei2;
            txt_marca.Text = celular.marca;
            txt_modelo.Text = celular.modelo;
            txt_descrip.Text = celular.descripcion;
            dtp_fcompra.Value = celular.fecha_compra;
            txt_proveedor.Text = celular.proveedor;
            txt_costo.Text = celular.costo.ToString();
            txt_garantia.Text = celular.garantia_anos.ToString();
            txt_observ.Text = celular.observacion;
            txt_responsable.Text = celular.responsable;
        }

        public void mostrarDatos()
        {
            // lista_celulares.Select => (e => { e.id = id}
            id = int.Parse(dtg_celulares.CurrentRow.Cells["Id"].Value.ToString());
            celular = new CO_Celular();
            celular = lista_celulares.Where(e => e.id.Equals(id)).FirstOrDefault();
            SetData();
        }

        private void cargarGrid()
        {
            dtg_celulares.DataSource = null;
            dtg_celulares.Rows.Clear();
            lista_celulares = new List<Capa_Objetos.CO_Celular>();
            lista_celulares.AddRange(CN_cell.MostrarCell());
            dtg_celulares.DataSource = lista_celulares;
        }

        private void limpiar()
        {
            if (MessageBox.Show("Estas seguro de Limpiar el formulario", "Mood Test", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                celular = new CO_Celular();
                txt_activoFijo.Text = string.Empty;
                txt_imei1.Text = string.Empty;
                txt_imei2.Text = string.Empty;
                txt_descrip.Text = string.Empty;
                txt_serial.Text = string.Empty;
                txt_marca.Text = string.Empty;
                txt_modelo.Text = string.Empty;
                txt_proveedor.Text = string.Empty;
                txt_garantia.Text = string.Empty;
                txt_costo.Text = string.Empty;
                dtp_fcompra.Text = string.Empty;
                txt_observ.Text = string.Empty;
                txt_responsable.Text = string.Empty;

                //habilitar botones
                ibtn_delete.Enabled = true;
                ibtn_update.Enabled = true;

                txt_activoFijo.Enabled = true;
            }
        }

        public void guardar()
        {
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    string mensaje = "";
                    if (CN_cell.InsertCell(GetData()) != 0)
                    {
                        mensaje = "Registro Insertado Correctamente";
                        cargarGrid();
                        //impiar();
                    }
                    else
                    {
                        mensaje = "Error al guardar";
                    }
                    MessageBox.Show(mensaje);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (Editar == true)
            {
                try
                {
                    string mensaje = "";
                    if (CN_cell.UpdateCell(id, GetData()) != 0)
                    {
                        mensaje = "Registro Insertado Correctamente";
                        cargarGrid();
                        limpiar();
                        Editar = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }



        }

        public void editar()
        {

            if (dtg_celulares.SelectedRows.Count > 0)
            {
                Editar = true;
                txt_activoFijo.Enabled = false;
                ibtn_delete.Enabled = false;
                ibtn_update.Enabled = false;
                mostrarDatos();
            }
            else
                MessageBox.Show("seleccione una fila por favor");

        }

        public void eliminar()
        {
            if (dtg_celulares.SelectedRows.Count > 0)
            {
                id = int.Parse(dtg_celulares.CurrentRow.Cells["Id"].Value.ToString());
                if (CN_cell.DeleteCell(id) != 0)
                {
                    MessageBox.Show("Eliminado correctamente");
                    cargarGrid();
                }
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }


        private void ibtn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dtg_celulares_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarDatos();
        }

        private void txt_activoFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ibtn_save_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void ibtn_update_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void ibtn_delete_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void txt_costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtg_celulares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_descrip_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_activoFijo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
