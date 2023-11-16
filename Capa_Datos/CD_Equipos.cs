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
                comando.CommandText = "[sp_Read_Equipo]";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(leer);
                foreach (DataRow dr in table.Rows)
                {
                    equipo.activo_fijo = dr[0].ToString();
                    equipo.estado = dr[1].ToString();
                    equipo.tipo = dr[2].ToString();
                    equipo.sub_tipo = dr[3].ToString();
                    equipo.marca = dr[4].ToString();
                    equipo.modelo = dr[5].ToString();
                    equipo.descripcion = dr[6].ToString();
                    equipo.serial = dr[7].ToString();
                    equipo.responsable = dr[8].ToString();
                    equipo.ubicacion = dr[9].ToString();
                    equipo.departamento = dr[10].ToString();
                    equipo.area = dr[11].ToString();
                    equipo.inactive = bool.Parse(dr[12].ToString());
                    equipo.fecha_compra = (dr[13].ToString()) == null ? (DateTime?) null  : DateTime.Parse(dr[13].ToString());
                    equipo.costo = Double.Parse(dr[14].ToString());
                    equipo.tipo_adquisicion = dr[15].ToString();
                    

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
