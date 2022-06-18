namespace Vista
{
    partial class FrmRegistrarReclamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTipos = new System.Windows.Forms.ComboBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.lblTipoReclamo = new System.Windows.Forms.Label();
            this.lblClienteReclamo = new System.Windows.Forms.Label();
            this.btnCrearReclamo = new System.Windows.Forms.Button();
            this.cmbLibros = new System.Windows.Forms.ComboBox();
            this.lblLibro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTipos
            // 
            this.cmbTipos.FormattingEnabled = true;
            this.cmbTipos.Location = new System.Drawing.Point(12, 168);
            this.cmbTipos.Name = "cmbTipos";
            this.cmbTipos.Size = new System.Drawing.Size(271, 23);
            this.cmbTipos.TabIndex = 0;
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(12, 36);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(271, 23);
            this.cmbClientes.TabIndex = 1;
            // 
            // lblTipoReclamo
            // 
            this.lblTipoReclamo.AutoSize = true;
            this.lblTipoReclamo.Location = new System.Drawing.Point(12, 150);
            this.lblTipoReclamo.Name = "lblTipoReclamo";
            this.lblTipoReclamo.Size = new System.Drawing.Size(30, 15);
            this.lblTipoReclamo.TabIndex = 2;
            this.lblTipoReclamo.Text = "Tipo";
            // 
            // lblClienteReclamo
            // 
            this.lblClienteReclamo.AutoSize = true;
            this.lblClienteReclamo.Location = new System.Drawing.Point(12, 18);
            this.lblClienteReclamo.Name = "lblClienteReclamo";
            this.lblClienteReclamo.Size = new System.Drawing.Size(44, 15);
            this.lblClienteReclamo.TabIndex = 3;
            this.lblClienteReclamo.Text = "Cliente";
            // 
            // btnCrearReclamo
            // 
            this.btnCrearReclamo.Location = new System.Drawing.Point(105, 217);
            this.btnCrearReclamo.Name = "btnCrearReclamo";
            this.btnCrearReclamo.Size = new System.Drawing.Size(75, 23);
            this.btnCrearReclamo.TabIndex = 4;
            this.btnCrearReclamo.Text = "Registrar";
            this.btnCrearReclamo.UseVisualStyleBackColor = true;
            this.btnCrearReclamo.Click += new System.EventHandler(this.btnCrearReclamo_Click);
            // 
            // cmbLibros
            // 
            this.cmbLibros.FormattingEnabled = true;
            this.cmbLibros.Location = new System.Drawing.Point(12, 98);
            this.cmbLibros.Name = "cmbLibros";
            this.cmbLibros.Size = new System.Drawing.Size(266, 23);
            this.cmbLibros.TabIndex = 5;
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Location = new System.Drawing.Point(13, 78);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(34, 15);
            this.lblLibro.TabIndex = 6;
            this.lblLibro.Text = "Libro";
            // 
            // FrmRegistrarReclamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 252);
            this.Controls.Add(this.lblLibro);
            this.Controls.Add(this.cmbLibros);
            this.Controls.Add(this.btnCrearReclamo);
            this.Controls.Add(this.lblClienteReclamo);
            this.Controls.Add(this.lblTipoReclamo);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.cmbTipos);
            this.Name = "FrmRegistrarReclamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Reclamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipos;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label lblTipoReclamo;
        private System.Windows.Forms.Label lblClienteReclamo;
        private System.Windows.Forms.Button btnCrearReclamo;
        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.Label lblLibro;
    }
}