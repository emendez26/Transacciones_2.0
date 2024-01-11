using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Objetos
{
    public class CO_UserCode
    {
        public string code { get; set; }
        public string descripcion { get; set; }
       


        public CO_UserCode() {
            this.code = string.Empty;   
            this.descripcion = string.Empty;
        }

    }
}
