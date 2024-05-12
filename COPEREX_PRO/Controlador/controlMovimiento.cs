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
    public class ControlMovimiento
    {
        Conexion conexion = null;
        Movimiento movimiento = null;

        public ControlMovimiento(Movimiento mov)
        {
            movimiento = mov;          
        }

  


        public void guardar()
        {
            try
            {
                conexion = new Conexion();
                SqlParameter[] parParameter = new SqlParameter[7];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = movimiento.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_movimiento";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = movimiento.id_movimiento;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@id_producto";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = movimiento.id_producto;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@id_cliente";
                parParameter[3].SqlDbType = SqlDbType.Int;
                parParameter[3].SqlValue = movimiento.id_cliente;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@fecha";
                parParameter[4].SqlDbType = SqlDbType.Date;
                parParameter[4].SqlValue = movimiento.fecha;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@tipo";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 255;
                parParameter[5].SqlValue = movimiento.tipo;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@cantidad";
                parParameter[6].SqlDbType = SqlDbType.Int;
                parParameter[6].SqlValue = movimiento.cantidad;

                conexion.EjecutarSP(parParameter, "SPMovimiento");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }


    }
}
