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
    public partial class Form1 : Form
    {
        string usuario = "";

        public Form1(string user)
        {
            InitializeComponent();
            usuario = user;
            lbluser.Text = "Usuario: " + usuario;
            lbldatetime.Text = "Ult. Vez: " + DateTime.Now.ToString();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Show();
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.Show();
        }

        private void btn_empleado_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.Show();
        }

        private void btn_equipo_Click(object sender, EventArgs e)
        {
            Equipo equip = new Equipo();
            equip.Show();
        }

        private void btn_Celulares_Click(object sender, EventArgs e)
        {
            Celulares celu = new Celulares();
            celu.Show();
        }

        private void btn_Repuestos_Click(object sender, EventArgs e)
        {
            Repuestos repu = new Repuestos();
            repu.Show();
        }

        private void btn_Lineas_Click(object sender, EventArgs e)
        {
            Lineas_Telefonicas linea = new Lineas_Telefonicas();
            linea.Show();
        }

        private void btn_licencias_Click(object sender, EventArgs e)
        {
            Licencias lic = new Licencias();
            lic.Show();
        }

        private void btn_Transaccion_Click(object sender, EventArgs e)
        {
            Transacción trans = new Transacción();
            trans.Show();
        }
    }
}
