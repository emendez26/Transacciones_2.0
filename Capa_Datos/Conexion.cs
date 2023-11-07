using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capa_Datos
{
    internal class Conexion
    {
        private SqlConnection conexion;// = new SqlConnection(con);

        public void iniciarBD(int sw_bd)
        {
            string BaseDatos = "";
            if (sw_bd == 1)
            {
                BaseDatos = "Epicor10Live";
            }
            else
            {
                BaseDatos = "DB_TECNOFUEGO";
            }

            string con = "Server=10.25.5.15;DataBase=" + BaseDatos + "; user=sa; password=TecFire8901%; Integrated Security=false";
            SqlConnection conexion = new SqlConnection(con);
        }

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }
}
