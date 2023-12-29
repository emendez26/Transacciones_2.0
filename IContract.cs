using Capa_Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_inventario
{
    public interface IContract
    {
        void SetDataEquipos(CO_Equipos equip);

        void SetDataEmpleados(CO_Empleados emp);
    }
}
