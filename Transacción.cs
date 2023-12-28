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

        List<Capa_Objetos.CO_Equipos> lista_Equipos = new List<Capa_Objetos.CO_Equipos>();
        List<Capa_Objetos.CO_Transacciones> lista_transacciones = new List<Capa_Objetos.CO_Transacciones>();
        List<Capa_Objetos.CO_Detalles_Transacciones> lista_Detalles_Transacciones = new List<Capa_Objetos.CO_Detalles_Transacciones>();
        CO_Transacciones transaccion = new CO_Transacciones();
        CN_Transacciones CN_trans = new CN_Transacciones();
        CO_Equipos equipo = new CO_Equipos();
        CN_Equipos CN_Equip = new CN_Equipos();
        CO_Detalles_Transacciones detTra = new CO_Detalles_Transacciones();
        CN_Detalles_Transacciones CN_detTrans = new CN_Detalles_Transacciones();


        private static int contador = 1;

        private string activo_fijo = "";

        private int Id = 0;
        private bool Editar = false;


        public Transacción()
        {
            InitializeComponent();
            transaccion = new CO_Transacciones();
            cmb_motivo.Items.AddRange(motivosEntrada.ToArray());
            dg_transaccion1.CellFormatting += dg_transaccion1_CellFormatting;
            dg_transaccion.CellFormatting += dg_transaccion_CellFormatting;

        }
        private void Transacción_Load(object sender, EventArgs e)
        {
            ibtn_save.Enabled = false;
            cargarGrid_1();
            cargarGrid_2();
            cargarGrid();
            Ocultar();
        }

        private void Ocultar()
        {
            dg_transaccion.Columns["Fecha_Transaccion"].Visible = false;
            dg_transaccion.Columns["Id_Transacciones"].Visible = false;
            dg_transaccion.Columns["Id"].Visible = false;

        }

        public CO_Transacciones GetData()
        {

            transaccion = new CO_Transacciones();

            transaccion.Fecha_Movimiento = DateTime.Parse(dtp_Fmovimiento.Value.ToShortDateString());
            transaccion.Tipo_Transaccion = cmb_Tipo.Text;
            transaccion.Motivo = cmb_motivo.Text;
            transaccion.Usuario = txt_usuario.Text;
            transaccion.Numero_Transacciones = int.Parse(txt_Ntransaccion.Text);
            transaccion.Fecha_Transaccion = DateTime.Parse(dtp_Fmovimiento.Text);
            transaccion.Cedula = int.Parse(txt_cedula.Text);

            return transaccion;
        }

        public CO_Detalles_Transacciones GetData_1()
        {
            detTra = new CO_Detalles_Transacciones();

            detTra.Activo_Fijo = txt_activo_det.Text;
            detTra.Observacion = txt_obser_det.Text;
            detTra.Fecha_Movimiento = DateTime.Parse(dtp_fmovimiento_det.Value.ToString());
            detTra.Fecha_Transaccion = DateTime.Parse(dtp_fmovimiento_det.Text);
            detTra.Costo = double.Parse(txt_costo_det.Text);

            return detTra;
        }

        public void mostrarDatos()
        {
            activo_fijo = (dg_transaccion1.CurrentRow.Cells["activo_fijo"].Value.ToString());
            equipo = new CO_Equipos();
            equipo = lista_Equipos.Where(e => e.activo_fijo.Equals(activo_fijo)).FirstOrDefault();
            SetData();
        }

        public void mostrarDatos1()
        {
            Id = int.Parse(dg_transaccion.CurrentRow.Cells["id"].Value.ToString());
            detTra = new CO_Detalles_Transacciones();
            detTra = lista_Detalles_Transacciones.Where(e => e.Id.Equals(Id)).FirstOrDefault();
            SetData1();
        }

        public void mostrarDatos2()
        {
            Id = int.Parse(dg_transaccion1.CurrentRow.Cells["id"].Value.ToString());
            transaccion = new CO_Transacciones();
            transaccion = lista_transacciones.Where(e => e.Id.Equals(Id)).FirstOrDefault();
            SetData2();
        }

        public void SetData()
        {
            txt_activo_det.Text = equipo.activo_fijo;
            txt_obser_det.Text = equipo.descripcion;
            txt_costo_det.Text = equipo.costo.ToString();
        }

        public void SetData1()
        {
            txt_activo_det.Text = detTra.Activo_Fijo.ToString();
            txt_obser_det.Text = detTra.Observacion;
            txt_costo_det.Text = detTra.Costo.ToString();
        }

        public void SetData2()
        {
            txt_Ntransaccion.Text = transaccion.Numero_Transacciones.ToString();
            txt_cedula.Text = transaccion.Cedula.ToString();
            cmb_Tipo.Text = transaccion.Tipo_Transaccion.ToString();
            cmb_motivo.Text = transaccion.Motivo.ToString();
            dtp_Fmovimiento.Value = transaccion.Fecha_Transaccion;
            txt_usuario.Text = transaccion.Usuario;
        }

        private void cargarGrid()
        {
            dg_transaccion1.DataSource = null;
            dg_transaccion1.Rows.Clear();
            lista_Equipos = new List<Capa_Objetos.CO_Equipos>();
            lista_Equipos.AddRange(CN_Equip.MostrarEquip());
            CN_Equipos Equip = new CN_Equipos();
            dg_transaccion1.DataSource = Equip.MostrarEquip();
        }

        private void cargarGrid_1()
        {
            dg_transaccion.DataSource = null;
            dg_transaccion.Rows.Clear();
            lista_Detalles_Transacciones = new List<Capa_Objetos.CO_Detalles_Transacciones>();
            lista_Detalles_Transacciones.AddRange(CN_detTrans.MostrarDetTrans());
            CN_Detalles_Transacciones deTrans = new CN_Detalles_Transacciones();
            dg_transaccion.DataSource = deTrans.MostrarDetTrans();
        }

        private void cargarGrid_2()
        {
            dg_transaccion1.DataSource = null;
            dg_transaccion1.Rows.Clear();
            lista_transacciones = new List<Capa_Objetos.CO_Transacciones>();
            lista_transacciones.AddRange(CN_trans.MostrarTrans());
            CN_Transacciones trans = new CN_Transacciones();
            dg_transaccion1.DataSource = trans.MostrarTrans();

        }

        private void ValidCamp()
        {
            var vr = !string.IsNullOrEmpty(txt_cedula.Text) &&
                !string.IsNullOrEmpty(txt_cedula.Text) &&
                !string.IsNullOrEmpty(cmb_motivo.Text) &&
                !string.IsNullOrEmpty(cmb_Tipo.Text) &&
                !string.IsNullOrEmpty(txt_usuario.Text) &&
                !string.IsNullOrEmpty(txt_usuario.Text);

            ibtn_save.Enabled = vr;
        }

        private void limpiar(bool isEdit)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de " + (isEdit ? "agregar estos datos a" : "limpiar") + " el formulario", "Confirmar acción", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                transaccion = new CO_Transacciones();

                if (isEdit)
                {
                    txt_activo_det.Text = string.Empty;
                    txt_costo_det.Text = string.Empty;
                    txt_obser_det.Text = string.Empty;
                    dtp_fmovimiento_det.Text = string.Empty;
                }
                else
                {
                    cmb_motivo.Text = string.Empty;
                    dtp_Fmovimiento.Text = string.Empty;
                    cmb_Tipo.Text = string.Empty;
                    txt_cedula.Text = string.Empty;
                    txt_Ntransaccion.Text = string.Empty;
                    txt_usuario.Text = string.Empty;
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
                        dg_transaccion1.Refresh();
                        Ocultar();
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

        public void agregarDetalleGrilla()
        {
            if (Editar == false)
            {
                try
                {
                    string mensaje = "";
                    if (CN_detTrans.InsertDetTrans(GetData_1()) != 0)
                    {
                        limpiar(true);
                        cargarGrid_1();
                        Ocultar();
                    }
                    else
                    {
                        mensaje = "Error al guardar";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
        }

        public void eliminar()
        {
            if (dg_transaccion.SelectedRows.Count > 0)
            {
                Id = int.Parse(dg_transaccion.CurrentRow.Cells["Id"].Value.ToString());
                if (CN_detTrans.DeleteDetTrans(Id) != 0)
                {
                    MessageBox.Show("Eliminado correctamente");
                    cargarGrid_1();
                    Ocultar();
                }
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void ibtn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar(false);
        }



        private void cmb_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidCamp();
            if (cmb_Tipo.Text == "ENTRADA")
            {
                cmb_motivo.Items.Clear();
                cmb_motivo.Items.AddRange(motivosEntrada.ToArray());
                txt_costo_det.Enabled = true;
            }
            else if (cmb_Tipo.Text == "SALIDA")
            {
                cmb_motivo.Items.Clear();
                cmb_motivo.Items.AddRange(motivosSalida.ToArray());
                txt_costo_det.Enabled = false;
                txt_costo_det.Text = "0";
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
            string coincidencia = txt_buscar.Text;
            var results = lista_Equipos.Where(X => X.descripcion.Contains(coincidencia) || X.activo_fijo.Contains(coincidencia)).Select(X => X).ToList();
            dg_transaccion1.DataSource = results;
        }


        private void txt_Ntransaccion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dg_transaccion1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void dg_transaccion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void txt_costo_det_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txt_costo_det_TextChanged(object sender, EventArgs e)
        {
            ValidCamp();
            if (decimal.TryParse(txt_costo_det.Text, out decimal costo))
            {
                formato_moneda(costo);
                txt_costo_det.SelectionStart = txt_costo_det.Text.Length;
            }
        }

        private void formato_moneda(decimal numero)
        {
            txt_costo_det.Text = numero.ToString("N0");
        }

        private void txt_activo_det_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ibtn_agg_Click(object sender, EventArgs e)
        {
            agregarDetalleGrilla();
        }

        private void ibtn_delete_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void txt_Ntransaccion_TextChanged(object sender, EventArgs e)
        {
            ValidCamp();
        }

        private void txt_cedula_TextChanged(object sender, EventArgs e)
        {
            ValidCamp();
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {
            ValidCamp();
        }

        private void cmb_motivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidCamp();
        }

        private void rb_equip_CheckedChanged(object sender, EventArgs e)
        {
            mostrarDatos2();
        }

        private void dg_transaccion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarDatos1();
        }
    }
}