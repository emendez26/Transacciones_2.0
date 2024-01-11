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

        public List<Capa_Objetos.CO_UserCode> MostrarSwitch(int sw)
        {
            List<Capa_Objetos.CO_UserCode> tabla = new List<Capa_Objetos.CO_UserCode>();
            tabla = CD_trans.LoadSw(sw);
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
            return CD_trans.Insert(Transaccion);
        }

    }
}
 