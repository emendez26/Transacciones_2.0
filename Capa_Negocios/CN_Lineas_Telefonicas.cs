using Capa_Datos;
using Capa_Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class CN_Lineas_Telefonicas
    {
        private CD_Lineas_Telefonicas CD_lineas = new CD_Lineas_Telefonicas();

        public List<Capa_Objetos.CO_Lineas_Telefonicas> Mostrarlineas()
        {

            List<Capa_Objetos.CO_Lineas_Telefonicas> tabla = new List<Capa_Objetos.CO_Lineas_Telefonicas>();
            tabla = CD_lineas.Read();
            return tabla;
        }
        public int InsertCell(CO_Lineas_Telefonicas linea
            )
        {
            return CD_lineas.Insert(linea);
        }

        public int UpdateCell(int id, CO_Lineas_Telefonicas linea)
        {
            return CD_lineas.Update(id, linea);
        }

        public int DeleteCell(int id)
        {
            return CD_lineas.Delete(id);
        }

    }
}
