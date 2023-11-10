using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Objetos;

namespace Capa_Negocios
{
    public class CN_celulares
    {
        private CD_Celulares CD_cell = new CD_Celulares();

        public List<Capa_Objetos.CO_Celular> MostrarCell()
        {

            List<Capa_Objetos.CO_Celular> tabla = new List<Capa_Objetos.CO_Celular>();
            tabla = CD_cell.Read();
            return tabla;
        }
        public int InsertCell(CO_Celular celular)
        {
            return CD_cell.Insert(celular);
        }

        public int UpdateCell(int id, CO_Celular celular)
        {
            return CD_cell.Update(id, celular);
        }

        public int DeleteCell(int id)
        {
            return CD_cell.Delete(id);
        }


    }
}
