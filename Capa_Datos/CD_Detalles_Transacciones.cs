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
    public class CD_Detalles_Transacciones
    {
        static int Epicor10Live = 1;
        static int DB_TecnoFuego = 2;

        CO_Detalles_Transacciones DetTransacciones = new CO_Detalles_Transacciones();
        List<CO_Detalles_Transacciones> Detalles_Transacciones = new List<CO_Detalles_Transacciones>();

        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public List<CO_Detalles_Transacciones> Read(int id)
        {
            try
            {
                conexion.iniciarBD(DB_TecnoFuego);
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "sp_Read_Det_Transacciones";
                comando.Parameters.AddWithValue("@Id", id);
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(leer);
                foreach (DataRow dr in table.Rows)
                {
                    DetTransacciones.Id = int.Parse(dr[0].ToString());
                    DetTransacciones.Id_Transacciones = int.Parse(dr[1].ToString());
                    DetTransacciones.Observacion = dr[2].ToString();
                    DetTransacciones.Fecha_Movimiento = DateTime.Parse(dr[3].ToString());
                    DetTransacciones.Fecha_Transaccion = DateTime.Parse(dr[4].ToString());
                    DetTransacciones.Costo = double.Parse(dr[5].ToString());
                    DetTransacciones.Activo_Fijo = dr[6].ToString();


                    Detalles_Transacciones.Add(DetTransacciones);
                    DetTransacciones = new CO_Detalles_Transacciones();
                }
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Detalles_Transacciones;
        }

        public int Insert(int id, List<CO_Detalles_Transacciones> ListaDetalle)
        {
            int exitoso = 0;
            //PROCEDIMNIENTO
            try
            {
                conexion.iniciarBD(DB_TecnoFuego);
                comando.Connection = conexion.AbrirConexion();

                foreach (CO_Detalles_Transacciones DetTransaccion in ListaDetalle)
                {
                    comando.CommandText = "sp_Insert_Det_Transacciones";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Id_Transacciones", id);
                    comando.Parameters.AddWithValue("@Observacion", DetTransaccion.Observacion);
                    comando.Parameters.AddWithValue("@Fecha_Movimiento", DetTransaccion.Fecha_Movimiento);
                    comando.Parameters.AddWithValue("@Fecha_Transaccion", DateTime.Now);
                    comando.Parameters.AddWithValue("@Costo", DetTransaccion.Costo);
                    comando.Parameters.AddWithValue("@Activo_Fijo", DetTransaccion.Activo_Fijo);

                    exitoso += comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message error : " + ex, "Error al guardar");
            }

            return exitoso;
        }

        public int Delete(int Id)
        {
            int result = 0;
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "sp_Delete_Det_Transacciones";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id_Det_Transacciones", Id);

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
