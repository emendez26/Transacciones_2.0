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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            //7d
            dtp_Fecha_Inicio.Value = DateTime.Today.AddDays(-7);
            dtp_Fecha_Final.Value = DateTime.Now;
            btn_Fecha_7Dia.Select();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
