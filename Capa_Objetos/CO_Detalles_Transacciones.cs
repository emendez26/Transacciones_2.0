using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Objetos
{
    public class CO_Detalles_Transacciones
    {
        public string Activo_Fijo { get; set; }
        public string Descripcion { get; set; }
        public string Observacion { get; set; }
        public double Costo {  get; set; }
        public DateTime Fecha_Movimiento { get; set; }
        public DateTime Fecha_Transaccion { get; set; }
        public int Id_Transacciones { get; set; }
        public int Id { get; set; }
    }
}
