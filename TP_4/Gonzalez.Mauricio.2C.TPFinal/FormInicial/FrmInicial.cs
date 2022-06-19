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
using System.Threading;

/*Poner título a todos los formularios
Qué los formularios se abran con alguna relación de posición, no uno en cada punta
Qué los datos arranquen cargados por defecto
Hacer más enfasis en la atención, no es tan importante el ABM en lo que se pidió
Un proyecto por formulario?
Dar nombre a los archivos: Form1*/

namespace Vista
{
    public partial class FrmInicial : Form
    {
        Libreria libreria;
        Libro libro;
        Cliente cliente;
        ProximosIngresos frmProximosIngresos;
        int banderaCargaClientes = 0;
        int banderaCargaLibros = 0;


        public FrmInicial()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Libro> proximos= new List<Libro>();
            proximos.Add(new Libro("El senior de los anillos", "Peter Jackson", Libro.Categorias.Ficcion, 5, 500));
            proximos.Add(new Libro("Harry Potter", "J.K. Rowling", Libro.Categorias.Ficcion, 5, 600));
            proximos.Add(new Libro("Cuerpo Humano", "Roberto Garcia", Libro.Categorias.Enciclopedia, 10, 350));
            libreria = new Libreria("Libreria MG S.A ", proximos);

            try
            {
                    libreria.libros = LibroDAO.Cargar();
                    foreach (Libro l in libreria.libros)
                    {

                        this.listBoxLibros.Items.Add(l);
                    }
                    
                    banderaCargaLibros = 1;

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }

            try
            {
                    List<Cliente> clientes;
                    clientes = ClaseSerializadora<List<Cliente>>.Leer("Clientes");
                    foreach (Cliente c in clientes)
                    {
                        libreria.clientes.Add(c);
                        this.listBoxClientes.Items.Add(c);
                    }

                    banderaCargaClientes = 1;
                    this.clientesToolStripMenuItem1.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }

        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            
                FrmRegistroCliente formRegistro = new FrmRegistroCliente();
                formRegistro.ShowDialog();


                if (formRegistro.Cliente is not null)
                {
                    if (libreria + formRegistro.Cliente)
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
            DialogResult retorno=formRegistroLibro.ShowDialog();
            
            if (formRegistroLibro.libro is not null && libreria is not null && libreria + formRegistroLibro.libro)
            {
                MessageBox.Show("El libro fue agregado");

            }
            else if(retorno==DialogResult.OK)
            {
                MessageBox.Show("El item ingresado ya existe en el sistema", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cliente.dvl = ActualizarLabelVentaLibro;
                libro = this.listBoxLibros.SelectedItem as Libro;
                if (cliente is not null && libro is not null)
                {
                    bool ret = cliente.AvisarVentaDeLibro(libro);
                    MessageBox.Show($"Se ha vendido el libro {libro.Nombre} al cliente {cliente.Nombre}");
                    if (!ret)
                    {
                        libreria.libros.Remove(libro);
                        this.listBoxLibros.Items.Remove(libro);
                    }
                }
            }
            else
            {
                MessageBox.Show("Para realizar esta operacion debe seleccionar un libro y un cliente", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.lblVentaLibro.Text = "";
        }

        /// <summary>
        /// actualiza el label debajo de el boton VENDER para avisar que la venta se dio de forma exitosa, utilizando el delegado de la clase cliente
        /// </summary>
        public void ActualizarLabelVentaLibro()
        {  
            
                this.lblVentaLibro.Text = "Venta exitosa!";

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
            else
            {
                MessageBox.Show("Debe seleccionar un cliente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("Debe seleccionar un libro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            if (this.listBoxClientes.SelectedItem is not null)
            {
                cliente = this.listBoxClientes.SelectedItem as Cliente;

                if (cliente != null)
                {
                    

                    FrmRegistroCliente formRegistro = new FrmRegistroCliente(cliente);
                    formRegistro.ShowDialog();

                    if(formRegistro.Cliente is not null)
                    {
                        this.listBoxClientes.Items.Remove(cliente);
                        libreria = libreria - cliente;
                        this.libreria.clientes.Add(formRegistro.Cliente);

                        MessageBox.Show("el cliente se modifico");
                        this.listBoxClientes.Items.Add(formRegistro.Cliente);
                    }

                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    else
                    {
                        MessageBox.Show("El libro ya existe en el sistema");
                    }

                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un libro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (banderaCargaLibros == 0)
                {

                    List<Libro> libros;
                    libros = ClaseSerializadora<List<Libro>>.Leer("Libros");

                    foreach(Libro l in libros)
                    {
                        libreria.libros.Add(l);
                        this.listBoxLibros.Items.Add(l);
                    }
                    
                    banderaCargaLibros = 1;
                    this.librosToolStripMenuItem1.Enabled = true;   

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
                    List<Cliente> clientes;
                    clientes= ClaseSerializadora<List<Cliente>>.Leer("Clientes");
                    foreach (Cliente c in clientes)
                    {
                        libreria.clientes.Add(c);
                        this.listBoxClientes.Items.Add(c);
                    }
                    
                    banderaCargaClientes = 1;
                    this.clientesToolStripMenuItem1.Enabled = true;
                    
                }
                else
                {
                    MessageBox.Show("El archivo ya se encuentra cargado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("El archivo ha sido guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vuelva a intentarlo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void librosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseSerializadora<List<Libro>>.Escribir(libreria.libros, "Libros");
                MessageBox.Show("El archivo ha sido guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                MessageBox.Show("Vuelva a intentarlo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnLibreria_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((IExponerFicha)libreria).MostrarFicha());
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (libreria.clientes.Count == 0 || libreria.libros.Count == 0)
                {
                    throw new DatoVacioException("Hay alguna lista que no esta cargada");
                }
                else
                {
                    FrmRegistrarReclamo frmRegistrarReclamo = new FrmRegistrarReclamo(libreria);
                    if (frmRegistrarReclamo.ShowDialog() == DialogResult.OK)
                    {
                        libreria.reclamos.Add(frmRegistrarReclamo.Reclamo);
                        MessageBox.Show("El reclamo se ha registrado correctamente");
                    }
                }
            }
            catch(DatoVacioException)
            {
                MessageBox.Show("Datos incompletos", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);   
            }
            
            
        }

        private void verListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInforme frmInforme = new FrmInforme(libreria);
            frmInforme.ShowDialog();
        }

        private void librosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                if (libreria.libros.Count > 0)
                {
                    LibroDAO.Guardar(libreria.libros);
                }
                else
                {
                    MessageBox.Show("No hay libros cargados", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void reclamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (libreria.reclamos.Count > 0)
                {
                    ReclamoDAO.Guardar(libreria.reclamos);
                    MessageBox.Show("Los reclamos han sido guardados exitosamente");

                }
                else
                {
                    MessageBox.Show("No hay reclamos cargados", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
            
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProximosIngresos = new ProximosIngresos(libreria);
            frmProximosIngresos.Show();
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRegistroLibros frmRegistLib = new FrmRegistroLibros();
            
            if(frmProximosIngresos != null)
                {
                    frmProximosIngresos.Close();
                }
                
           

            if(frmRegistLib.ShowDialog() == DialogResult.OK)
            {
                libreria.proximosIngresos.Add(frmRegistLib.libro);
            }

        }

        private void librosToolStripMenuItem3_Click(object sender, EventArgs e)
        {

            try
            {
                if (banderaCargaLibros == 0)
                {
                    libreria.libros = LibroDAO.Cargar();
                    foreach (Libro l in libreria.libros)
                    {

                        this.listBoxLibros.Items.Add(l);
                    }
                    MessageBox.Show("Carga exitosa");
                    banderaCargaLibros = 1;
                }
                else
                {
                    MessageBox.Show("Los libros ya se encuentran cargados");
                }
                
            }
            catch(Exception)
            {
                MessageBox.Show("ERROR");
            }
            
        }

        

        private void reclamosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                
                libreria.reclamos = ReclamoDAO.Cargar(libreria);
                MessageBox.Show("Carga exitosa");
            }
            catch(Exception)
            {
                MessageBox.Show("ERROR");
            }
            
        }

       
    }
}
