using Capa_Datos;
using Capa_Negocios;
using Capa_Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Interop;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;


namespace Proyecto_inventario
{
    public partial class Transacción : Form, IContract
    {
        //List<string> motivosEntrada = new List<string>() { "COMPRA", "DEVOLUCION", "OBSEQUIO" };
        //List<string> motivosSalida = new List<string>() { "DEVOLUCION", "ASIGNACIÓN", "PRESTAMO", "MANTENIMIENTO", "HURTO", "OBSOLETO", "PERDIDA" };
        static int equipo = 1;
        static int empleado = 2;
        string usuario = "";

        List<Capa_Objetos.CO_Transacciones> lista_transacciones = new List<Capa_Objetos.CO_Transacciones>();
        List<Capa_Objetos.CO_Detalles_Transacciones> lista_Detalles_Transacciones = new List<Capa_Objetos.CO_Detalles_Transacciones>();
        List<Capa_Objetos.CO_Empleados> lista_empleados = new List<Capa_Objetos.CO_Empleados>();
        CN_Empleados CN_emp = new CN_Empleados();
        CO_Transacciones transaccion = new CO_Transacciones();
        CN_Transacciones CN_trans = new CN_Transacciones();
        CO_Detalles_Transacciones detTra = new CO_Detalles_Transacciones();
        CN_Detalles_Transacciones CN_detTrans = new CN_Detalles_Transacciones();
        List<CO_Switch> switches = new List<CO_Switch>();

        private int Id = 0;
        public int pr = 0;

        public Transacción(string user)
        {
            InitializeComponent();
            transaccion = new CO_Transacciones();
            usuario = user;
            txt_usuario.Text = usuario;
        }
        private void Transacción_Load(object sender, EventArgs e)
        {
            Switch();
            CargarCmb_DatosEmpleado();
            cargarGrid();
            cargarGridDetalles();
            Ocultar();
        }

        private void Switch()
        {
            switches = CN_trans.MostrarSwitch();

            var swt = (from sw in switches
                       select new { code = sw.cod_sw, descripcion = sw.desc_sw }).ToList().Distinct().ToList();
            cmb_Tipo.DataSource = swt;
            cmb_Tipo.ValueMember = "code";
            cmb_Tipo.DisplayMember = "descripcion";
        }
        private void cmb_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mov = (from sw in switches
                       where sw.cod_sw == cmb_Tipo.SelectedValue
                       select new { code = sw.cod_mov, descripcion = sw.desc_mov }).ToList();
            cmb_motivo.DataSource = mov;
            cmb_motivo.ValueMember = "code";
            cmb_motivo.DisplayMember = "descripcion";

            if (txt_costo_det.Text == "salida")
            {
                txt_costo_det.Enabled = false;
            }
            else if (txt_costo_det.Text == "entrada")
            {
                txt_costo_det.Enabled = true;
            }
        }

        private void CargarCmb_DatosEmpleado()
        {
            cmb_area.DataSource = CN_emp.MostrarCod(2);
            cmb_area.DisplayMember = "descripcion";
            cmb_area.ValueMember = "code";
            cmb_depart.DataSource = CN_emp.MostrarCod(3);
            cmb_depart.DisplayMember = "descripcion";
            cmb_depart.ValueMember = "code";
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

        private void cargarGridDetalles()
        {
            dg_detalles.DataSource = null;
            dg_detalles.Rows.Clear();
            lista_Detalles_Transacciones = new List<Capa_Objetos.CO_Detalles_Transacciones>();
            lista_Detalles_Transacciones.AddRange(CN_detTrans.MostrarDetTrans(Id));
            CN_Detalles_Transacciones DetTrans = new CN_Detalles_Transacciones();
            dg_detalles.DataSource = DetTrans.MostrarDetTrans(Id);
        }

        private void Ocultar()
        {
            dg_detalles.Columns["Fecha_Transaccion"].Visible = false;
            dg_detalles.Columns["Id_Transacciones"].Visible = false;
            dg_detalles.Columns["Id"].Visible = false;
        }

        public CO_Transacciones GetData()
        {
            transaccion = new CO_Transacciones();

            transaccion.Fecha_Movimiento = DateTime.Parse(dtp_Fmovimiento.Value.ToShortDateString());
            transaccion.Tipo_Transaccion = cmb_Tipo.Text;
            transaccion.Motivo = cmb_motivo.Text;
            transaccion.Usuario = txt_usuario.Text;
            transaccion.Numero_Transacciones = 5002;
            transaccion.Fecha_Transaccion = DateTime.Parse(dtp_Fmovimiento.Text);
            transaccion.Cedula = int.Parse(txt_cedula.Text);
            transaccion.detalles = lista_Detalles_Transacciones;

            return transaccion;
        }

        public CO_Detalles_Transacciones GetDataDetalles()
        {
            detTra = new CO_Detalles_Transacciones();

            detTra.Activo_Fijo = txt_activo_det.Text;
            detTra.Observacion = txt_obser_det.Text;
            detTra.Fecha_Movimiento = DateTime.Parse(dtp_fmovimiento_det.Value.ToShortDateString());
            detTra.Fecha_Transaccion = DateTime.Parse(dtp_fmovimiento_det.Text);
            detTra.Costo = double.Parse(txt_costo_det.Text);
            detTra.Descripcion = txt_descrip_det.Text;

            return detTra;
        }

        public void mostrarDatos()
        {
            Id = int.Parse(dg_transaccion1.CurrentRow.Cells["id"].Value.ToString());
            transaccion = new CO_Transacciones();
            transaccion = lista_transacciones.Where(e => e.Id.Equals(Id)).FirstOrDefault();
            SetData();
        }

        public void SetData()
        {
            txt_Ntransaccion.Text = transaccion.Numero_Transacciones.ToString();
            cmb_Tipo.Text = transaccion.Tipo_Transaccion.ToString();
            cmb_motivo.Text = transaccion.Motivo.ToString();
            dtp_Fmovimiento.Value = transaccion.Fecha_Transaccion;
            txt_usuario.Text = transaccion.Usuario;
            txt_cedula.Text = transaccion.Cedula.ToString();
            dg_detalles.DataSource = null;
            CD_Detalles_Transacciones det_trans = new CD_Detalles_Transacciones();
            transaccion.detalles = det_trans.Read(transaccion.Id);
            dg_detalles.Rows.Clear();
            dg_detalles.DataSource = transaccion.detalles;
        }

        public void SetDataEquipo()
        {
            txt_activo_det.Text = detTra.Activo_Fijo.ToString();
            txt_obser_det.Text = detTra.Observacion;
            txt_costo_det.Text = detTra.Costo.ToString();
            txt_descrip_det.Text = detTra.Descripcion;
        }

        public void SetDataEquipos(CO_Equipos Equi)
        {
            txt_activo_det.Text = Equi.activo_fijo.ToString();
            txt_descrip_det.Text = Equi.descripcion.ToString();
            txt_costo_det.Text = Equi.costo.ToString();
        }

        public void SetDataEmpleados(CO_Empleados Empl)
        {
            if (Empl != null && !string.IsNullOrEmpty(Empl.identificacion))
            {
                string[] partesNombre = Empl.nombre.Split(' ');
                string[] partesApellido = Empl.apellido.Split(' ');
                string primerNombre = partesNombre.Length > 0 ? partesNombre[0] : "";
                string primerApellido = partesApellido.Length > 0 ? partesApellido[0] : "";
                txt_cedula.Text = Empl.identificacion.ToString();
                txt_nombre.Text = $"{primerNombre} {primerApellido}";
                cmb_depart.SelectedValue = Empl.departamento.ToString();
                cmb_area.SelectedValue = Empl.area.ToString();
            }
            else
            {
                txt_nombre.Text = "";
                cmb_depart.SelectedIndex = -1;
                cmb_area.SelectedIndex = -1;

                MessageBox.Show("No existe este empleado", "Empleado no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void limpiar()
        {
            transaccion = new CO_Transacciones();
            txt_activo_det.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            cmb_depart.Text = string.Empty;
            cmb_area.Text = string.Empty;
            txt_costo_det.Text = string.Empty;
            txt_obser_det.Text = string.Empty;
            dtp_fmovimiento_det.Text = string.Empty;
            dtp_Fmovimiento.Text = string.Empty;
            txt_cedula.Text = string.Empty;
            txt_Ntransaccion.Text = string.Empty;
            cmb_Tipo.SelectedIndex = -1;
            cmb_motivo.SelectedIndex = -1;
            txt_descrip_det.Text = string.Empty;
            dg_detalles.DataSource = null;
            dg_detalles.Rows.Clear();
            dg_detalles.DataSource = lista_Detalles_Transacciones;
            Ocultar();
        }

        public void guardar()
        {
            try
            {
                string mensaje = "";
                if (CN_trans.InsertTrans(GetData()) != 0)
                {
                    mensaje = "Registro Insertado Correctamente";
                    cargarGrid();
                    Ocultar();
                }
                else
                {
                    mensaje = "Error al guardar";
                }
                MessageBox.Show(mensaje);
            }
            catch
            {
                MessageBox.Show("Faltan campos por llenar");
            }
        }

        public void agregarDetalleGrilla()
        {
            GetDataDetalles();

            //Agregar a la lista
            lista_Detalles_Transacciones.Add(detTra);

            //Agregar a la grilla
            dg_detalles.DataSource = null;
            dg_detalles.Rows.Clear();
            dg_detalles.DataSource = lista_Detalles_Transacciones;
            Ocultar();
        }

        public void eliminar()
        {
            DataGridViewSelectedRowCollection selectedRows = dg_detalles.SelectedRows;
            if (selectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in selectedRows)
                {
                    int id = int.Parse(row.Cells["id"].Value.ToString());
                    CO_Detalles_Transacciones detalle = lista_Detalles_Transacciones.FirstOrDefault(d => d.Id.Equals(id));
                    if (detalle != null)
                    {
                        lista_Detalles_Transacciones.Remove(detalle);
                    }
                }
                dg_detalles.DataSource = null;
                dg_detalles.Rows.Clear();
                dg_detalles.DataSource = lista_Detalles_Transacciones;
                Ocultar();
            }
        }
        private void ibtn_agg_Click(object sender, EventArgs e)
        {
            agregarDetalleGrilla();
            txt_activo_det.Text = "";
            txt_costo_det.Text = "";
            txt_descrip_det.Text = "";
            txt_obser_det.Text = "";
        }
        private void ibtn_save_Click(object sender, EventArgs e)
        {
            guardar();
        }
        private void ibtn_nuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            txt_obser_det.Enabled = true;
            dtp_fmovimiento_det.Enabled = true;
            dtp_Fmovimiento.Enabled = true;
            cmb_motivo.Enabled = true;
            cmb_Tipo.Enabled = true;
            txt_activo_det.Enabled = true;
            txt_costo_det.Enabled = true;
            txt_cedula.Enabled = true;
            ibtn_agg.Enabled = true;
            ibtn_buscar_activo.Enabled = true;
            ibtn_buscar_id.Enabled = true;
            ibtn_delete.Enabled = true;
            ibtn_save.Enabled = true;
            dg_transaccion1.Enabled = false;
        }

        private void ibtn_delete_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void ibtn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void ibtn_buscar_id_Click(object sender, EventArgs e)
        {
            Buscar buscar = new Buscar(empleado);
            buscar.contratoEmpleados = this;
            buscar.Show();
        }

        private void ibtn_buscar_activo_Click(object sender, EventArgs e)
        {
            Buscar buscar = new Buscar(equipo);
            buscar.contrato = this;
            buscar.Show();
        }

        private void dg_transaccion1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarDatos();
            Ocultar();
            txt_cedula_KeyPress(sender, new KeyPressEventArgs((char)Keys.Enter));
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            string coincidencia = txt_buscar.Text;
            var results = lista_transacciones.Where(X => X.Numero_Transacciones.ToString().Contains(coincidencia) || X.Cedula.ToString().Contains(coincidencia)).Select(X => X).ToList();
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
            if (e.KeyChar == (char)13)
            {
                CD_Empleados empl = new CD_Empleados();
                string codigo = txt_cedula.Text;
                SetDataEmpleados(empl.Read(codigo).FirstOrDefault());
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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

            if (e.KeyChar == (char)13)
            {
                CD_Equipos eq = new CD_Equipos();
                string codigo = txt_activo_det.Text;
                SetDataEquipos(eq.Read(codigo).FirstOrDefault());
            }

        }
    }
}