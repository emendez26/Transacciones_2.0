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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_inventario
{
    public partial class Transacción : Form
    {
        List<string> motivosEntrada = new List<string>() { "COMPRA", "DEVOLUCION", "OBSEQUIO" };
        List<string> motivosSalida = new List<string>() { "DEVOLUCION", "ASIGNACIÓN", "PRESTAMO", "MANTENIMIENTO", "HURTO", "OBSOLETO", "PERDIDA" };

        List<Capa_Objetos.CO_Transacciones> lista_transacciones = new List<Capa_Objetos.CO_Transacciones>();
        CO_Transacciones transaccion = new CO_Transacciones();
        CN_Transacciones CN_trans = new CN_Transacciones();

        private static int contador = 1;

        string formulario = "";

        private int id = 0;
        private bool Editar = false;


        public Transacción(string formulario)
        {
            InitializeComponent();
            transaccion = new CO_Transacciones();
            cmb_motivo.Items.AddRange(motivosEntrada.ToArray());
            this.formulario = formulario;
            dg_transaccion.CellFormatting += dg_transaccion_CellFormatting;
            dg_transaccion1.CellFormatting += dg_transaccion1_CellFormatting;
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

            transaccion.fecha_movimiento = DateTime.Parse(dtp_Fmovimiento.Value.ToShortDateString());
            transaccion.tipo_transaccion = cmb_Tipo.Text;
            transaccion.observaciones = txt_observ.Text;
            transaccion.responsable = txt_responsable.Text;
            transaccion.motivo = cmb_motivo.Text;
            transaccion.formularios = formulario;
            transaccion.usuario = txt_usuario.Text;
            transaccion.numero_transaccion = int.Parse(txt_Ntransaccion.Text);
            transaccion.activo_fijo = int.Parse(txt_activo_fijo.Text);
            transaccion.descripcion = txt_descrip.Text;
            transaccion.costo = double.Parse(txt_costo.Text);

            return transaccion;
        }

        public void SetData()
        {
            dtp_Fmovimiento.Value = transaccion.fecha_movimiento;
            cmb_Tipo.Text = transaccion.tipo_transaccion;
            txt_observ.Text = transaccion.observaciones;
            txt_responsable.Text = transaccion.responsable;
            cmb_motivo.Text = transaccion.motivo;
            txt_usuario.Text = transaccion.usuario;
            txt_Ntransaccion.Text = transaccion.numero_transaccion.ToString();
            txt_activo_fijo.Text = transaccion.activo_fijo.ToString();
            txt_descrip.Text = transaccion.descripcion;
            txt_costo.Text = transaccion.costo.ToString();
        }

        public void mostrarDatos()
        {
            id = int.Parse(dg_transaccion1.CurrentRow.Cells["id"].Value.ToString());
            transaccion = new CO_Transacciones();
            transaccion = lista_transacciones.Where(e => e.id.Equals(id)).FirstOrDefault();
            SetData();
        }

        private void cargarGrid()
        {
            dg_transaccion1.DataSource = null;
            dg_transaccion1.Rows.Clear();
            lista_transacciones = new List<Capa_Objetos.CO_Transacciones>();
            lista_transacciones.AddRange(CN_trans.MostrarTrans());
            CN_Transacciones trans = new CN_Transacciones();
            dg_transaccion1.DataSource = trans.MostrarTrans();
        }

        private void limpiar(bool isEdit)
        {
            if (MessageBox.Show("¿Estás seguro de " + (isEdit ? "agregar estos datos a" : "limpiar") + " el formulario", "Confirmar acción", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                transaccion = new CO_Transacciones();

                if (isEdit)
                {
                    txt_activo_fijo.Text = string.Empty;
                    txt_costo.Text = string.Empty;
                    txt_descrip.Text = string.Empty;
                    dtp_Fmovimiento2.Text = string.Empty;
                }
                else
                {
                    cmb_motivo.Text = string.Empty;
                    dtp_Fmovimiento.Text = string.Empty;
                    cmb_Tipo.Text = string.Empty;
                    txt_cedula.Text = string.Empty;
                    txt_activo_fijo.Text = string.Empty;
                    txt_costo.Text = string.Empty;
                    txt_descrip.Text = string.Empty;
                    dtp_Fmovimiento2.Text = string.Empty;
                    txt_Ntransaccion.Text = string.Empty;
                    txt_usuario.Text = string.Empty;
                    txt_responsable.Text = string.Empty;
                    txt_departamento.Text = string.Empty;
                    txt_area.Text = string.Empty;
                    txt_observ.Text = string.Empty;

                }
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

        private void Transacción_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }


        private void cmb_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Tipo.Text == "ENTRADA")
            {
                cmb_motivo.Items.Clear();
                cmb_motivo.Items.AddRange(motivosEntrada.ToArray());
                txt_costo.Enabled = true;
            }
            else if (cmb_Tipo.Text == "SALIDA")
            {
                cmb_motivo.Items.Clear();
                cmb_motivo.Items.AddRange(motivosSalida.ToArray());
                txt_costo.Enabled = false;
                txt_costo.Text = "0";
            }
        }

        private void ibtn_save_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void dg_transaccion1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarDatos();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            dg_transaccion1.CurrentCell = null;
            foreach (DataGridViewRow r in dg_transaccion1.Rows)
            {
                r.Visible = false;
            }
            foreach (DataGridViewRow r in dg_transaccion1.Rows)
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


        private void txt_Ntransaccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_activo_fijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_cedula_KeyPress(object sender, KeyPressEventArgs e)
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
            txt_costo.Text = numero.ToString("N0");
        }

        private void ibtn_agg_Click(object sender, EventArgs e)
        {
            string dato1 = txt_activo_fijo.Text;
            string dato2 = txt_descrip.Text;
            string dato3 = txt_costo.Text;
            string dato4 = dtp_Fmovimiento2.Text;

            limpiar(true);

            dg_transaccion.Rows.Add(dato1, dato2, dato3, dato4);

        }

        private void txt_costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void limpiar1()
        {
            txt_activo_fijo.Text = string.Empty;
            txt_costo.Text = string.Empty;
            txt_descrip.Text = string.Empty;
            dtp_Fmovimiento2.Text = string.Empty;

        }
        private void ibtn_delete_Click(object sender, EventArgs e)
        {
            if (dg_transaccion.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar la fila seleccionada?", "Confirmar acción", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    DataGridViewRow filaSeleccionada = dg_transaccion.SelectedRows[0];
                    dg_transaccion.Rows.Remove(filaSeleccionada);
                    limpiar1();
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.", "Aviso");
            }
        }

        private void dg_transaccion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_activo_fijo.Text = dg_transaccion.CurrentRow.Cells[0].Value.ToString();
            txt_descrip.Text = dg_transaccion.CurrentRow.Cells[1].Value.ToString();
            txt_costo.Text = dg_transaccion.CurrentRow.Cells[2].Value.ToString();
            dtp_Fmovimiento2.Text = dg_transaccion.CurrentRow.Cells[3].Value.ToString();

        }

        private void dg_transaccion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double valorNumerico))
                {
                    e.Value = valorNumerico.ToString("C");
                    e.FormattingApplied = true;
                }
            }
        }

        private void dg_transaccion1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double valorNumerico))
                {
                    e.Value = valorNumerico.ToString("C");
                    e.FormattingApplied = true;
                }
            }
        }
    }
}

    