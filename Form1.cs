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
            AbrirFormulario<Equipo>();
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Transacción>();
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormulario<transaccion_salida>();
            hideSubMenu();
        }

        private void btn_Celulares_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuCelulares);
        }

        private void btn_form_Celulares_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Celulares>();
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Transacción>();
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormulario<transaccion_salida>();
            hideSubMenu();
        }

        private void btn_Repuestos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuRepuestos);
        }

        private void btn_form_Repuestos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Repuestos>();
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Transacción>();
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AbrirFormulario<transaccion_salida>();
            hideSubMenu();
        }

        private void btn_Lineas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuLineas);
        }

        private void btn_form_Lineas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Lineas_Telefonicas>();
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Transacción>();
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AbrirFormulario<transaccion_salida>();
            hideSubMenu();
        }

        private void btn_licencias_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuLicencias);
        }

        private void btn_form_Licencias_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Licencias>();
            hideSubMenu();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Transacción>();
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
                formulario.Dock = DockStyle.Fill;
                panelFormulario.Controls.Add(formulario);
                panelFormulario.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
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
            AbrirFormulario<Reporte>();
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Stock>();
        }

        private void btn_empleado_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Empleado>();
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