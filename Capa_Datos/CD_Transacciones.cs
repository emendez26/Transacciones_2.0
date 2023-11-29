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
    public class CD_Transacciones
    {
        static int Epicor10Live = 1;
        static int DB_TecnoFuego = 2;

        CO_Transacciones transaccion = new CO_Transacciones();
        List<CO_Transacciones> transacciones = new List<CO_Transacciones>();

        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public List<CO_Transacciones> Read()
        {
            try
            {
                conexion.iniciarBD(DB_TecnoFuego);
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "sp_Read_Transacciones";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(leer);
                foreach (DataRow dr in table.Rows)
                {
                    transaccion.id = int.Parse(dr[0].ToString());
                    transaccion.fecha_transaccion = DateTime.Parse(dr[1].ToString());
                    transaccion.fecha_movimiento = DateTime.Parse(dr[2].ToString());
                    transaccion.tipo_transaccion = dr[3].ToString();
                    transaccion.responsable = dr[6].ToString();
                    transaccion.motivo = dr[7].ToString();
                    transaccion.formulario = dr[8].ToString();

                    transacciones.Add(transaccion);
                    transaccion = new CO_Transacciones();
                }
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return transacciones;
        }

        public int Insert(CO_Transacciones transaccion)
        {
            int exitoso = 0;
            //PROCEDIMNIENTO
            try
            {
                conexion.iniciarBD(DB_TecnoFuego);
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "sp_Insert_Transacciones";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@fecha_transaccion", DateTime.Now);
                comando.Parameters.AddWithValue("@fecha_movimiento", transaccion.fecha_movimiento);
                comando.Parameters.AddWithValue("@tipo_transaccion", transaccion.tipo_transaccion);
                comando.Parameters.AddWithValue("@responsable", transaccion.responsable);
                comando.Parameters.AddWithValue("@motivo", transaccion.motivo);
                comando.Parameters.AddWithValue("@formulario", transaccion.formulario);

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
    }
    
}
