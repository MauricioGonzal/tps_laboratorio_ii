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
using FrmProyecto;
using FormRegistroLibros;
using FormInforme;

namespace FormInicial
{
    public partial class Form1 : Form
    {
        Libreria libreria;
        Libro libro;
        Cliente cliente;
        int banderaCargaClientes = 0;
        int banderaCargaLibros = 0;


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            libreria = new Libreria("Libreria MG S.A ");
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            
                FrmRegistroCliente formRegistro = new FrmRegistroCliente();
                formRegistro.ShowDialog();


                if (formRegistro.Cliente is not null)
                {
                    bool retorno =   formRegistro.Cliente.AgregarCliente(libreria);
               
                    if (retorno)
                    {
                        MessageBox.Show("el cliente se agrego");
                        this.listBoxClientes.Items.Add(formRegistro.Cliente);
                    }
                    else
                    {
                        MessageBox.Show("el cliente ingresado ya existe en el sistema");
                    }
                    
                }
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {

            FrmRegistroLibros formRegistroLibro = new FrmRegistroLibros();
            formRegistroLibro.ShowDialog();
            
            if (libreria.VerificarReplicaDeLibro(formRegistroLibro.libro))
            {
                MessageBox.Show("El item ingresado ya existe en el sistema", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (libreria + formRegistroLibro.libro)
            {
                MessageBox.Show("El libro fue agregado");
            }

            this.listBoxLibros.Items.Clear();
            foreach (Libro libro in libreria.libros)
            {
                this.listBoxLibros.Items.Add(libro);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.listBoxClientes.SelectedItem is not null && this.listBoxLibros.SelectedItem is not null)
            {
                cliente = this.listBoxClientes.SelectedItem as Cliente;
                libro = this.listBoxLibros.SelectedItem as Libro;
                if (cliente is not null && libro is not null)
                {
                    
                    if(!cliente.ComprarLibro(libro))
                    {
                        libreria.libros.Remove(libro);
                        this.listBoxLibros.Items.Remove(libro);
                    }
                    MessageBox.Show($"Se ha vendido el libro {libro.Nombre} al cliente {cliente.Nombre}");

                }
            }
            else
            {
                MessageBox.Show("Para realizar esta operacion debe seleccionar un libro y un cliente", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnInformeCliente_Click(object sender, EventArgs e)
        {
            if (this.listBoxClientes.SelectedItems.Count > 0)
            {
                cliente = this.listBoxClientes.SelectedItem as Cliente;
                if(cliente is not null)
                {
                    FrmInforme frmInforme = new FrmInforme(cliente);
                    frmInforme.ShowDialog();
                }
                
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (this.listBoxClientes.SelectedItem is not null)
            {
                cliente = this.listBoxClientes.SelectedItem as Cliente;
                if (cliente is not null && (libreria - cliente) is not null)
                {
                    this.listBoxClientes.Items.Remove(cliente);
                    MessageBox.Show("El cliente ha sido eliminado");
                }
            }
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (this.listBoxLibros.SelectedItem is not null)
            {
                libro = this.listBoxLibros.SelectedItem as Libro;
                if (libro is not null && (libreria=(libreria - libro)) is not null)
                {

                    this.listBoxLibros.Items.Remove(libro);
                    MessageBox.Show("El libro ha sido eliminado");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.listBoxClientes.SelectedItem is not null)
            {
                cliente = this.listBoxClientes.SelectedItem as Cliente;

                if (cliente != null)
                {
                    this.listBoxClientes.Items.Remove(cliente);
                    libreria = libreria - cliente;

                    FrmRegistroCliente formRegistro = new FrmRegistroCliente(cliente);
                    formRegistro.ShowDialog();

                    if (libreria + formRegistro.Cliente)
                    {
                        MessageBox.Show("el cliente se modifico");
                        this.listBoxClientes.Items.Add(formRegistro.Cliente);
                    }
                }

            }
        }

        private void btnModificarLibro_Click(object sender, EventArgs e)
        {
            if (this.listBoxLibros.SelectedIndex != -1)
            {
                libro = this.listBoxLibros.SelectedItem as Libro;

                if (libro != null)
                {
                    this.listBoxLibros.Items.Remove(libro);
                    libreria = libreria - libro;

                    FrmRegistroLibros formRegistroLibro = new FrmRegistroLibros(libro);
                    formRegistroLibro.ShowDialog();

                    if (libreria + formRegistroLibro.libro)
                    {
                        MessageBox.Show("el libro se modifico");
                        this.listBoxLibros.Items.Add(formRegistroLibro.libro);
                    }

                }
            }
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (banderaCargaLibros == 0)
                {
                    libreria.libros = ClaseSerializadora<List<Libro>>.Leer("Libros");
                    banderaCargaLibros = 1;
                    foreach (Libro libro in libreria.libros)
                    {
                        this.listBoxLibros.Items.Add(libro);
                    }
                }
                else
                {
                    MessageBox.Show("El archivo ya se encuentra cargado");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("ERROR");
            }
            

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (banderaCargaClientes == 0)
                {
                    libreria.clientes = ClaseSerializadora<List<Cliente>>.Leer("Clientes");
                    banderaCargaClientes = 1;
                    foreach (Cliente cliente in libreria.clientes)
                    {
                        this.listBoxClientes.Items.Add(cliente);
                    }
                }
                else
                {
                    MessageBox.Show("El archivo ya se encuentra cargado");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }

        }

        private void btnInformeLibro_Click(object sender, EventArgs e)
        {
            if (this.listBoxLibros.SelectedItems.Count > 0)
            {
                libro = this.listBoxLibros.SelectedItem as Libro;
                if(libro != null)
                {
                    FrmInforme frmInforme = new FrmInforme(libro);
                    frmInforme.ShowDialog();
                }
                
            }
            else
            {
                MessageBox.Show("Debe seleccionar un libro", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                
                    ClaseSerializadora<List<Cliente>>.Escribir(libreria.clientes, "Clientes");
                    
                

            }
            catch(Exception ex)
            {
                MessageBox.Show("Vuelva a intentarlo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

        private void librosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClaseSerializadora<List<Libro>>.Escribir(libreria.libros, "Libros");
        }

        private void btnLibreria_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((IExponerFicha)libreria).MostrarFicha());
        }
    }
}
