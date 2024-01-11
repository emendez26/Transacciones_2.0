using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Objetos;
using System.Diagnostics;

namespace Capa_Datos
{
    public class CD_Transacciones
    {
        static int Epicor10Live = 1;
        static int DB_TecnoFuego = 2;

        CO_Transacciones transaccion = new CO_Transacciones();
        List<CO_Transacciones> transacciones = new List<CO_Transacciones>();

        List<CO_UserCode> Switchs = new List<CO_UserCode>();


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
                    transaccion.Id = int.Parse(dr[0].ToString());
                    transaccion.Tipo_Transaccion = dr[1].ToString();
                    transaccion.Motivo = dr[2].ToString();
                    transaccion.Fecha_Movimiento = DateTime.Parse(dr[3].ToString());
                    transaccion.Usuario = dr[4].ToString();
                    transaccion.Cedula = int.Parse(dr[5].ToString());
                    transaccion.Numero_Transacciones = int.Parse(dr[6].ToString());
                    transaccion.Fecha_Transaccion = DateTime.Parse(dr[7].ToString());


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

        public List<CO_UserCode> LoadSw(int sw)
        {
            try
            {
                conexion.iniciarBD(DB_TecnoFuego);
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "LoadSw";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@sw", sw);
                Switchs = new List<CO_UserCode>();

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CO_UserCode Switch = new CO_UserCode();
                        Switch.code = reader["Codigo"].ToString();
                        Switch.descripcion = reader["Descripcion"].ToString();

                        Switchs.Add(Switch);
                    }
                }

                comando.Parameters.Clear();
                conexion.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Switchs;
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
                comando.Parameters.AddWithValue("@Tipo_Transaccion", transaccion.Tipo_Transaccion);
                comando.Parameters.AddWithValue("@Motivo", transaccion.Motivo);
                comando.Parameters.AddWithValue("@Fecha_Movimiento", transaccion.Fecha_Movimiento);
                comando.Parameters.AddWithValue("@Usuario", transaccion.Usuario);
                comando.Parameters.AddWithValue("@Cedula", transaccion.Cedula);
                comando.Parameters.AddWithValue("@Numero_Transacciones", transaccion.Numero_Transacciones);
                comando.Parameters.AddWithValue("@Fecha_Transaccion", DateTime.Now);

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
