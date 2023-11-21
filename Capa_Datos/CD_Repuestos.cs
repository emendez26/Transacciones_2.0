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
    public class CD_Repuestos
    {
        static int Epicor10Live = 1;
        static int DB_TecnoFuego = 2;

        CO_Repuestos repuesto = new CO_Repuestos();
        List<CO_Repuestos> repuestos = new List<CO_Repuestos>();

        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public List<CO_Repuestos> Read()
        {
            try
            {
                conexion.iniciarBD(DB_TecnoFuego);
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "[sp_Read_Repuestos]";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(leer);
                foreach (DataRow dr in table.Rows)
                {
                    repuesto.id = int.Parse(dr[0].ToString());
                    repuesto.marca = dr[1].ToString();
                    repuesto.modelo = dr[2].ToString();
                    repuesto.caracteristica = dr[3].ToString();
                    repuesto.costo = double.Parse(dr[4].ToString());
                    repuesto.estado = dr[5].ToString();
                    repuesto.tipo_repuesto = dr[6].ToString();

                    repuestos.Add(repuesto);
                    repuesto = new CO_Repuestos();
                }
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return repuestos;
        }

        public int Insert(CO_Repuestos repuesto)
        {
            int exitoso = 0;
            //PROCEDIMNIENTO
            try
            {
                conexion.iniciarBD(DB_TecnoFuego);
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "sp_Insert_Repuestos";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@marca", repuesto.marca);
                comando.Parameters.AddWithValue("@modelo", repuesto.modelo);
                comando.Parameters.AddWithValue("@caracteristicas", repuesto.caracteristica);
                comando.Parameters.AddWithValue("@costo", repuesto.costo);
                comando.Parameters.AddWithValue("@estado", repuesto.estado);
                comando.Parameters.AddWithValue("@tipo_repuesto", repuesto.tipo_repuesto);
       
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
        public int Update(int id, CO_Repuestos repuesto)
        {
            int exitoso = 0;
            try
            {

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "sp_Update_Repuesto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@marca", repuesto.marca);
                comando.Parameters.AddWithValue("@modelo", repuesto.modelo);
                comando.Parameters.AddWithValue("@caracteristicas", repuesto.caracteristica);
                comando.Parameters.AddWithValue("@costo", repuesto.costo);
                comando.Parameters.AddWithValue("@estado", repuesto.estado);
                comando.Parameters.AddWithValue("@tipo_repuesto", repuesto.tipo_repuesto);

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
                comando.CommandText = "sp_Delete_Repuestos";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id_repuestos", id);

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

