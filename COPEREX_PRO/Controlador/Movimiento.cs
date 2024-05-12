using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class Movimiento
    {
        public int opc { get; set; }

        public int id_movimiento { get; set; }
        public int id_producto { get; set; }
        public int id_cliente { get; set; }
        public DateTime fecha { get; set; }
        public string tipo { get; set; }
        public int cantidad { get; set; }


    }
}
