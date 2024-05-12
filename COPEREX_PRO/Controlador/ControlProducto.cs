using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Modelo;

namespace Controlador
{
    public class ControlProducto
    {
        Conexion conexion = null;
        Producto producto = null;
        DataTable tblProductos = null;
        List<string[]> lsProducto;

        public ControlProducto(Producto parProducto)
        {
            producto = parProducto;
        }


        public DataTable listar()
        {
            tblProductos = new DataTable();
            try
            {
                conexion = new Conexion();
                SqlParameter[] parParameter = new SqlParameter[1];
                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = producto.opc;
                tblProductos = conexion.RetornaTabla(parParameter, "SPProducto");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblProductos;

        }

        public List<string[]> getProducto()
        {
            lsProducto = new List<string[]>();
            try
            {
                conexion = new Conexion();
                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = producto.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_producto";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = producto.id_producto;

                lsProducto = conexion.RetornaLista(parParameter, "SPProducto");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return lsProducto;

        }

        public void guardar()
        {
            try
            {
                conexion = new Conexion();
                SqlParameter[] parParameter = new SqlParameter[5];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = producto.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@codigo";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = producto.codigo;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombre";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 100;
                parParameter[2].SqlValue = producto.nombre;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@descripcion";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 255;
                parParameter[3].SqlValue = producto.descripcion;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@precio";
                parParameter[4].SqlDbType = SqlDbType.Decimal;
                parParameter[4].SqlValue = producto.precio;

                conexion.EjecutarSP(parParameter, "SPProducto");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }


        public void actualizar()
        {
            try
            {
                conexion = new Conexion();
                SqlParameter[] parParameter = new SqlParameter[6];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = producto.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_producto";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = producto.id_producto;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@codigo";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = producto.codigo;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@nombre";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 100;
                parParameter[3].SqlValue = producto.nombre;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@descripcion";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 255;
                parParameter[4].SqlValue = producto.descripcion;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@precio";
                parParameter[5].SqlDbType = SqlDbType.Decimal;
                parParameter[5].SqlValue = producto.precio;

                conexion.EjecutarSP(parParameter, "SPProducto");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public void eliminar()
        {
            conexion = new Conexion();

            SqlParameter[] parParameter = new SqlParameter[2];

            parParameter[0] = new SqlParameter();
            parParameter[0].ParameterName = "@opc";
            parParameter[0].SqlDbType = SqlDbType.Int;
            parParameter[0].SqlValue = producto.opc;

            parParameter[1] = new SqlParameter();
            parParameter[1].ParameterName = "@id_producto";
            parParameter[1].SqlDbType = SqlDbType.Int;
            parParameter[1].SqlValue = producto.id_producto;

            conexion.EjecutarSP(parParameter, "SPProducto");

        }




        public List<KeyValuePair<int, string>> llenarCmbProductos() {

            tblProductos = new DataTable();
            List<KeyValuePair<int, string>> productos = new List<KeyValuePair<int, string>>();
            try
            {
                conexion = new Conexion();
                tblProductos = conexion.LlenarCmb("SELECT * FROM TBL_PRODUCTO");
                foreach (DataRow row in tblProductos.Rows)
                {
                    int idProducto = Convert.ToInt32(row["ID_PRODUCTO"]);
                    string nombreProducto = row["NOMBRE"].ToString();
                    productos.Add(new KeyValuePair<int, string>(idProducto, nombreProducto));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return productos;

        }

     








    }






}
