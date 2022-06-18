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

namespace Vista
{
    public partial class FrmRegistrarReclamo : Form
    {
        Reclamo reclamo;
        
        public FrmRegistrarReclamo(Libreria l)
        {
            InitializeComponent();
            this.cmbClientes.DataSource = l.clientes;
            this.cmbTipos.DataSource = Enum.GetValues(typeof(Reclamo.Tipo));
            this.cmbLibros.DataSource = l.libros;
        }

        public Reclamo Reclamo { get => reclamo; set => reclamo = value; }

        private void btnCrearReclamo_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbTipos.SelectedIndex != -1 || this.cmbClientes.SelectedIndex != -1 || this.cmbLibros.SelectedIndex!=-1)
                {
                    reclamo = new Reclamo((Reclamo.Tipo)this.cmbTipos.SelectedItem, (Cliente)this.cmbClientes.SelectedItem, (Libro)this.cmbLibros.SelectedItem);
                    DialogResult = DialogResult.OK;

                }
                else
                {
                    throw new DatoVacioException("Hay algun campo sin completar en el formulario");
                }
            }
            catch(DatoVacioException)
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
