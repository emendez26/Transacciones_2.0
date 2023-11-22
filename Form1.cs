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
        public Form1()
        {
            InitializeComponent();
            CustomizeDesing();
        }

        private void CustomizeDesing()
        {
            panelSubMenuDeEquipo.Visible = false;
            panelSubMenuCelulares.Visible = false;
            panelSubMenuLicencias.Visible = false;
            panelSubMenuLineas.Visible = false;
            panelSubMenuRepuestos.Visible = false;
            panelSubMenuToner.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenuDeEquipo.Visible == true)
                panelSubMenuDeEquipo.Visible = false;
            if (panelSubMenuCelulares.Visible == true)
                panelSubMenuCelulares.Visible = false;
            if (panelSubMenuLicencias.Visible == true)
                panelSubMenuLicencias.Visible = false;
            if (panelSubMenuLineas.Visible == true)
                panelSubMenuLineas.Visible = false;
            if (panelSubMenuRepuestos.Visible == true)
                panelSubMenuRepuestos.Visible = false;
            if (panelSubMenuToner.Visible == true)
                panelSubMenuToner.Visible = false;
        }

        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

        private void btn_equipo_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuDeEquipo);
        }

        private void btn_form_equipo_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Equipo>();
            Equipo equip = new Equipo();
            equip.Show();
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Transacción trans = new Transacción();
            trans.Show();
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            transaccion_salida tsalida = new transaccion_salida();
            tsalida.Show();
            hideSubMenu();
        }

        private void btn_Celulares_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuCelulares);
        }

        private void btn_form_Celulares_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Celulares>();
            Celulares cell = new Celulares();
            cell.Show();
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Transacción trans = new Transacción();
            trans.Show();
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            transaccion_salida tsalida = new transaccion_salida();
            tsalida.Show();
            hideSubMenu();
        }

        private void btn_Repuestos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuRepuestos);
        }

        private void btn_form_Repuestos_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Repuestos>();
            Repuestos repu = new Repuestos();
            repu.Show();
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Transacción trans = new Transacción();
            trans.Show();
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            transaccion_salida tsalida = new transaccion_salida();
            tsalida.Show();
            hideSubMenu();
        }

        private void btn_Lineas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuLineas);
        }

        private void btn_form_Lineas_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Lineas_Telefonicas>();
            Lineas_Telefonicas linea = new Lineas_Telefonicas();
            linea.Show();
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Transacción>();
            Transacción trans = new Transacción();
            trans.Show();
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<transaccion_salida>();
            transaccion_salida tsalida = new transaccion_salida();
            tsalida.Show();
            hideSubMenu();
        }

        private void btn_licencias_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuLicencias);
        }

        private void btn_form_Licencias_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Licencias>();
            Licencias licen = new Licencias();
            licen.Show();
            hideSubMenu();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Transacción trans = new Transacción();
            trans.Show();
            hideSubMenu();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormulario.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.Sizable;
                formulario.Show();

            }

            else
            {
                formulario.BringToFront();
            }
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Dashboard>();
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Reporte>();
            Reporte reporte = new Reporte();
            reporte.Show();
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.Show();
            //AbrirFormulario<Stock>();
        }

        private void btn_empleado_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Empleado>();
            Empleado emp = new Empleado();
            emp.Show();
        }

        private void btn_Toner_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuToner);
        }

        private void btn_form_toner_Click(object sender, EventArgs e)
        {
            Toner ton = new Toner();
            ton.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Transacción>();
            Transacción trans = new Transacción();
            trans.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            transaccion_salida tsalida = new transaccion_salida();
            tsalida.Show();
        }
    }
}


//Frm_dashboard.TopLevel = false;
//int x = (panel_contenedor.Width - Frm_dashboard.Width) / 2;
//int y = (panel_contenedor.Height - Frm_dashboard.Height) / 2;
//Frm_dashboard.Location = new Point(x, y);
//panel_contenedor.Controls.Add(Frm_dashboard);

//Frm_transaccion.TopLevel = false;
//int x = (panel_contenedor.Width - Frm_transaccion.Width) / 2;
//int y = (panel_contenedor.Height - Frm_transaccion.Height) / 2;
//Frm_transaccion.Location = new Point(x, y);
//panel_contenedor.Controls.Add(Frm_transaccion);