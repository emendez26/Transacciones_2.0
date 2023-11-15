using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Objetos;


namespace Capa_Datos
{

    public class CD_Equipos
    {
        static int Epicor10Live = 1;
        static int DB_TecnoFuego = 2;

        CO_Equipos equipo = new CO_Equipos();
        List<CO_Equipos> equipos = new List<CO_Equipos>();

        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public List<CO_Equipos> Read()
        {
            try
            {
                conexion.iniciarBD(DB_TecnoFuego);
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "[sp_read_Equipos";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(leer);
                foreach (DataRow dr in table.Rows)
                {
                    equipo.id = int.Parse(dr[0].ToString());
                    equipo.activo_fijo = dr[1].ToString();
                    equipo.estado = dr[2].ToString();
                    equipo.tipo = dr[3].ToString();
                    equipo.sub_tipo = dr[4].ToString();
                    equipo.marca = dr[5].ToString();
                    equipo.modelo = dr[6].ToString();
                    equipo.descripcion = dr[7].ToString();
                    equipo.serial = dr[8].ToString();
                    equipo.responsable = dr[9].ToString();
                    equipo.ubicacion = dr[10].ToString();
                    equipo.departamento = dr[11].ToString();
                    equipo.area = dr[12].ToString();
                    equipo.inactive = bool.Parse(dr[13].ToString());
                    equipo.fecha_compra = DateTime.Parse(dr[14].ToString());
                    equipo.costo = Double.Parse(dr[15].ToString());
                    equipo.tipo_adquisicion = dr[16].ToString();
                    

                    equipos.Add(equipo);
                    equipo = new CO_Equipos();
                }
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
            return equipos;
        }
    }
}
