namespace COPEREX_PRO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.btnGuardaMovimiento = new System.Windows.Forms.Button();
            this.lblMovCant = new System.Windows.Forms.Label();
            this.lblMovTipo = new System.Windows.Forms.Label();
            this.lblMovFecha = new System.Windows.Forms.Label();
            this.lblMovCliente = new System.Windows.Forms.Label();
            this.lblMovProd = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.cliente_seleccionado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.txtCliTelefono = new System.Windows.Forms.TextBox();
            this.txtCliDireccion = new System.Windows.Forms.TextBox();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNomCliente = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridProductos = new System.Windows.Forms.DataGridView();
            this.seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.p_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1249, 648);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Movimientos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(430, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ver Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtFecha);
            this.panel5.Controls.Add(this.cmbTipo);
            this.panel5.Controls.Add(this.cmbCliente);
            this.panel5.Controls.Add(this.cmbProducto);
            this.panel5.Controls.Add(this.txtCant);
            this.panel5.Controls.Add(this.btnGuardaMovimiento);
            this.panel5.Controls.Add(this.lblMovCant);
            this.panel5.Controls.Add(this.lblMovTipo);
            this.panel5.Controls.Add(this.lblMovFecha);
            this.panel5.Controls.Add(this.lblMovCliente);
            this.panel5.Controls.Add(this.lblMovProd);
            this.panel5.Location = new System.Drawing.Point(28, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(528, 421);
            this.panel5.TabIndex = 0;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(127, 126);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(372, 22);
            this.dtFecha.TabIndex = 10;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Entrada",
            "Salida"});
            this.cmbTipo.Location = new System.Drawing.Point(127, 180);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(372, 24);
            this.cmbTipo.TabIndex = 9;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(127, 75);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(369, 24);
            this.cmbCliente.TabIndex = 8;
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(127, 28);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(372, 24);
            this.cmbProducto.TabIndex = 7;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(127, 243);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(372, 22);
            this.txtCant.TabIndex = 6;
            // 
            // btnGuardaMovimiento
            // 
            this.btnGuardaMovimiento.Location = new System.Drawing.Point(30, 308);
            this.btnGuardaMovimiento.Name = "btnGuardaMovimiento";
            this.btnGuardaMovimiento.Size = new System.Drawing.Size(469, 60);
            this.btnGuardaMovimiento.TabIndex = 5;
            this.btnGuardaMovimiento.Text = "Guardar";
            this.btnGuardaMovimiento.UseVisualStyleBackColor = true;
            this.btnGuardaMovimiento.Click += new System.EventHandler(this.btnGuardar_mov);
            // 
            // lblMovCant
            // 
            this.lblMovCant.AutoSize = true;
            this.lblMovCant.Location = new System.Drawing.Point(27, 248);
            this.lblMovCant.Name = "lblMovCant";
            this.lblMovCant.Size = new System.Drawing.Size(64, 17);
            this.lblMovCant.TabIndex = 4;
            this.lblMovCant.Text = "Cantidad";
            // 
            // lblMovTipo
            // 
            this.lblMovTipo.AutoSize = true;
            this.lblMovTipo.Location = new System.Drawing.Point(27, 187);
            this.lblMovTipo.Name = "lblMovTipo";
            this.lblMovTipo.Size = new System.Drawing.Size(36, 17);
            this.lblMovTipo.TabIndex = 3;
            this.lblMovTipo.Text = "Tipo";
            // 
            // lblMovFecha
            // 
            this.lblMovFecha.AutoSize = true;
            this.lblMovFecha.Location = new System.Drawing.Point(27, 131);
            this.lblMovFecha.Name = "lblMovFecha";
            this.lblMovFecha.Size = new System.Drawing.Size(47, 17);
            this.lblMovFecha.TabIndex = 2;
            this.lblMovFecha.Text = "Fecha";
            // 
            // lblMovCliente
            // 
            this.lblMovCliente.AutoSize = true;
            this.lblMovCliente.Location = new System.Drawing.Point(27, 78);
            this.lblMovCliente.Name = "lblMovCliente";
            this.lblMovCliente.Size = new System.Drawing.Size(51, 17);
            this.lblMovCliente.TabIndex = 1;
            this.lblMovCliente.Text = "Cliente";
            // 
            // lblMovProd
            // 
            this.lblMovProd.AutoSize = true;
            this.lblMovProd.Location = new System.Drawing.Point(27, 35);
            this.lblMovProd.Name = "lblMovProd";
            this.lblMovProd.Size = new System.Drawing.Size(65, 17);
            this.lblMovProd.TabIndex = 0;
            this.lblMovProd.Text = "Producto";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1249, 648);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnEliminarCliente);
            this.panel4.Controls.Add(this.dataGridViewCliente);
            this.panel4.Location = new System.Drawing.Point(473, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(721, 465);
            this.panel4.TabIndex = 1;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(487, 399);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(203, 44);
            this.btnEliminarCliente.TabIndex = 1;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.AllowUserToAddRows = false;
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliente_seleccionado,
            this.id_cliente,
            this.nombre,
            this.direccion,
            this.Telefono});
            this.dataGridViewCliente.Location = new System.Drawing.Point(26, 17);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.RowTemplate.Height = 24;
            this.dataGridViewCliente.Size = new System.Drawing.Size(665, 361);
            this.dataGridViewCliente.TabIndex = 0;
            // 
            // cliente_seleccionado
            // 
            this.cliente_seleccionado.HeaderText = "";
            this.cliente_seleccionado.Name = "cliente_seleccionado";
            // 
            // id_cliente
            // 
            this.id_cliente.DataPropertyName = "id_cliente";
            this.id_cliente.HeaderText = "id_cliente";
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.Visible = false;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            // 
            // panel3
            // 
            this.panel3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel3.Controls.Add(this.btnGuardarCliente);
            this.panel3.Controls.Add(this.txtCliTelefono);
            this.panel3.Controls.Add(this.txtCliDireccion);
            this.panel3.Controls.Add(this.txtNomCliente);
            this.panel3.Controls.Add(this.lblTelefono);
            this.panel3.Controls.Add(this.lblDireccion);
            this.panel3.Controls.Add(this.lblNomCliente);
            this.panel3.Location = new System.Drawing.Point(36, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 288);
            this.panel3.TabIndex = 0;
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(24, 196);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(358, 43);
            this.btnGuardarCliente.TabIndex = 6;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // txtCliTelefono
            // 
            this.txtCliTelefono.Location = new System.Drawing.Point(131, 138);
            this.txtCliTelefono.Name = "txtCliTelefono";
            this.txtCliTelefono.Size = new System.Drawing.Size(251, 22);
            this.txtCliTelefono.TabIndex = 5;
            // 
            // txtCliDireccion
            // 
            this.txtCliDireccion.Location = new System.Drawing.Point(131, 89);
            this.txtCliDireccion.Name = "txtCliDireccion";
            this.txtCliDireccion.Size = new System.Drawing.Size(251, 22);
            this.txtCliDireccion.TabIndex = 4;
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Location = new System.Drawing.Point(131, 37);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(251, 22);
            this.txtNomCliente.TabIndex = 3;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(25, 143);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 17);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(25, 94);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 17);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNomCliente
            // 
            this.lblNomCliente.AutoSize = true;
            this.lblNomCliente.Location = new System.Drawing.Point(25, 42);
            this.lblNomCliente.Name = "lblNomCliente";
            this.lblNomCliente.Size = new System.Drawing.Size(58, 17);
            this.lblNomCliente.TabIndex = 0;
            this.lblNomCliente.Text = "Nombre";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.dataGridProductos);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1249, 648);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Producto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Location = new System.Drawing.Point(755, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 79);
            this.panel2.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(245, 20);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(205, 34);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridProductos
            // 
            this.dataGridProductos.AllowUserToAddRows = false;
            this.dataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seleccion,
            this.p_id,
            this.ID_PRODUCTO,
            this.p_nombre,
            this.p_descripcion,
            this.p_precio});
            this.dataGridProductos.Location = new System.Drawing.Point(513, 27);
            this.dataGridProductos.Name = "dataGridProductos";
            this.dataGridProductos.RowTemplate.Height = 24;
            this.dataGridProductos.Size = new System.Drawing.Size(718, 260);
            this.dataGridProductos.TabIndex = 2;
            this.dataGridProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProductos_CellContentClick_1);
            // 
            // seleccion
            // 
            this.seleccion.HeaderText = "";
            this.seleccion.Name = "seleccion";
            this.seleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.seleccion.Width = 50;
            // 
            // p_id
            // 
            this.p_id.DataPropertyName = "codigo";
            this.p_id.HeaderText = "Codigo";
            this.p_id.Name = "p_id";
            this.p_id.Width = 45;
            // 
            // ID_PRODUCTO
            // 
            this.ID_PRODUCTO.DataPropertyName = "ID_PRODUCTO";
            this.ID_PRODUCTO.HeaderText = "ID_PRODUCTO";
            this.ID_PRODUCTO.Name = "ID_PRODUCTO";
            this.ID_PRODUCTO.Visible = false;
            // 
            // p_nombre
            // 
            this.p_nombre.DataPropertyName = "nombre";
            this.p_nombre.HeaderText = "Nombre";
            this.p_nombre.Name = "p_nombre";
            this.p_nombre.Width = 75;
            // 
            // p_descripcion
            // 
            this.p_descripcion.DataPropertyName = "descripcion";
            this.p_descripcion.HeaderText = "Descripción";
            this.p_descripcion.Name = "p_descripcion";
            this.p_descripcion.Width = 250;
            // 
            // p_precio
            // 
            this.p_precio.DataPropertyName = "precio";
            this.p_precio.HeaderText = "Precio";
            this.p_precio.Name = "p_precio";
            this.p_precio.Width = 70;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.btnGuardarProducto);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Location = new System.Drawing.Point(19, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 537);
            this.panel1.TabIndex = 1;
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Location = new System.Drawing.Point(29, 302);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(415, 51);
            this.btnGuardarProducto.TabIndex = 10;
            this.btnGuardarProducto.Text = "GUARDAR";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(137, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(307, 22);
            this.txtCodigo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "CODIGO";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(137, 136);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(307, 22);
            this.txtPrecio.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "PRECIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "DESCRIPCION";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(137, 188);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(307, 62);
            this.txtDescripcion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(307, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(17, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1257, 677);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 704);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "COPEREX PRO";
            this.tabPage3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Button btnGuardaMovimiento;
        private System.Windows.Forms.Label lblMovCant;
        private System.Windows.Forms.Label lblMovTipo;
        private System.Windows.Forms.Label lblMovFecha;
        private System.Windows.Forms.Label lblMovCliente;
        private System.Windows.Forms.Label lblMovProd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cliente_seleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.TextBox txtCliTelefono;
        private System.Windows.Forms.TextBox txtCliDireccion;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNomCliente;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridProductos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_precio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TabControl tabControl1;
       // private KardexReport KardexReport1;
        private System.Windows.Forms.Button button1;
    }
}

