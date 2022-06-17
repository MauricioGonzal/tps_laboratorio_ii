namespace FormRegistroLibros
{
    partial class FrmRegistroLibros
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
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.txtAutorLibro = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoriaLibro = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.Location = new System.Drawing.Point(25, 27);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(100, 23);
            this.txtNombreLibro.TabIndex = 0;
            // 
            // txtAutorLibro
            // 
            this.txtAutorLibro.Location = new System.Drawing.Point(195, 27);
            this.txtAutorLibro.Name = "txtAutorLibro";
            this.txtAutorLibro.Size = new System.Drawing.Size(100, 23);
            this.txtAutorLibro.TabIndex = 1;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(25, 147);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 23);
            this.txtStock.TabIndex = 2;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(255, 221);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(195, 9);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(37, 15);
            this.lblAutor.TabIndex = 5;
            this.lblAutor.Text = "Autor";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(25, 121);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(36, 15);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Stock";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(195, 147);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtPrecio.TabIndex = 7;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(195, 121);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Categoria";
            // 
            // cmbCategoriaLibro
            // 
            this.cmbCategoriaLibro.FormattingEnabled = true;
            this.cmbCategoriaLibro.Location = new System.Drawing.Point(368, 27);
            this.cmbCategoriaLibro.Name = "cmbCategoriaLibro";
            this.cmbCategoriaLibro.Size = new System.Drawing.Size(121, 23);
            this.cmbCategoriaLibro.TabIndex = 10;
            // 
            // FrmRegistroLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 256);
            this.Controls.Add(this.cmbCategoriaLibro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtAutorLibro);
            this.Controls.Add(this.txtNombreLibro);
            this.Name = "FrmRegistroLibros";
            this.Text = "Registro libro";
            this.Load += new System.EventHandler(this.FrmRegistroLibros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.TextBox txtAutorLibro;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoriaLibro;
    }
}
