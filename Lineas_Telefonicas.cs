using Capa_Negocios;
using Capa_Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_inventario
{
    public partial class Lineas_Telefonicas : Form
    {
        List<Capa_Objetos.CO_Lineas_Telefonicas> lista_Lineas = new List<Capa_Objetos.CO_Lineas_Telefonicas>();
        CO_Lineas_Telefonicas linea = new CO_Lineas_Telefonicas();
        CN_Lineas_Telefonicas CN_lineas = new CN_Lineas_Telefonicas();

        private int id = 0;
        private bool Editar = false;


        public Lineas_Telefonicas()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.ibtn_limpiar, "Limpiar");
            this.ttmensaje.SetToolTip(this.ibtn_delete, "Eliminar");
            this.ttmensaje.SetToolTip(this.ibtn_save, "Guardar");
            this.ttmensaje.SetToolTip(this.ibtn_update, "Editar");
            linea = new CO_Lineas_Telefonicas();
        }

        private void Lineas_Telefonicas_Load(object sender, EventArgs e)
        {
            ibtn_save.Enabled = false;
            cargarGrid();
        }

        private void ValidCamp()
        {
            var vr = !string.IsNullOrEmpty(txt_linea.Text) &&
                !string.IsNullOrEmpty(cmb_plan.Text)&&
                !string.IsNullOrEmpty(txt_proveedor.Text) &&
                !string.IsNullOrEmpty(txt_caract.Text);

            ibtn_save.Enabled = vr;
        }

        public CO_Lineas_Telefonicas GetData()
        {

            linea = new CO_Lineas_Telefonicas();

            linea.linea_telefonica = double.Parse(txt_linea.Text);
            linea.plan = cmb_plan.Text;
            linea.proveedor = txt_proveedor.Text;
            linea.caracteristicas = txt_caract.Text;


            return linea;
        }

        public void SetData()
        {
            txt_linea.Text = linea.linea_telefonica.ToString();
            cmb_plan.Text = linea.plan;
            txt_proveedor.Text = linea.proveedor;
            txt_caract.Text = linea.caracteristicas;
        }

        public void mostrarDatos()
        {

            id = int.Parse(dtg_linea.CurrentRow.Cells["id"].Value.ToString());
            linea = new CO_Lineas_Telefonicas();
            linea = lista_Lineas.Where(e => e.id.Equals(id)).FirstOrDefault();
            SetData();
        }

        private void cargarGrid()
        {
            dtg_linea.DataSource = null;
            dtg_linea.Rows.Clear();
            lista_Lineas = new List<Capa_Objetos.CO_Lineas_Telefonicas>();
            lista_Lineas.AddRange(CN_lineas.Mostrarlineas());
            CN_Lineas_Telefonicas lineas = new CN_Lineas_Telefonicas();
            dtg_linea.DataSource = lineas.Mostrarlineas();
        }

        private void limpiar(bool isEdit)
        {
            if (MessageBox.Show("¿Estás seguro de " + (isEdit ? "editar" : "limpiar") + " el formulario", "Confirmar acción", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                linea = new CO_Lineas_Telefonicas();
                txt_linea.Text = string.Empty;
                cmb_plan.Text = string.Empty;
                txt_proveedor.Text = string.Empty;
                txt_caract.Text = string.Empty;


                //habilitar botones
                ibtn_delete.Enabled = true;
                ibtn_update.Enabled = true;

                txt_linea.Enabled = !isEdit;
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
                    if (CN_lineas.InsertLineas(GetData()) != 0)
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
                    if (CN_lineas.UpdateLineas(id, GetData()) != 0)
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

            if (dtg_linea.SelectedRows.Count > 0)
            {
                Editar = true;
                txt_linea.Enabled = false;
                ibtn_delete.Enabled = false;
                ibtn_update.Enabled = false;
                mostrarDatos();
            }
            else
                MessageBox.Show("seleccione una fila por favor");

        }

        public void eliminar()
        {
            if (dtg_linea.SelectedRows.Count > 0)
            {
                id = int.Parse(dtg_linea.CurrentRow.Cells["Id"].Value.ToString());
                if (CN_lineas.DeleteLineas(id) != 0)
                {
                    MessageBox.Show("Eliminado correctamente");
                    cargarGrid();
                }
            }
            else
                MessageBox.Show("seleccione una fila por favor");
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

        private void ibtn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar(false);
        }

        private void dtg_linea_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarDatos();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            string coincidencia = txt_buscar.Text;
            var results = lista_Lineas.Where(X => X.caracteristicas.Contains(coincidencia) || X.proveedor.Contains(coincidencia)).Select(X => X).ToList();
            dtg_linea.DataSource = results;
        }

        private void txt_linea_TextChanged(object sender, EventArgs e)
        {
            ValidCamp();
        }

        private void txt_proveedor_TextChanged(object sender, EventArgs e)
        {
            ValidCamp();
        }

        private void cmb_plan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidCamp();
        }

        private void txt_caract_TextChanged(object sender, EventArgs e)
        {
            ValidCamp();
        }

        private void txt_linea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
