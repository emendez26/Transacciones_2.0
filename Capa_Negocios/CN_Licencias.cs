using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Objetos;

namespace Capa_Negocios
{
    public class CN_Licencias
    {
        private CD_Licencias CD_lic = new CD_Licencias();

        public List<Capa_Objetos.CO_Licencias> MostrarLic()
        {

            List<Capa_Objetos.CO_Licencias> tabla = new List<Capa_Objetos.CO_Licencias>();
            tabla = CD_lic.Read();
            return tabla;
        }
        public int InsertLic(CO_Licencias licencia)
        {
            return CD_lic.Insert(licencia);
        }

        public int UpdateLic(int id, CO_Licencias licencia)
        {
            return CD_lic.Update(id, licencia);
        }

        public int DeleteLic(int id)
        {
            return CD_lic.Delete(id);
        }
    }
}
