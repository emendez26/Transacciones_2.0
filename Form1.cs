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
            Equipo equip = new Equipo();
            equip.Show();
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Transacción trans = new Transacción("EQUIPO");
            trans.Show();
            hideSubMenu();
        }

        private void btn_Celulares_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuCelulares);
        }

        private void btn_form_Celulares_Click(object sender, EventArgs e)
        {
           
            
            Celulares cell = new Celulares();
            cell.Show();
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Transacción trans = new Transacción("CELULARES");
            trans.Show();
            hideSubMenu();



        }

        private void btn_Repuestos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuRepuestos);
        }

        private void btn_form_Repuestos_Click(object sender, EventArgs e)
        {
            Repuestos repu = new Repuestos();
            repu.Show();
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Transacción trans = new Transacción("REPUESTOS");
            trans.Show();
            hideSubMenu();
        }

        private void btn_Lineas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuLineas);
        }

        private void btn_form_Lineas_Click(object sender, EventArgs e)
        {
            Lineas_Telefonicas linea = new Lineas_Telefonicas();
            linea.Show();
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Transacción trans = new Transacción("LINEAS TELEFONICAS");
            trans.Show();
            hideSubMenu();
        }

        private void btn_licencias_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuLicencias);
        }

        private void btn_form_Licencias_Click(object sender, EventArgs e)
        {
            Licencias licen = new Licencias();
            licen.Show();
            hideSubMenu();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Transacción trans = new Transacción("LICENCIAS");
            trans.Show();
            hideSubMenu();
        }
        private void btn_form_toner_Click(object sender, EventArgs e)
        {
            Toner ton = new Toner();
            ton.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Transacción trans = new Transacción("TONERS");
            trans.Show();
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

        private void btn_Toner_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuToner);
        }

    }
}
