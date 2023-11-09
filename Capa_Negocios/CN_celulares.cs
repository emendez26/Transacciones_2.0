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
        private CD_Celulares objetoCD = new CD_Celulares();

        public List<Capa_Objetos.CO_Celular> MostrarCell()
        {

            List<Capa_Objetos.CO_Celular> tabla = new List<Capa_Objetos.CO_Celular>();
            tabla = objetoCD.Read();
            return tabla;
        }
        public void InsertCell(CO_Celular celular)
        {

            objetoCD.Insert(celular);
        }

        public void UpdateCell(CO_Celular celular)
        {
            objetoCD.Update(celular);
        }

        public void DeleteCell(string id)
        {

            objetoCD.Delete(Convert.ToInt32(id));
        }


    }
}
