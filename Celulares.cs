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
            dtg_celulares.CellFormatting += dtg_celulares_CellFormatting;
            this.ttmensaje.SetToolTip(this.ibtn_limpiar, "Limpiar");
            this.ttmensaje.SetToolTip(this.ibtn_delete, "Eliminar");
            this.ttmensaje.SetToolTip(this.ibtn_save, "Guardar");
            this.ttmensaje.SetToolTip(this.ibtn_update, "Editar");
            celular = new CO_Celular();
        }

        private void Celulares_Load(object sender, EventArgs e)
        {
            ibtn_save.Enabled = false;
            cargarGrid();

        }

        private void ValidCamp()
        {
            var vr = !string.IsNullOrEmpty(txt_activoFijo.Text) &&
                !string.IsNullOrEmpty(txt_descrip.Text) &&
                !string.IsNullOrEmpty(txt_imei1.Text) &&
                !string.IsNullOrEmpty(txt_serial.Text) &&
                !string.IsNullOrEmpty(txt_marca.Text) &&
                !string.IsNullOrEmpty(txt_modelo.Text) &&
                !string.IsNullOrEmpty(txt_imei2.Text) &&
                !string.IsNullOrEmpty(txt_responsable.Text) &&
                !string.IsNullOrEmpty(txt_modelo.Text) &&
                !string.IsNullOrEmpty(txt_garantia.Text) &&
                !string.IsNullOrEmpty(txt_costo.Text) &&
                !string.IsNullOrEmpty(txt_proveedor.Text);

            ibtn_save.Enabled = vr;
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
            CN_celulares cell = new CN_celulares();
            dtg_celulares.DataSource = cell.MostrarCell();
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
            ValidCamp();
        }

        private void txt_activoFijo_TextChanged(object sender, EventArgs e)
        {
            ValidCamp();
        }

        private void txt_costo_TextChanged(object sender, EventArgs e)
        {
            ValidCamp();

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

        private void dtg_celulares_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 13)
            {
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double valorNumerico))
                {
                    e.Value = valorNumerico.ToString("C");
                    e.FormattingApplied = true;
                }
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            string coincidencia = txt_buscar.Text;
            var results = lista_celulares.Where(X => X.descripcion.Contains(coincidencia) || X.activo_fijo.Contains(coincidencia)).Select(X => X).ToList();
            dtg_celulares.DataSource = results;
        }

        private void txt_serial_TextChanged(object sender, EventArgs e)
        {
            ValidCamp();
        }

        private void txt_marca_TextChanged(object sender, EventArgs e)
        {
            ValidCamp();
        }

        private void txt_modelo_TextChanged(object sender, EventArgs e)
        {
            ValidCamp();
        }

        private void txt_imei1_TextChanged(object sender, EventArgs e)
        {
            ValidCamp();
        }

        private void txt_imei2_TextChanged(object sender, EventArgs e)
        {
            ValidCamp();
        }

        private void txt_responsable_TextChanged(object sender, EventArgs e)
        {
            ValidCamp();
        }

        private void txt_proveedor_TextChanged(object sender, EventArgs e)
        {
            ValidCamp();
        }

        private void txt_garantia_TextChanged(object sender, EventArgs e)
        {
            ValidCamp();
        }

        private void txt_garantia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

}
