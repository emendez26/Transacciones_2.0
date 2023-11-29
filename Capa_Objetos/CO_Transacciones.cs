using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Objetos
{
    public class CO_Transacciones
    {
        public int id { get; set; }
        public DateTime fecha_transaccion { get; set; }
        public DateTime fecha_movimiento { get; set; }
        public string tipo_transaccion { get; set; }
        public string responsable { get; set; }
        public string motivo { get; set; }
        public string formulario { get; set; }

    }
}
