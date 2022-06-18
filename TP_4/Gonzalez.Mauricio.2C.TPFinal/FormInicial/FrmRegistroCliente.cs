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

namespace FrmProyecto
{
    public partial class FrmRegistroCliente : Form
    {
        Cliente cliente;
        

        public Cliente Cliente { get => cliente; set => cliente = value; }

        public FrmRegistroCliente()
        {
            InitializeComponent();
        }

        public FrmRegistroCliente(Cliente c):this()
        {

            this.txtNombre.Text = c.Nombre;
            this.txtApellido.Text = c.Apellido;
            this.txtEmail.Text = c.Email;
            this.txtDni.Text = c.Dni;
            this.txtTelefono.Text = c.NumeroDeTelefono;
            this.cmbFormaDePAgo.Text = c.FormaDePago1.ToString();
        }

        private void FrmRegistroCliente_Load(object sender, EventArgs e)
        {
            this.cmbFormaDePAgo.DataSource = Enum.GetValues(typeof(Cliente.FormaDePago));
            
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtNombre.Text) || string.IsNullOrEmpty(this.txtApellido.Text) || !this.txtDni.Text.VerificarDni() || string.IsNullOrEmpty(this.cmbFormaDePAgo.Text) ||
                    string.IsNullOrEmpty(this.txtEmail.Text) || string.IsNullOrEmpty(this.txtTelefono.Text))
                {
                    throw new DatoVacioException("Algun campo esta incorrecto en form registro");
                }
                else
                {
                    cliente = new Cliente(this.txtNombre.Text, this.txtApellido.Text, this.txtDni.Text, (Cliente.FormaDePago)this.cmbFormaDePAgo.SelectedItem, this.txtEmail.Text, this.txtTelefono.Text);
                }
            }
            catch (DatoVacioException)
            {
                MessageBox.Show("Algun dato ingresado es incorrecto.");
            }
            finally
            {
                this.Close();
            }
     
        }
  
    }
}
