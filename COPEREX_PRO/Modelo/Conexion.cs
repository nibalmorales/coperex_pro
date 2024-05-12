using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class Conexion
    {

        SqlConnection cnnConexion = null;
        SqlCommand cmdComando = null;
        SqlDataAdapter daAdaptador = null;
        DataTable dataTable = null;
        string strCadenaConexion = string.Empty;


        public Conexion()
        {
           strCadenaConexion = @"Data Source=ADVENGER\SQLEXPRESS;database=COPEREXDB;User ID=sa; Password=123; Connect Timeout=30;";
        }


        public void EjecutarSP(SqlParameter[] parParametros, string parSPName)
        {
            try
            {
                cnnConexion = new SqlConnection(strCadenaConexion);
                cmdComando = new SqlCommand();
                cmdComando.Connection = cnnConexion;
                //Abrimos la conexion
                cnnConexion.Open();
                //Asignamos el tipo de comando a ejecutar
                cmdComando.CommandType = CommandType.StoredProcedure;
                //Agregamos el nombre del procedure
                cmdComando.CommandText = parSPName;
                //Agregamos los parametros a ejecutar
                cmdComando.Parameters.AddRange(parParametros);
                //Ejecutamos
                cmdComando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cnnConexion.Dispose();
                cmdComando.Dispose();
            }
        }

        public DataTable RetornaTabla(SqlParameter[] parParametros, string parTSQL)
        {
            dataTable = null;
            try
            {
                dataTable = new DataTable();
                cnnConexion = new SqlConnection(strCadenaConexion);
                cmdComando = new SqlCommand();
                cmdComando.Connection = cnnConexion;
                cmdComando.CommandType = CommandType.StoredProcedure;
                cmdComando.CommandText = parTSQL;
                cmdComando.Parameters.AddRange(parParametros);
                daAdaptador = new SqlDataAdapter(cmdComando);
                daAdaptador.Fill(dataTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cnnConexion.Dispose();
                cmdComando.Dispose();
                daAdaptador.Dispose();
            }
            return dataTable;
        }



        public List<string[]> RetornaLista(SqlParameter[] parParametros, string parTSQL)
        {
            List<string[]> listaResultados = new List<string[]>();
            try
            {
                using (SqlConnection cnnConexion = new SqlConnection(strCadenaConexion))
                {
                    using (SqlCommand cmdComando = new SqlCommand(parTSQL, cnnConexion))
                    {
                        cmdComando.CommandType = CommandType.StoredProcedure;
                        cmdComando.Parameters.AddRange(parParametros);
                        cnnConexion.Open();
                        using (SqlDataReader reader = cmdComando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string[] fila = new string[reader.FieldCount];
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    fila[i] = reader[i].ToString();
                                }
                                listaResultados.Add(fila);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaResultados;
        }



        public DataTable LlenarCmb(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection cnnConexion = new SqlConnection(strCadenaConexion))
                {
                    cnnConexion.Open();
                    using (SqlCommand cmdComando = new SqlCommand(query, cnnConexion))
                    {
                        using (SqlDataAdapter daAdaptador = new SqlDataAdapter(cmdComando))
                        {
                            daAdaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }




    }
}
