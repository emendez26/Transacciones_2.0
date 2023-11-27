using Capa_Negocios;
using Capa_Objetos;
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
    public partial class Transaccion_Lineas : Form
    {

        List<string> motivosEntrada = new List<string>() { "COMPRA", "DEVOLUCION", "OBSEQUIO" };
        List<string> motivosSalida = new List<string>() { "DEVOLUCION", "ASIGNACIÓN", "PRESTAMO", "MANTENIMIENTO", "HURTO", "OBSOLETO", "PERDIDA" };

        List<Capa_Objetos.CO_Transacciones> lista_transacciones = new List<Capa_Objetos.CO_Transacciones>();
        CO_Transacciones transaccion = new CO_Transacciones();
        CN_Transacciones CN_trans = new CN_Transacciones();


        string formulario = "";

        private int id = 0;
        private bool Editar = false;


        public Transaccion_Lineas(string formulario)
        {
            InitializeComponent();
            transaccion = new CO_Transacciones();
            cmb_motivo.Items.AddRange(motivosEntrada.ToArray());
            this.formulario = formulario;
        }
    }
}
