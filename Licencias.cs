using Capa_Negocios;
using Capa_Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_inventario
{
    public partial class Licencias : Form
    {
        List<Capa_Objetos.CO_Licencias> lista_licencia = new List<Capa_Objetos.CO_Licencias>();
        CO_Licencias licencia = new CO_Licencias();
        CN_Licencias CN_Lic = new CN_Licencias();

        private int id = 0;
        private bool Editar = false;

        public Licencias()
        {
            InitializeComponent();
            dg_licencia.CellFormatting += dg_licencia_CellFormatting;
            this.ttmensaje.SetToolTip(this.ibtn_limpiar, "Limpiar");
            this.ttmensaje.SetToolTip(this.ibtn_delete, "Eliminar");
            this.ttmensaje.SetToolTip(this.ibtn_save, "Guardar");
            this.ttmensaje.SetToolTip(this.ibtn_update, "Editar");
            licencia = new CO_Licencias();
        }

        private void Licencias_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        public CO_Licencias GetData()
        {

            licencia = new CO_Licencias();

            licencia.activacion = bool.Parse(chb_activo.Checked.ToString());
            licencia.Caracteristicas = txt_caract.Text;
            licencia.costo = double.Parse(txt_costo.Text);
            licencia.fecha_Inicio = DateTime.Parse(dtp_Finicio.Value.ToShortDateString());
            licencia.fecha_Fin = DateTime.Parse(dtp_Ffin.Value.ToShortDateString());
            licencia.anos_Licencia = int.Parse(txt_Alicencia.Text);
            licencia.proveedor = txt_proveedor.Text;


            return licencia;
        }

        public void SetData()
        {
            txt_Id.Text = licencia.id.ToString();
            chb_activo.Checked = licencia.activacion;
            txt_caract.Text = licencia.Caracteristicas;
            txt_costo.Text = licencia.costo.ToString();
            dtp_Finicio.Value = licencia.fecha_Inicio;
            dtp_Ffin.Value = licencia.fecha_Fin;
            txt_Alicencia.Text = licencia.anos_Licencia.ToString();
            txt_proveedor.Text = licencia.proveedor;
        }

        private void mostrarDatos()
        {

            id = int.Parse(dg_licencia.CurrentRow.Cells["Id"].Value.ToString());
            licencia = new CO_Licencias();
            licencia = lista_licencia.Where(e => e.id.Equals(id)).FirstOrDefault();
            SetData();
        }

        private void cargarGrid()
        {
            dg_licencia.DataSource = null;
            dg_licencia.Rows.Clear();
            lista_licencia = new List<Capa_Objetos.CO_Licencias>();
            lista_licencia.AddRange(CN_Lic.MostrarLic());
            CN_Licencias Lic = new CN_Licencias();
            dg_licencia.DataSource = Lic.MostrarLic();
        }

        private void limpiar(bool isEdit)
        {
            if (MessageBox.Show("¿Estás seguro de " + (isEdit ? "editar" : "limpiar") + " el formulario", "Confirmar acción", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                licencia = new CO_Licencias();
                txt_Id.Text = string.Empty;
                chb_activo.Checked = false;
                txt_caract.Text = string.Empty;
                txt_costo.Text = string.Empty;
                dtp_Finicio.Text = string.Empty;
                dtp_Ffin.Text = string.Empty;
                txt_Alicencia.Text = string.Empty;
                txt_proveedor.Text = string.Empty;

                // Habilitar botones
                ibtn_delete.Enabled = true;
                ibtn_update.Enabled = true;

                txt_Id.Enabled = !isEdit;
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
                    if (CN_Lic.InsertLic(GetData()) != 0)
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
            if (Editar == true)
            {
                try
                {
                    string mensaje = "";
                    if (CN_Lic.UpdateLic(id, GetData()) != 0)
                    {
                        mensaje = "Registro Insertado Correctamente";
                        cargarGrid();
                        limpiar(true);
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

            if (dg_licencia.SelectedRows.Count > 0)
            {
                Editar = true;
                txt_Id.Enabled = false;
                ibtn_delete.Enabled = false;
                ibtn_update.Enabled = false;
                mostrarDatos();
            }
            else
                MessageBox.Show("seleccione una fila por favor");

        }
        public void eliminar()
        {
            if (dg_licencia.SelectedRows.Count > 0)
            {
                id = int.Parse(dg_licencia.CurrentRow.Cells["Id"].Value.ToString());
                if (CN_Lic.DeleteLic(id) != 0)
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
            limpiar(false);
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

        private void dg_licencia_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            mostrarDatos();
        }

        private void txt_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
            txt_costo.Text = numero.ToString("n0");
        }

        private void dg_licencia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double valorNumerico))
                {
                    e.Value = valorNumerico.ToString("C");
                    e.FormattingApplied = true;
                }
            }
        }

        private void txt_Alicencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            string coincidencia = txt_buscar.Text;
            var results = lista_licencia.Where(X => X.Caracteristicas.Contains(coincidencia) || X.proveedor.Contains(coincidencia)).Select(X => X).ToList();
            dg_licencia.DataSource = results;
        }
    }
}