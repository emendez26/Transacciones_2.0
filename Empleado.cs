using Capa_Objetos;
using Capa_Negocios;
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
    public partial class Empleado : Form
    {

        List<Capa_Objetos.CO_Empleados> lista_empleados = new List<Capa_Objetos.CO_Empleados>();
        CO_Empleados empleado = new CO_Empleados();
        CN_Empleados CN_emp = new CN_Empleados();

        private int id = 0;
        private bool Editar = false;

        public Empleado()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.ibtn_Registrar, "Registrar");
            this.ttmensaje.SetToolTip(this.ibtn_limpiar, "Limpiar");
            this.ttmensaje.SetToolTip(this.ibtn_update, "Editar");
            this.ttmensaje.SetToolTip(this.ibtn_delete, "Eliminar");
            empleado = new CO_Empleados();
        }

        private void cargarGrid()
        {
            dg_empleados.DataSource = null;
            dg_empleados.Rows.Clear();
            lista_empleados = new List<Capa_Objetos.CO_Empleados>();
            lista_empleados.AddRange(CN_emp.MostrarEmp());
            CN_Empleados emp = new CN_Empleados();
            dg_empleados.DataSource = emp.MostrarEmp();
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        public CO_Empleados GetData()
        {

            empleado = new CO_Empleados();

            empleado.identifiacion = txt_Identificacion_Empleado.Text;
            empleado.departamento = cmb_depart.Text;
            empleado.area = int.Parse(cmb_area.Text);
            empleado.ubicacion = cmb_ubic.Text;


            return empleado;
        }

        public void SetData()
        {
           
            txt_Identificacion_Empleado.Text = empleado.identifiacion;
            cmb_depart.Text = empleado.departamento;
            cmb_area.Text = empleado.area.ToString();
            chb_inactivo.Checked = empleado.inactivo;
            cmb_ubic.Text = empleado.ubicacion;
        }

        public void mostrarDatos()
        {
            id = int.Parse(dg_empleados.CurrentRow.Cells["id"].Value.ToString());
            empleado = new CO_Empleados();
            empleado = lista_empleados.Where(e => e.id.Equals(id)).FirstOrDefault();
            SetData();
        }

        private void limpiar()
        {
            if (MessageBox.Show("Estas seguro de Limpiar el formulario", "Confirmar accion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                empleado = new CO_Empleados();
                txt_Identificacion_Empleado.Text = string.Empty;
                cmb_depart.Text = string.Empty;
                cmb_area.Text = string.Empty;
                chb_inactivo.Text = string.Empty;

                txt_Identificacion_Empleado.Enabled = true;
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
                    if (CN_emp.InsertEmp(GetData()) != 0)
                    {
                        mensaje = "Registro Insertado Correctamente";
                        cargarGrid();

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
                    if (CN_emp.UpdateEmp(id, GetData()) != 0)
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

            if (dg_empleados.SelectedRows.Count > 0)
            {
                Editar = true;
                txt_Identificacion_Empleado.Enabled = false;
                ibtn_delete.Enabled = false;
                ibtn_update.Enabled = false;
                mostrarDatos();
            }
            else
                MessageBox.Show("seleccione una fila por favor");

        }

        public void eliminar()
        {
            if (dg_empleados.SelectedRows.Count > 0)
            {
                id = int.Parse(dg_empleados.CurrentRow.Cells["Id"].Value.ToString());
                if (CN_emp.DeleteEmp(id) != 0)
                {
                    MessageBox.Show("Eliminado correctamente");
                    cargarGrid();
                }
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
        private void txt_Identificacion_Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ibtn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void ibtn_Registrar_Click(object sender, EventArgs e)
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

        private void dg_empleados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarDatos();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            string coincidencia = txt_buscar.Text;
            var results = lista_empleados.Where(X => X.identifiacion.Contains(coincidencia)).Select(X => X).ToList();
            dg_empleados.DataSource = results;
        }

    }
}
