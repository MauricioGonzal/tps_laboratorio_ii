using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormRegistroLibros
{
    public partial class FrmRegistroLibros : Form
    {
        public Libro libro;

        public FrmRegistroLibros()
        {
            InitializeComponent();
        }

        public FrmRegistroLibros(Libro libro):this()
        {
            this.txtNombreLibro.Text = libro.Nombre;
            this.txtAutorLibro.Text = libro.Autor;
            this.txtPrecio.Text = libro.Precio.ToString();
            this.cmbCategoriaLibro.Text = libro.Categoria.ToString();
            this.txtStock.Text = libro.Stock.ToString();
        }

        private void FrmRegistroLibros_Load(object sender, EventArgs e)
        {
            this.cmbCategoriaLibro.DataSource= Enum.GetValues(typeof(Libro.Categorias));
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(string.IsNullOrEmpty(this.txtNombreLibro.Text) || string.IsNullOrEmpty(this.txtAutorLibro.Text) || string.IsNullOrEmpty(this.txtPrecio.Text) || string.IsNullOrEmpty(this.txtStock.Text))
                {
                    throw new DatoVacioException("Algun campo esta sin completar en el registro de Libros");
                }
                libro = new Libro(this.txtNombreLibro.Text, this.txtAutorLibro.Text, (Libro.Categorias)this.cmbCategoriaLibro.SelectedItem, int.Parse(this.txtStock.Text), float.Parse(this.txtPrecio.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique los datos ingresados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DatoVacioException)
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            finally
            {
                this.Close();
            }
            
            
            

        }
    }
}
