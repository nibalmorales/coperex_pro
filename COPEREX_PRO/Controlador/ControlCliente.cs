using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using System.Data.SqlClient;

namespace Controlador
{
    public class ControlCliente
    {


        Conexion conexion = null;
        Cliente cliente = null;
        DataTable tblCliente = null;

        public ControlCliente(Cliente parCliente)
        {
            cliente = parCliente;
        }


        public DataTable listar()
        {
            tblCliente = new DataTable();
            try
            {
                conexion = new Conexion();
                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = cliente.opc;
                tblCliente = conexion.RetornaTabla(parParameter, "SPCliente");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblCliente;

        }




        public void guardar()
        {
            try
            {
                conexion = new Conexion();
                SqlParameter[] parParameter = new SqlParameter[4];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = cliente.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 100;
                parParameter[1].SqlValue = cliente.nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@direccion";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 100;
                parParameter[2].SqlValue = cliente.direccion;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@telefono";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 20;
                parParameter[3].SqlValue = cliente.telefono;

                conexion.EjecutarSP(parParameter, "SPCliente");
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
            parParameter[0].SqlValue = cliente.opc;

            parParameter[1] = new SqlParameter();
            parParameter[1].ParameterName = "@id_cliente";
            parParameter[1].SqlDbType = SqlDbType.Int;
            parParameter[1].SqlValue = cliente.id_cliente;

            conexion.EjecutarSP(parParameter, "SPCliente");

        }


        public List<KeyValuePair<int, string>> llenarCmbClientes()
        {

            tblCliente = new DataTable();
            List<KeyValuePair<int, string>> clientes = new List<KeyValuePair<int, string>>();
            try
            {
                conexion = new Conexion();
                tblCliente = conexion.LlenarCmb("SELECT * FROM TBL_CLIENTE");
                foreach (DataRow row in tblCliente.Rows)
                {
                    int idCliente = Convert.ToInt32(row["ID_CLIENTE"]);
                    string nombreCliente = row["NOMBRE"].ToString();
                    clientes.Add(new KeyValuePair<int, string>(idCliente, nombreCliente));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return clientes;

        }

    }
}
