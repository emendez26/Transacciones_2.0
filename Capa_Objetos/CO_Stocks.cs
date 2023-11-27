using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Objetos
{
    public class CO_Stocks
    {
        public string activo_fijo { get; set; }
        public string estado { get; set; }
        public string tipo { get; set; }
        public string sub_tipo { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string descripcion { get; set; }
        public string serial { get; set; }
        public string responsable { get; set; }
        public string ubicacion { get; set; }
        public string departamento { get; set; }
        public string area { get; set; }
        public bool inactive { get; set; }
        public DateTime? fecha_compra { get; set; }
        public double costo { get; set; }
        public string tipo_adquisicion { get; set; }
    }
}
