using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using CrystalDecisions.CrystalReports.Engine;
using System.Globalization;


namespace COPEREX_PRO
{
    public partial class Form1 : Form
    {     
        Producto producto = null;
        Cliente cliente = null;
        Movimiento movimiento = null;
        ControlProducto controlProducto = null;
        ControlCliente controlCliente = null;
        ControlMovimiento controlMovimiento = null;
        DataTable Dtt = null;
        List<string> lsProductosMarcados = null;
        List<string> lsClientesMarcados = null;
        int idProducto = 0;
        
        public Form1()
        {
            InitializeComponent();
            listarProductos();
            listarClientes();
            controlProducto = new ControlProducto(producto);
            controlCliente = new ControlCliente(cliente);
            llenarComboBox(cmbProducto, controlProducto.llenarCmbProductos());
            llenarComboBox(cmbCliente, controlCliente.llenarCmbClientes());
        }

       

        private void llenarComboBox(ComboBox comboBox, List<KeyValuePair<int, string>> diccionario)
        {
            try
            {
                List<KeyValuePair<int, string>> llaves = diccionario;
                comboBox.Items.Clear();
                comboBox.DataSource = llaves;
                comboBox.DisplayMember = "Value";
                comboBox.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar información: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            guardarProducto();
            listarProductos();
            limpiar();
        }
 

        private void listarProductos()
        {
            producto = new Producto();
            producto.opc = 1;
            controlProducto = new ControlProducto(producto);
            Dtt = new DataTable();
            Dtt = controlProducto.listar();
            if (Dtt.Rows.Count > 0)
                dataGridProductos.DataSource = Dtt;
        }

        private void listarClientes()
        {
            cliente = new Cliente();
            cliente.opc = 1;
            controlCliente = new ControlCliente(cliente);
            Dtt = new DataTable();
            Dtt = controlCliente.listar();
            if (Dtt.Rows.Count > 0)
                dataGridViewCliente.DataSource = Dtt;
        }

        private void guardarProducto()
        {
            if (idProducto==0)
            {             
                producto = new Producto();
                producto.opc = 2;
                producto.codigo = int.Parse(txtCodigo.Text);
                producto.nombre = txtNombre.Text;
                producto.descripcion = txtDescripcion.Text;
                producto.precio = decimal.Parse(txtPrecio.Text);
                controlProducto = new ControlProducto(producto);
                controlProducto.guardar();
                MessageBox.Show("PRODUCTO AGREGADO CORRECTAMENTE", "MENSAJE");
            }
            else
            {
                actualizarProducto();
                MessageBox.Show("PRODUCTO ACTUALIZADO CORRECTAMENTE", "MENSAJE");
            }
        }


        private void obtenerProductosMarcados()
        {
            lsProductosMarcados = new List<string>();
            foreach (DataGridViewRow fila in dataGridProductos.Rows)
            {
                DataGridViewCheckBoxCell celdaCheckBox = fila.Cells["seleccion"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(celdaCheckBox.Value) == true)
                {
                    string idCliente = fila.Cells["ID_PRODUCTO"].Value.ToString();
                    lsProductosMarcados.Add(idCliente);
                }
            }
        }


        private void actualizarProducto()
        {
                producto = new Producto();
                producto.opc = 3;
                producto.id_producto = idProducto;
                producto.codigo = int.Parse(txtCodigo.Text);
                producto.nombre = txtNombre.Text;
                producto.descripcion = txtDescripcion.Text;
                producto.precio = decimal.Parse(txtPrecio.Text); ;
                controlProducto = new ControlProducto(producto);
                controlProducto.actualizar();
                listarProductos();
                limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obtenerProductosMarcados();
            foreach (string informacion in lsProductosMarcados)
            {
                controlProducto = new ControlProducto(producto);
                producto.opc = 4;
                producto.id_producto = int.Parse(informacion);
                controlProducto.eliminar();
                listarProductos();
                limpiar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarProducto();
        }

        private void guardarCliente() {
            cliente = new Cliente();
            cliente.opc = 2;
            cliente.nombre = txtNomCliente.Text;
            cliente.direccion = txtCliDireccion.Text;
            cliente.telefono = txtCliTelefono.Text;
            controlCliente = new ControlCliente(cliente);
            controlCliente.guardar();
            MessageBox.Show("CLIENTE AGREGADO CORRECTAMENTE", "MENSAJE");

        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            guardarCliente();
            listarClientes();
            limpiar();
          
        }

        private void obtenerClientesMarcados()
        {
            lsClientesMarcados = new List<string>();
            foreach (DataGridViewRow fila in dataGridViewCliente.Rows)
            {
                DataGridViewCheckBoxCell celdaCheckBox = fila.Cells["cliente_seleccionado"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(celdaCheckBox.Value) == true)
                {
                    string id_producto = fila.Cells["ID_CLIENTE"].Value.ToString();
                    lsClientesMarcados.Add(id_producto);
                }
            }
        }

        private void limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtNomCliente.Clear();
            txtCliDireccion.Clear();
            txtCliTelefono.Clear();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            obtenerClientesMarcados();
            foreach (string idCliente in lsClientesMarcados)
            {
                controlCliente = new ControlCliente(cliente);
                cliente.opc = 4;
                cliente.id_cliente = int.Parse(idCliente);
                controlCliente.eliminar();
                listarClientes();
                limpiar();
            }
        }

        private void btnGuardar_mov(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex != -1)
            {
                KeyValuePair<int, string> productoSeleccionado = (KeyValuePair<int, string>)cmbProducto.SelectedItem;
                KeyValuePair<int, string> clienteSeleccionado = (KeyValuePair<int, string>)cmbCliente.SelectedItem;

                String tipo = cmbTipo.SelectedIndex.ToString();
                DateTime fechaSinHora = dtFecha.Value.Date;
                string fechaFormateada = fechaSinHora.ToString("dd/MM/yyyy");

                int idProducto = productoSeleccionado.Key;
                int cantidad = int.Parse(txtCant.Text);
                int idCliente = clienteSeleccionado.Key;

                movimiento = new Movimiento();
                movimiento.opc = 2;

                movimiento.id_producto = idProducto;
                movimiento.id_cliente = idCliente;
                movimiento.tipo = tipo;
                movimiento.cantidad = cantidad;
                movimiento.fecha = fechaSinHora;


                controlMovimiento = new ControlMovimiento(movimiento);
                controlMovimiento.guardar();
                MessageBox.Show("Movimiento Generado", "MENSAJE");
              
            }


        }



        private void dataGridProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int id_producto = Convert.ToInt32(dataGridProductos.Rows[e.RowIndex].Cells["id_producto"].Value);
            idProducto = id_producto;
            controlProducto = new ControlProducto(producto);
            producto.opc = 5;
            producto.id_producto = id_producto;
            string[] fila = controlProducto.getProducto()[0];
            txtCodigo.Text = fila[1];
            txtNombre.Text = fila[2];
            txtDescripcion.Text = fila[3];
            txtPrecio.Text = fila[4];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Reporte rep = new Reporte();
            rep.Show();
            
        }
    }
}
