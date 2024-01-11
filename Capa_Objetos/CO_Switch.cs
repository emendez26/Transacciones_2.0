using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Objetos
{
    public class CO_Switch
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public string cod_sw { get; set; }
        public string desc_sw { get; set; }

        public CO_Switch() {
            this.Codigo = string.Empty;
            this.Descripcion = string.Empty;
        }
    }
}
