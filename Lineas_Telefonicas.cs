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
        CN_Lineas_Telefonicas CD_lineas = new CN_Lineas_Telefonicas();

        private int id = 0;
        private bool Editar = false;


        public Lineas_Telefonicas()
        {
            //InitializeComponent();
            //this.ttmensaje.SetToolTip(this.ibtn_limpiar, "Limpiar");
            //this.ttmensaje.SetToolTip(this.ibtn_delete, "Eliminar");
            //this.ttmensaje.SetToolTip(this.ibtn_save, "Guardar");
            //this.ttmensaje.SetToolTip(this.ibtn_update, "Editar");
            //linea = new CO_Lineas_Telefonicas();
        }
        private void Lineas_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        public CO_Lineas_Telefonicas GetData()
        {

            linea = new CO_Lineas_Telefonicas();

            //linea.usuario = "Admin";
            linea.linea_telefonica = double.Parse(text_linea.Text);
            linea.plan = cmb_plan.Text;
            linea.proveedor = text_proveedor.Text;
            linea.caracteristicas = txt_caract.Text;


            return linea;
        }

        public void SetData()
        {
            text_linea.Text = linea.linea_telefonica.ToString();
            cmb_plan.Text = linea.plan;
            text_proveedor.Text = linea.proveedor;
            txt_caract.Text = linea.caracteristicas;



        }

        public void mostrarDatos()
        {

            id = int.Parse(dtg_linea.CurrentRow.Cells["linea_telefonica"].Value.ToString());
            linea = new CO_Lineas_Telefonicas();
           linea = lista_Lineas.Where(e => e.id.Equals(id)).FirstOrDefault();
            SetData();
        }

        private void cargarGrid()
        {
            //dtg_linea.DataSource = null;
            //dtg_linea.Rows.Clear();
            //lista_Lineas = new List<Capa_Objetos.CO_Lineas_Telefonicas>();
            //lista_Lineas.AddRange(CD_lineas.MostrarLinea());
            //dtg_linea.DataSource = lista_Lineas;
        }

    }
}
