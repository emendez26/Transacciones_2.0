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


namespace Proyecto_inventario
{
    public partial class Transacción : Form, IContract
    {
        //List<string> motivosEntrada = new List<string>() { "COMPRA", "DEVOLUCION", "OBSEQUIO" };
        //List<string> motivosSalida = new List<string>() { "DEVOLUCION", "ASIGNACIÓN", "PRESTAMO", "MANTENIMIENTO", "HURTO", "OBSOLETO", "PERDIDA" };

        static int empleado = 2;
        static int equipo = 1;

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

        public Transacción()
        {
            InitializeComponent();
            transaccion = new CO_Transacciones();
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

        private void Transacción_Load(object sender, EventArgs e)
        {
            cargarGrid();
            Switch();
            ComboBox();
            cargarGridDetalles();
            Ocultar();
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
            transaccion.Numero_Transacciones = int.Parse(txt_Ntransaccion.Text);
            transaccion.Fecha_Transaccion = DateTime.Parse(dtp_Fmovimiento.Text);
            transaccion.Cedula = int.Parse(txt_cedula.Text);

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

        public void mostrarDatosDetalles()
        {
            Id = int.Parse(dg_detalles.CurrentRow.Cells["id"].Value.ToString());
            detTra = new CO_Detalles_Transacciones();
            detTra = lista_Detalles_Transacciones.Where(e => e.Id.Equals(Id)).FirstOrDefault();
            SetDataEquipo();
        }

        public void SetData()
        {
            txt_Ntransaccion.Text = transaccion.Numero_Transacciones.ToString();
            cmb_Tipo.Text = transaccion.Tipo_Transaccion.ToString();
            cmb_motivo.Text = transaccion.Motivo.ToString();
            dtp_Fmovimiento.Value = transaccion.Fecha_Transaccion;
            txt_usuario.Text = transaccion.Usuario;
            txt_cedula.Text = transaccion.Cedula.ToString();
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

        private void ComboBox()
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

        private bool ValidCamp()
        {
            bool OK = true;

            if (txt_usuario.Text == "")
            {
                OK = false;
                errorProvider1.SetError(txt_usuario, "Ingrese un usuario para continuar");
            }

            return OK;
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
            txt_usuario.Text = string.Empty;
            txt_observ.Text = string.Empty;
            cmb_Tipo.SelectedIndex = -1;
            cmb_motivo.SelectedIndex = -1;
            txt_descrip_det.Text = string.Empty;
        }

        public void guardar()
        {
            ValidCamp();
            try
            {
                string mensaje = "";
                if (CN_trans.InsertTrans(GetData()) != 0)
                {
                    mensaje = "Registro Insertado Correctamente";
                    agregarDetalleGrilla();
                    cargarGrid();
                    limpiar();
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

        private void ibtn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void cmb_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mov = (from sw in switches
                       where sw.cod_sw == cmb_Tipo.SelectedValue
                       select new { code = sw.cod_mov, descripcion = sw.desc_mov }).ToList();
            cmb_motivo.DataSource = mov;
            cmb_motivo.ValueMember = "code";
            cmb_motivo.DisplayMember = "descripcion";
        }

        private void ibtn_save_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void dg_transaccion1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarDatos();

            txt_cedula_KeyPress(sender, new KeyPressEventArgs((char)Keys.Enter));
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            string coincidencia = txt_buscar.Text;
            var results = lista_transacciones.Where(X => X.Id.ToString().Contains(coincidencia) || X.Cedula.ToString().Contains(coincidencia)).Select(X => X).ToList();
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

        private void ibtn_agg_Click(object sender, EventArgs e)
        {
            agregarDetalleGrilla();

            //Ocultar();
        }

        private void ibtn_delete_Click(object sender, EventArgs e)
        {
            eliminar();
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
    }
}