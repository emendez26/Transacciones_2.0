using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Objetos
{
    public class CO_Licencias
    {
        public int id { get; set; }
        public string activacion { get; set; }
        public string Caracteristicas { get; set; }
        public double costo { get; set; }
        public DateTime fecha_Inicio { get; set; }
        public DateTime fecha_Fin { get; set; }
        public string anos_Licencia { get; set; }
    }
}
