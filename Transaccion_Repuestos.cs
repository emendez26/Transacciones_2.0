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
    public partial class Transaccion_Repuestos : Form
    {
        List<string> motivosEntrada = new List<string>() { "COMPRA", "DEVOLUCION", "OBSEQUIO" };
        List<string> motivosSalida = new List<string>() { "DEVOLUCION", "ASIGNACIÓN", "PRESTAMO", "MANTENIMIENTO", "HURTO", "OBSOLETO", "PERDIDA" };

        List<Capa_Objetos.CO_Transacciones> lista_transacciones = new List<Capa_Objetos.CO_Transacciones>();
        CO_Transacciones transaccion = new CO_Transacciones();
        CN_Transacciones CN_trans = new CN_Transacciones();


        string formulario = "";

        private int id = 0;
        private bool Editar = false;

        public Transaccion_Repuestos(string formulario)
        {

            InitializeComponent();
            transaccion = new CO_Transacciones();
            cmb_motivo.Items.AddRange(motivosEntrada.ToArray());
            this.formulario = formulario;
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public CO_Transacciones GetData()
        {

            transaccion = new CO_Transacciones();

            transaccion.fecha_transaccion = DateTime.Parse(dtp_Ftransaccion.Value.ToShortDateString());
            transaccion.fecha_movimiento = DateTime.Parse(dtp_Fmovimiento.Value.ToShortDateString());
            transaccion.tipo_transaccion = cmb_Tipo.Text;
            transaccion.observaciones = txt_observacion.Text;
            transaccion.ruta_soporte = txt_ruta_soporte.Text;
            transaccion.responsable = txt_responsable.Text;
            transaccion.motivo = cmb_motivo.Text;
            transaccion.formulario = formulario;

            return transaccion;
        }

        public void SetData()
        {
            txt_id.Text = transaccion.id.ToString();
            dtp_Ftransaccion.Value = transaccion.fecha_transaccion;
            dtp_Fmovimiento.Value = transaccion.fecha_movimiento;
            cmb_Tipo.Text = transaccion.tipo_transaccion;
            txt_observacion.Text = transaccion.observaciones;
            txt_ruta_soporte.Text = transaccion.ruta_soporte;
            txt_responsable.Text = transaccion.responsable;
            cmb_motivo.Text = transaccion.motivo;

            dg_transaccion.Columns[0].HeaderText = "CODIGO ART";

        }

        public void mostrarDatos()
        {
            id = int.Parse(dg_transaccion.CurrentRow.Cells["Id"].Value.ToString());
            transaccion = new CO_Transacciones();
            transaccion = lista_transacciones.Where(e => e.id.Equals(id)).FirstOrDefault();
            SetData();
        }

        private void cargarGrid()
        {
            dg_transaccion.DataSource = null;
            dg_transaccion.Rows.Clear();
            lista_transacciones = new List<Capa_Objetos.CO_Transacciones>();
            lista_transacciones.AddRange(CN_trans.MostrarTrans());
            CN_Transacciones trans = new CN_Transacciones();
            dg_transaccion.DataSource = trans.MostrarTrans();
        }

        private void limpiar(bool isEdit)
        {
            if (MessageBox.Show("¿Estás seguro de " + (isEdit ? "editar" : "limpiar") + " el formulario", "Confirmar acción", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                transaccion = new CO_Transacciones();
                txt_id.Text = transaccion.id.ToString();
                dtp_Ftransaccion.Text = string.Empty;
                dtp_Fmovimiento.Text = string.Empty;
                cmb_Tipo.Text = string.Empty;
                txt_observacion.Text = string.Empty;
                txt_ruta_soporte.Text = string.Empty;
                txt_responsable.Text = string.Empty;
                cmb_motivo.Text = string.Empty;
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
                    if (CN_trans.InsertTrans(GetData()) != 0)
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
        }

        private void ibtn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar(false);
        }

        private void ibtn_save_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void dg_transaccion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarDatos();
        }

        private void Transaccion_Repuestos_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void cmb_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Tipo.Text == "ENTRADA")
            {
                cmb_motivo.Items.Clear();
                cmb_motivo.Items.AddRange(motivosEntrada.ToArray());
            }
            else if (cmb_Tipo.Text == "SALIDA")
            {
                cmb_motivo.Items.Clear();
                cmb_motivo.Items.AddRange(motivosSalida.ToArray());
            }
        }

        private void dg_transaccion_VisibleChanged(object sender, EventArgs e)
        {
            dg_transaccion.CurrentCell = null;

            foreach (DataGridViewRow r in dg_transaccion.Rows)
            {
                r.Visible = false;
            }

            foreach (DataGridViewRow r in dg_transaccion.Rows)
            {
                string tipoFormulario = r.Cells["formulario"].Value.ToString();
                if (tipoFormulario.ToUpper() == "REPUESTOS")
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        // Asegúrate de que el texto de búsqueda esté presente en alguna celda
                        if (c.Value != null && (c.Value.ToString().ToUpper()).Contains(txt_buscar.Text.ToUpper()))
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
