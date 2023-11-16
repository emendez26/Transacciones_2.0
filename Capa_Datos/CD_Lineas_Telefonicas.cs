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
    public class CD_Lineas_Telefonicas
    {
        static int Epicor10Live = 1;
        static int DB_TecnoFuego = 2;

        CO_Lineas_Telefonicas linea = new CO_Lineas_Telefonicas();
        List<CO_Lineas_Telefonicas> linea_tel = new List<CO_Lineas_Telefonicas>();

        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public List<CO_Lineas_Telefonicas> Read()
        {
            try
            {
                conexion.iniciarBD(DB_TecnoFuego);
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "[sp_Read_Lineas_telefonicas]";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(leer);
                foreach (DataRow dr in table.Rows)
                {
                    linea.id = int.Parse(dr[0].ToString());
                    linea.linea_telefonica = Double.Parse(dr[1].ToString());
                    linea.plan= dr[2].ToString();
                    linea.proveedor = dr[3].ToString();
                    linea.caracteristicas = dr[4].ToString();
                   

                    linea_tel.Add(linea);
                    linea = new CO_Lineas_Telefonicas();
                }
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return linea_tel;
        }


        public int Insert(CO_Lineas_Telefonicas celular)
        {
            int exitoso = 0;
            //PROCEDIMNIENTO
            try
            {
                conexion.iniciarBD(DB_TecnoFuego);
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "sp_Insert_Lineas_telefonicas";
                comando.CommandType = CommandType.StoredProcedure;
               
                comando.Parameters.AddWithValue("@linea_telefonica", linea.linea_telefonica);
                comando.Parameters.AddWithValue("@plan", linea.plan);
                comando.Parameters.AddWithValue("@proveedor", linea.proveedor);
                comando.Parameters.AddWithValue("@caracteristicas ", linea.caracteristicas);
                

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

        public int Update(int id, CO_Lineas_Telefonicas linea)
        {
            int exitoso = 0;
            try
            {

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "[sp_Update_Lineas_telefonicas]";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@linea_telefonica", linea.linea_telefonica);
                comando.Parameters.AddWithValue("@plan", linea.plan);
                comando.Parameters.AddWithValue("@proveedor", linea.proveedor);
                comando.Parameters.AddWithValue("@caracteristicas ", linea.caracteristicas);
               

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
                comando.CommandText = "sp_Delete_Lineas_telefonicas";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("id_Lineas_telefonicas", id);

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
       
        