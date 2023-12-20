using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Objetos
{
    public class CO_Empleados
    {
        public int id { get; set; }
        public string identificacion { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string ubicacion {  get; set; }
        public string departamento { get; set; }
        public bool area { get; set; }
        public bool activo { get; set; }
    }
}
