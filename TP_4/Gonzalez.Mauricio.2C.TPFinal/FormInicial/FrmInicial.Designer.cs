namespace Vista
{
    partial class FrmInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.listBoxLibros = new System.Windows.Forms.ListBox();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnInformeCliente = new System.Windows.Forms.Button();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reclamosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reclamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.masToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proximosIngresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnInformeLibro = new System.Windows.Forms.Button();
            this.btnModificarLibro = new System.Windows.Forms.Button();
            this.btnEliminarLibro = new System.Windows.Forms.Button();
            this.btnLibreria = new System.Windows.Forms.Button();
            this.lblLibroVendido = new System.Windows.Forms.Label();
            this.reclamosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRegistrarCliente.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarCliente.Location = new System.Drawing.Point(12, 348);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(91, 45);
            this.btnRegistrarCliente.TabIndex = 0;
            this.btnRegistrarCliente.Text = "Agregar cliente";
            this.btnRegistrarCliente.UseVisualStyleBackColor = false;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBoxClientes.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxClientes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.HorizontalScrollbar = true;
            this.listBoxClientes.ItemHeight = 15;
            this.listBoxClientes.Location = new System.Drawing.Point(0, 57);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(396, 274);
            this.listBoxClientes.TabIndex = 2;
            // 
            // listBoxLibros
            // 
            this.listBoxLibros.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBoxLibros.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxLibros.FormattingEnabled = true;
            this.listBoxLibros.HorizontalScrollbar = true;
            this.listBoxLibros.ItemHeight = 15;
            this.listBoxLibros.Location = new System.Drawing.Point(402, 56);
            this.listBoxLibros.Name = "listBoxLibros";
            this.listBoxLibros.Size = new System.Drawing.Size(450, 274);
            this.listBoxLibros.TabIndex = 4;
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAgregarLibro.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarLibro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarLibro.Location = new System.Drawing.Point(595, 348);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(89, 45);
            this.btnAgregarLibro.TabIndex = 5;
            this.btnAgregarLibro.Text = "Agregar nuevo libro";
            this.btnAgregarLibro.UseVisualStyleBackColor = false;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnVender.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVender.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVender.Location = new System.Drawing.Point(364, 337);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(74, 106);
            this.btnVender.TabIndex = 6;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInformeCliente
            // 
            this.btnInformeCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnInformeCliente.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInformeCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInformeCliente.Location = new System.Drawing.Point(162, 348);
            this.btnInformeCliente.Name = "btnInformeCliente";
            this.btnInformeCliente.Size = new System.Drawing.Size(91, 45);
            this.btnInformeCliente.TabIndex = 7;
            this.btnInformeCliente.Text = "Informe cliente";
            this.btnInformeCliente.UseVisualStyleBackColor = false;
            this.btnInformeCliente.Click += new System.EventHandler(this.btnInformeCliente_Click);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Sitka Small", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblClientes.Location = new System.Drawing.Point(0, 31);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(139, 23);
            this.lblClientes.TabIndex = 8;
            this.lblClientes.Text = "Lista de clientes";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Sitka Small", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblStock.Location = new System.Drawing.Point(402, 31);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(130, 23);
            this.lblStock.TabIndex = 9;
            this.lblStock.Text = "Libros en stock";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.reclamosToolStripMenuItem1,
            this.masToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.cargarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.librosToolStripMenuItem1});
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Enabled = false;
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // librosToolStripMenuItem1
            // 
            this.librosToolStripMenuItem1.Enabled = false;
            this.librosToolStripMenuItem1.Name = "librosToolStripMenuItem1";
            this.librosToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.librosToolStripMenuItem1.Text = "Libros";
            this.librosToolStripMenuItem1.Click += new System.EventHandler(this.librosToolStripMenuItem1_Click);
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.librosToolStripMenuItem});
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.cargarToolStripMenuItem.Text = "Cargar ";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.Enabled = false;
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.librosToolStripMenuItem.Text = "Libros";
            this.librosToolStripMenuItem.Click += new System.EventHandler(this.librosToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.verListaToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.informesToolStripMenuItem.Text = "Reclamos";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // verListaToolStripMenuItem
            // 
            this.verListaToolStripMenuItem.Name = "verListaToolStripMenuItem";
            this.verListaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.verListaToolStripMenuItem.Text = "Ver lista";
            this.verListaToolStripMenuItem.Click += new System.EventHandler(this.verListaToolStripMenuItem_Click);
            // 
            // reclamosToolStripMenuItem1
            // 
            this.reclamosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem1,
            this.cargarToolStripMenuItem1});
            this.reclamosToolStripMenuItem1.Name = "reclamosToolStripMenuItem1";
            this.reclamosToolStripMenuItem1.Size = new System.Drawing.Size(92, 20);
            this.reclamosToolStripMenuItem1.Text = "Base de Datos";
            // 
            // guardarToolStripMenuItem1
            // 
            this.guardarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem2,
            this.reclamosToolStripMenuItem,
            this.clientesToolStripMenuItem2});
            this.guardarToolStripMenuItem1.Name = "guardarToolStripMenuItem1";
            this.guardarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem1.Text = "Guardar";
            // 
            // librosToolStripMenuItem2
            // 
            this.librosToolStripMenuItem2.Name = "librosToolStripMenuItem2";
            this.librosToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.librosToolStripMenuItem2.Text = "Libros";
            this.librosToolStripMenuItem2.Click += new System.EventHandler(this.librosToolStripMenuItem2_Click);
            // 
            // reclamosToolStripMenuItem
            // 
            this.reclamosToolStripMenuItem.Name = "reclamosToolStripMenuItem";
            this.reclamosToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.reclamosToolStripMenuItem.Text = "Reclamos";
            this.reclamosToolStripMenuItem.Click += new System.EventHandler(this.reclamosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem2
            // 
            this.clientesToolStripMenuItem2.Enabled = false;
            this.clientesToolStripMenuItem2.Name = "clientesToolStripMenuItem2";
            this.clientesToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.clientesToolStripMenuItem2.Text = "Clientes";
            // 
            // cargarToolStripMenuItem1
            // 
            this.cargarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem3,
            this.clientesToolStripMenuItem3,
            this.reclamosToolStripMenuItem2});
            this.cargarToolStripMenuItem1.Name = "cargarToolStripMenuItem1";
            this.cargarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cargarToolStripMenuItem1.Text = "Cargar";
            // 
            // librosToolStripMenuItem3
            // 
            this.librosToolStripMenuItem3.Name = "librosToolStripMenuItem3";
            this.librosToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.librosToolStripMenuItem3.Text = "Libros";
            this.librosToolStripMenuItem3.Click += new System.EventHandler(this.librosToolStripMenuItem3_Click);
            // 
            // clientesToolStripMenuItem3
            // 
            this.clientesToolStripMenuItem3.Enabled = false;
            this.clientesToolStripMenuItem3.Name = "clientesToolStripMenuItem3";
            this.clientesToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem3.Text = "Clientes";
            // 
            // masToolStripMenuItem
            // 
            this.masToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proximosIngresosToolStripMenuItem});
            this.masToolStripMenuItem.Name = "masToolStripMenuItem";
            this.masToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.masToolStripMenuItem.Text = "Mas";
            // 
            // proximosIngresosToolStripMenuItem
            // 
            this.proximosIngresosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem1,
            this.verToolStripMenuItem});
            this.proximosIngresosToolStripMenuItem.Name = "proximosIngresosToolStripMenuItem";
            this.proximosIngresosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.proximosIngresosToolStripMenuItem.Text = "Proximos Ingresos";
            // 
            // crearToolStripMenuItem1
            // 
            this.crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            this.crearToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.crearToolStripMenuItem1.Text = "Crear";
            this.crearToolStripMenuItem1.Click += new System.EventHandler(this.crearToolStripMenuItem1_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verToolStripMenuItem.Text = "Reproducir cartelera";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnModificarCliente.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarCliente.Location = new System.Drawing.Point(13, 399);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(90, 44);
            this.btnModificarCliente.TabIndex = 11;
            this.btnModificarCliente.Text = "Modificar cliente";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarCliente.Location = new System.Drawing.Point(162, 399);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(91, 44);
            this.btnEliminarCliente.TabIndex = 12;
            this.btnEliminarCliente.Text = "Eliminar cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnInformeLibro
            // 
            this.btnInformeLibro.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnInformeLibro.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInformeLibro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInformeLibro.Location = new System.Drawing.Point(745, 348);
            this.btnInformeLibro.Name = "btnInformeLibro";
            this.btnInformeLibro.Size = new System.Drawing.Size(86, 45);
            this.btnInformeLibro.TabIndex = 13;
            this.btnInformeLibro.Text = "Informe libro";
            this.btnInformeLibro.UseVisualStyleBackColor = false;
            this.btnInformeLibro.Click += new System.EventHandler(this.btnInformeLibro_Click);
            // 
            // btnModificarLibro
            // 
            this.btnModificarLibro.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnModificarLibro.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificarLibro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarLibro.Location = new System.Drawing.Point(595, 399);
            this.btnModificarLibro.Name = "btnModificarLibro";
            this.btnModificarLibro.Size = new System.Drawing.Size(89, 44);
            this.btnModificarLibro.TabIndex = 14;
            this.btnModificarLibro.Text = "Modificar libro";
            this.btnModificarLibro.UseVisualStyleBackColor = false;
            this.btnModificarLibro.Click += new System.EventHandler(this.btnModificarLibro_Click);
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEliminarLibro.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarLibro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarLibro.Location = new System.Drawing.Point(745, 399);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Size = new System.Drawing.Size(86, 44);
            this.btnEliminarLibro.TabIndex = 15;
            this.btnEliminarLibro.Text = "Eliminar libro";
            this.btnEliminarLibro.UseVisualStyleBackColor = false;
            this.btnEliminarLibro.Click += new System.EventHandler(this.btnEliminarLibro_Click);
            // 
            // btnLibreria
            // 
            this.btnLibreria.Location = new System.Drawing.Point(756, 27);
            this.btnLibreria.Name = "btnLibreria";
            this.btnLibreria.Size = new System.Drawing.Size(96, 23);
            this.btnLibreria.TabIndex = 16;
            this.btnLibreria.Text = "Libreria S.A";
            this.btnLibreria.UseVisualStyleBackColor = true;
            this.btnLibreria.Click += new System.EventHandler(this.btnLibreria_Click);
            // 
            // lblLibroVendido
            // 
            this.lblLibroVendido.AutoSize = true;
            this.lblLibroVendido.Location = new System.Drawing.Point(382, 446);
            this.lblLibroVendido.Name = "lblLibroVendido";
            this.lblLibroVendido.Size = new System.Drawing.Size(0, 15);
            this.lblLibroVendido.TabIndex = 17;
            // 
            // reclamosToolStripMenuItem2
            // 
            this.reclamosToolStripMenuItem2.Name = "reclamosToolStripMenuItem2";
            this.reclamosToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.reclamosToolStripMenuItem2.Text = "Reclamos";
            this.reclamosToolStripMenuItem2.Click += new System.EventHandler(this.reclamosToolStripMenuItem2_Click);
            // 
            // FrmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 470);
            this.Controls.Add(this.lblLibroVendido);
            this.Controls.Add(this.btnLibreria);
            this.Controls.Add(this.btnEliminarLibro);
            this.Controls.Add(this.btnModificarLibro);
            this.Controls.Add(this.btnInformeLibro);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.btnInformeCliente);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnAgregarLibro);
            this.Controls.Add(this.listBoxLibros);
            this.Controls.Add(this.listBoxClientes);
            this.Controls.Add(this.btnRegistrarCliente);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libreria de Mauricio Gonzalez";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.ListBox listBoxLibros;
        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnInformeCliente;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnInformeLibro;
        private System.Windows.Forms.Button btnModificarLibro;
        private System.Windows.Forms.Button btnEliminarLibro;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem1;
        private System.Windows.Forms.Button btnLibreria;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reclamosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proximosIngresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reclamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem3;
        private System.Windows.Forms.Label lblLibroVendido;
        private System.Windows.Forms.ToolStripMenuItem reclamosToolStripMenuItem2;
    }
}
