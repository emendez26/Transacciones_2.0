using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Objetos;
using System.Collections;
using System.Numerics;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;


namespace Capa_Datos
{
    public class CD_Celulares
    {
        static int Epicor10Live = 1;
        static int DB_TecnoFuego = 2;

        CO_Celular celular = new CO_Celular();
        List<CO_Celular> celulares = new List<CO_Celular>();

        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public List<CO_Celular> Read()
        {
            try
            {
                conexion.iniciarBD(DB_TecnoFuego);
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "[sp_Read_Celulares]";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(leer);
                foreach (DataRow dr in table.Rows)
                {
                    celular.id = int.Parse(dr[0].ToString());
                    celular.fecha = DateTime.Parse(dr[1].ToString());
                    celular.usuario = dr[2].ToString();
                    celular.activo_fijo = dr[3].ToString();
                    celular.serial = dr[4].ToString();
                    celular.imei1 = dr[5].ToString();
                    celular.imei2 = dr[6].ToString();
                    celular.marca = dr[7].ToString();
                    celular.modelo = dr[8].ToString();
                    celular.descripcion = dr[9].ToString();
                    celular.fecha_compra = DateTime.Parse(dr[10].ToString());
                    celular.proveedor = dr[11].ToString();
                    celular.costo = Double.Parse(dr[12].ToString());
                    celular.garantia_anos = Int32.Parse(dr[13].ToString());
                    celular.observacion = dr[14].ToString();
                    celular.responsable = dr[15].ToString();

                    celulares.Add(celular);
                    celular = new CO_Celular();
                }
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return celulares;
        }

        public int Insert(CO_Celular celular)
        {
            int exitoso = 0;
            //PROCEDIMNIENTO
            try
            {
                conexion.iniciarBD(DB_TecnoFuego);
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "sp_Insert_Celulares";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@fecha", DateTime.Now);
                comando.Parameters.AddWithValue("@usuario", celular.usuario);
                comando.Parameters.AddWithValue("@activo_fijo", celular.activo_fijo);
                comando.Parameters.AddWithValue("@serial", celular.serial);
                comando.Parameters.AddWithValue("@imei1", celular.imei1);
                comando.Parameters.AddWithValue("@imei2", celular.imei2);
                comando.Parameters.AddWithValue("@marca", celular.marca);
                comando.Parameters.AddWithValue("@modelo", celular.modelo);
                comando.Parameters.AddWithValue("@descripcion", celular.descripcion);
                comando.Parameters.AddWithValue("@fecha_compra", celular.fecha_compra);
                comando.Parameters.AddWithValue("@proveedor", celular.proveedor);
                comando.Parameters.AddWithValue("@costo", celular.costo);
                comando.Parameters.AddWithValue("@garantia_anos", celular.garantia_anos);
                comando.Parameters.AddWithValue("@observacion", celular.observacion);
                comando.Parameters.AddWithValue("@responsable", celular.responsable);

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

        public int Update(int id, CO_Celular celular)
        {
            int exitoso = 0;
            try
            {

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "[sp_Update_Celulares]";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@activo_fijo", celular.activo_fijo);
                comando.Parameters.AddWithValue("@serial", celular.serial);
                comando.Parameters.AddWithValue("@imei1", celular.imei1);
                comando.Parameters.AddWithValue("@imei2", celular.imei2);
                comando.Parameters.AddWithValue("@marca", celular.marca);
                comando.Parameters.AddWithValue("@modelo", celular.modelo);
                comando.Parameters.AddWithValue("@descripcion", celular.descripcion);
                comando.Parameters.AddWithValue("@fecha_compra", celular.fecha_compra);
                comando.Parameters.AddWithValue("@proveedor", celular.proveedor);
                comando.Parameters.AddWithValue("@costo", celular.costo);
                comando.Parameters.AddWithValue("@garantia_anos", celular.garantia_anos);
                comando.Parameters.AddWithValue("@observacion", celular.observacion);
                comando.Parameters.AddWithValue("@responsable", celular.responsable);

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
                comando.CommandText = "sp_delete_celulares";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id_celulares", id);

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
