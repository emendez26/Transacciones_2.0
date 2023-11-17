using Capa_Objetos;
using Capa_Negocios;
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
    public partial class Empleado : Form
    {

         List<Capa_Objetos.CO_Celular> lista_celulares = new List<Capa_Objetos.CO_Celular>();
        CO_Celular celular = new CO_Celular();
        CN_celulares CN_cell = new CN_celulares();

        private int id = 0;
        private bool Editar = false;

        public Empleado()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.ibtn_Registrar, "Registrar");
            this.ttmensaje.SetToolTip(this.ibtn_limpiar, "Limpiar");
        }
    }
}
