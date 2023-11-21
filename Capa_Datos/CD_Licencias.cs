using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Objetos;

namespace Capa_Datos
{
    public class CD_Licencias
    {

        static int Epicor10Live = 1;
        static int DB_TecnoFuego = 2;

        CO_Licencias licencia = new CO_Licencias();
        List<CO_Licencias> licencias = new List<CO_Licencias>();

        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();  

        public List<CO_Licencias> Read()
        {
            try
            {
                conexion.iniciarBD(DB_TecnoFuego);
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "sp_Read_Licencia";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(leer);
                foreach (DataRow dr in table.Rows)
                {
                    licencia.id = int.Parse(dr[0].ToString());
                    licencia.activacion = bool.Parse(dr[1].ToString());
                    licencia.Caracteristicas = dr[2].ToString();
                    licencia.costo = Double.Parse(dr[3].ToString());
                    licencia.fecha_Inicio = DateTime.Parse(dr[4].ToString());
                    licencia.fecha_Fin = DateTime.Parse(dr[5].ToString());
                    licencia.anos_Licencia = int.Parse(dr[6].ToString());
                    licencia.proveedor = dr[7].ToString();


                    licencias.Add(licencia);
                    licencia = new CO_Licencias();
                }
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return licencias;
        }

        public int Insert(CO_Licencias licencia)
        {
            int exitoso = 0;
            //PROCEDIMNIENTO
            try
            {
                conexion.iniciarBD(DB_TecnoFuego);
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "[sp_Insert_Licencia]";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@activacion ", licencia.activacion);
                comando.Parameters.AddWithValue("@Caracteristicas ", licencia.Caracteristicas);
                comando.Parameters.AddWithValue("@costo", licencia.costo);
                comando.Parameters.AddWithValue("@fecha_Inicio", licencia.fecha_Inicio);
                comando.Parameters.AddWithValue("@fecha_Fin ", licencia.fecha_Fin);
                comando.Parameters.AddWithValue("@anos_Licencia ", licencia.anos_Licencia);
                comando.Parameters.AddWithValue("@proveedor", licencia.proveedor);

                exitoso = comando.ExecuteNonQuery();

                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message error : " + ex, "Error al guardar");
            }

            return exitoso;
        }

        public int Update(int id, CO_Licencias licencia)
        {
            int exitoso = 0;
            try
            {

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "sp_Update_Licencia";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@activacion ", licencia.activacion);
                comando.Parameters.AddWithValue("@Caracteristicas ", licencia.Caracteristicas);
                comando.Parameters.AddWithValue("@costo", licencia.costo);
                comando.Parameters.AddWithValue("@fecha_Inicio", licencia.fecha_Inicio);
                comando.Parameters.AddWithValue("@fecha_Fin ", licencia.fecha_Fin);
                comando.Parameters.AddWithValue("@anos_Licencia ", licencia.anos_Licencia);
                comando.Parameters.AddWithValue("@proveedor", licencia.proveedor);


                exitoso = comando.ExecuteNonQuery();

                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message error : " + ex, "Error al guardar");
            }

            return exitoso;
        }

        public int Delete(int id)
        {
            int result = 0;
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "sp_Delete_Licencia";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id_licencia", id);

                result = comando.ExecuteNonQuery();

                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message error : " + ex, "Error al Editar");
            }


            return result;
        }
    }
}
