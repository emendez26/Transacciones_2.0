using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocios
{
    public class CN_Stocks
    {
        private CD_Equipos CD_Equip = new CD_Equipos();

        public List<Capa_Objetos.CO_Equipos> MostrarEquip()
        {
            List<Capa_Objetos.CO_Equipos> tabla = new List<Capa_Objetos.CO_Equipos>();
            tabla = CD_Equip.Read();
            return tabla;
        }
    }
}
