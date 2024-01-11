using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Objetos
{
    public class CO_Switch
    {
        public string cod_mov { get; set; }
        public string desc_mov { get; set; }
        public string cod_sw { get; set; }
        public string desc_sw { get; set; }

        public CO_Switch() {
            this.cod_sw = string.Empty;
            this.desc_sw = string.Empty;
            this.cod_mov = string.Empty;
            this.desc_mov = string.Empty;
        }
    }
}
