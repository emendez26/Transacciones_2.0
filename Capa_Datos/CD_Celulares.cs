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
            conexion.iniciarBD(DB_TecnoFuego);
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_Read_celulares";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            
            foreach (DataRow dr in leer)
            {
                celular.id = dr.Table.Columns[0].ToString();
                celular.fecha = DateTime.Parse(dr.Table.Columns[1].ToString());
                celular.usuario = dr.Table.Columns[2].ToString();
                celular.activo_fijo = dr.Table.Columns[3].ToString();
                celular.serial = dr.Table.Columns[4].ToString();
                celular.imei1 = dr.Table.Columns[5].ToString();
                celular.imei2 = dr.Table.Columns[6].ToString();
                celular.marca = dr.Table.Columns[7].ToString();
                celular.modelo = dr.Table.Columns[8].ToString();
                celular.descripcion = dr.Table.Columns[9].ToString();
                celular.fecha_compra = DateOnly.Parse(dr.Table.Columns[10].ToString());
                celular.proveedor = dr.Table.Columns[11].ToString();
                celular.costo = Double.Parse(dr.Table.Columns[12].ToString());
                celular.garantia_anos = Int32.Parse(dr.Table.Columns[13].ToString());
                celular.observacion = dr.Table.Columns[14].ToString();
                celular.responsable = dr.Table.Columns[15].ToString();

                celulares.Add(celular);
                celular = new CO_Celular();
            }
            conexion.CerrarConexion();
            return celulares;

        }

        public int Insert(CO_Celular celular)
        {
            int exitoso = 1;
            //PROCEDIMNIENTO
            try
            {
                conexion.iniciarBD(DB_TecnoFuego);
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "sp_Insert_Celulares";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@fecha", celular.fecha);
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
                comando.Parameters.AddWithValue("@responsable	", celular.responsable);

                exitoso= comando.ExecuteNonQuery();

                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
               
            }

            return exitoso;
        }

        public void Editar(string nombre, string desc, string marca, double precio, int stock, int id)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idpro", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }


    }



}
