using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Objetos;

namespace Capa_Negocios
{
    public class CN_Repuestos
    {
        private CD_Repuestos CD_repu = new CD_Repuestos();

        public List<Capa_Objetos.CO_Repuestos> MostrarRepu()
        {
            List<Capa_Objetos.CO_Repuestos> tabla = new List<Capa_Objetos.CO_Repuestos>();
            tabla = CD_repu.Read();
            return tabla;
        }

        public int InsertRepu(CO_Repuestos repuesto)
        {
            return CD_repu.Insert(repuesto);
        }

        public int UpdateRepu(int id, CO_Repuestos repuesto)
        {
            return CD_repu.Update(id, repuesto);
        }

        public int DeleteRepu(int id)
        {
            return CD_repu.Delete(id);
        }
    }
}
