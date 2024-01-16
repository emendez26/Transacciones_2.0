using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Objetos
{
    public class CO_Transacciones
    {
        public int Id { get; set; }
        public string Tipo_Transaccion { get; set; }
        public string Motivo { get; set; }
        public DateTime Fecha_Movimiento { get; set; }
        public DateTime Fecha_Transaccion { get; set; }
        public string Usuario { get; set; }
        public int Cedula {  get; set; }
        public int Numero_Transacciones { get; set; }
        public List<CO_Detalles_Transacciones> detalles { get; set; }
    }
}
