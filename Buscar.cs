using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Objetos;
using Capa_Negocios;
using System.Data.Common;
using System.Transactions;

namespace Proyecto_inventario
{
    public partial class Buscar : Form
    {
        List<Capa_Objetos.CO_Equipos> lista_Equipos;
        CN_Equipos CN_Equip = new CN_Equipos();

        List<Capa_Objetos.CO_Empleados> lista_empleados;
        CN_Empleados CN_emp = new CN_Empleados();

        int op = 0;
        int id = 0;

        public IContract contrato { get; set; }
        public IContract contratoEmpleados { get; set; }

        public Buscar(int sw)
        {
            op = sw;
            InitializeComponent();
        }

        private void cargarGrid()
        {
            dg_buscar.DataSource = null;
            switch (op)
            {
                case 1:
                    lista_Equipos = new List<Capa_Objetos.CO_Equipos>();
                    lista_Equipos.AddRange(CN_Equip.MostrarEquip());
                    dg_buscar.DataSource = lista_Equipos;
                    dg_buscar_Empleado.Visible = false;
                    txt_buscar_empleado.Visible = false;
                    break;
                case 2:
                    lista_empleados = new List<Capa_Objetos.CO_Empleados>();
                    lista_empleados.AddRange(CN_emp.MostrarEmp());
                    dg_buscar_Empleado.DataSource = lista_empleados;
                    break;

            }

        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void dg_buscar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = (dg_buscar.CurrentRow.Cells["activo_fijo"].Value.ToString());
            contrato.SetDataEquipos(lista_Equipos.Where(e => e.activo_fijo.Equals(id)).FirstOrDefault());
            this.Close();
        }

        private void dg_buscar_Empleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dg_buscar_Empleado.CurrentRow.Cells["id"].Value.ToString());
            contratoEmpleados.SetDataEmpleados(lista_empleados.Where(e => e.id.Equals(id)).FirstOrDefault());
            this.Close();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            string coincidencia = txt_buscar.Text;
            var results = lista_Equipos.Where(X => X.activo_fijo.Contains(coincidencia) || X.descripcion.Contains(coincidencia)).Select(X => X).ToList();
            dg_buscar.DataSource = results;
        }

        private void txt_buscar_empleado_TextChanged(object sender, EventArgs e)
        {
            string coincidencia = txt_buscar_empleado.Text;
            var results = lista_empleados.Where(X => X.identificacion.Contains(coincidencia) || X.nombre.Contains(coincidencia)).Select(X => X).ToList();
            dg_buscar_Empleado.DataSource = results;
        }
    }
}
