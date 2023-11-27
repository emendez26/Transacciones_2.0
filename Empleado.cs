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
            empleado.departamento = txt_Ubicacion_Empleado.Text;
            empleado.area = txt_Area_Empleado.Text;


            return empleado;
        }

        public void SetData()
        {
            txt_Identificacion_Empleado.Text = empleado.identifiacion;
            txt_Ubicacion_Empleado.Text = empleado.departamento;
            txt_Area_Empleado.Text = empleado.area;
            chb_inactivo.Checked = empleado.inactivo;
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
                txt_Ubicacion_Empleado.Text = string.Empty;
                txt_Area_Empleado.Text = string.Empty;
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
        }

        private void ibtn_Registrar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void ibtn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dg_empleados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarDatos();
        }

        private void txt_Identificacion_Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            dg_empleados.CurrentCell = null;
            foreach (DataGridViewRow r in dg_empleados.Rows)
            {
                r.Visible = false;
            }
            foreach (DataGridViewRow r in dg_empleados.Rows)
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
