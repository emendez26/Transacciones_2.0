using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Objetos;

namespace Capa_Negocios
{
    public class CN_Transacciones
    {
        private CD_Transacciones CD_trans = new CD_Transacciones();

        public List<Capa_Objetos.CO_Switch> MostrarSwitch()
        {
            List<Capa_Objetos.CO_Switch> tabla = new List<Capa_Objetos.CO_Switch>();
            tabla = CD_trans.LoadSw();
            return tabla;
        }

        public List<Capa_Objetos.CO_Transacciones> MostrarTrans()
        {

            List<Capa_Objetos.CO_Transacciones> tabla = new List<Capa_Objetos.CO_Transacciones>();
            tabla = CD_trans.Read();
            return tabla;
        }
        public int InsertTrans(CO_Transacciones Transaccion)
        {
            int id = 0;
            id = CD_trans.Insert(Transaccion);
            if (id != 0)
            {
                CD_Detalles_Transacciones DetTrans = new CD_Detalles_Transacciones();
                DetTrans.Insert(id, Transaccion.detalles);
            }
            return id;
        }

    }
}
