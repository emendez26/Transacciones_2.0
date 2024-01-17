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

        public List<CO_Switch> LoadSw()
        {
            List<CO_Switch> Switchs = new List<CO_Switch>();
            try
            {
                conexion.iniciarBD(DB_TecnoFuego);
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "[sp_Read_Switch]";
                comando.CommandType = CommandType.StoredProcedure;
                Switchs = new List<CO_Switch>();

                Switchs.Add(new CO_Switch());

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CO_Switch Switch = new CO_Switch();
                        Switch.cod_sw = reader["codigo_sw"].ToString();
                        Switch.desc_sw = reader["desc_sw"].ToString();
                        Switch.cod_mov = reader["cod_mov"].ToString();
                        Switch.desc_mov = reader["desc_mov"].ToString();

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
            int id = 0;
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
                comando.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                comando.ExecuteNonQuery();

                id = (int) comando.Parameters["@id"].Value;

                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message error : " + ex, "Error al guardar");
            }

            return id;
        }
    }

}
