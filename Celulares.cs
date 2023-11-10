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
        CO_Celular celular = new CO_Celular();
        CN_celulares CN_cell = new CN_celulares();
        public Celulares()
        {
            InitializeComponent();
            celular = new CO_Celular();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            textBoxTel.Text = string.Empty;
            txt_imei1.Text = string.Empty;
            txt_imei2.Text = string.Empty;
            textBoxNum1.Text = string.Empty;
            textBoxNum2.Text = string.Empty;
            textBoxCaract.Text = string.Empty;
            txt_costo.Text = string.Empty;
            txt_fCompra.Text = string.Empty;
            txt_obser.Text = string.Empty;
            txt_descrip.Text = string.Empty;
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guardando");
        }

        private void Celulares_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            if (CN_cell.InsertCell(GetData()) == 1)
            {
                mensaje="Registro Insertado Correctamente";
                cargarGrid();
            }
            else
            {
                mensaje="Error al guardar";
            }
            MessageBox.Show(mensaje);
        }

        public CO_Celular GetData()
        {

            celular = new CO_Celular();

            celular.fecha = DateTime.Now;
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

        private void btn_editar_Click(object sender, EventArgs e)
        {
            CN_cell.UpdateCell(GetData());
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            CN_cell.DeleteCell(celular.id);
        }

        private void cargarGrid()
        {
            dtg_celulares.DataSource = null;
            dtg_celulares.DataSource = CN_cell.MostrarCell();
        }
    }
}
