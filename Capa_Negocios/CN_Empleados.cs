using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Capa_Objetos;
using Capa_Datos;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class CN_Empleados
    {
      
            private CD_Empleados CD_emp = new CD_Empleados();

            public List<Capa_Objetos.CO_Empleados> MostrarEmp()
            {

                List<Capa_Objetos.CO_Empleados> tabla = new List<Capa_Objetos.CO_Empleados>();
                tabla = CD_emp.Read();
                return tabla;
            }
            public int InsertEmp(CO_Empleados empleado)
            {
                return CD_emp.Insert(empleado);
            }

            public int UpdateEmp(int id, CO_Empleados empleado)
            {
                return CD_emp.Update(id, empleado);
            }

            public int DeleteEmp(int id)
            {
                return CD_emp.Delete(id);
            }



    }
}
