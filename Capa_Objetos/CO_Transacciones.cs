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
        public int numero_transaccion { get; set; }
        public int activo_fijo {  get; set; }
        public string descripcion { get; set;}
        public double costo { get; set; }
        public string tipo_transaccion { get; set; }
        public string motivo { get; set; }
        public DateTime fecha_movimiento { get; set; }
        public DateTime fecha_transaccion { get; set; }
        public string responsable { get; set; }
        public string usuario { get; set; }
        public string observaciones { get; set; }
        public string formularios { get; set; }

    }
}
