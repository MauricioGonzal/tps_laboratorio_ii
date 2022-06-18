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

namespace FormInforme
{
    public partial class FrmInforme : Form
    {
        Cliente cliente;
        Libro libro;
        Libreria libreria;
        public FrmInforme()
        {
            InitializeComponent();
            
        }

        public FrmInforme(Cliente c):this()
        {
            
            cliente = c;
        }
        public FrmInforme(Libro l) : this()
        {

            libro = l;
        }

        public FrmInforme(Libreria libreria) : this()
        {

            this.libreria = libreria;
            libreria.EventoReclamo += CargarListaReclamos;
            richTextBox1.Text = "";
        }


        private void FrmInforme_Load(object sender, EventArgs e)
        {
            if(cliente is not null)
            {
                this.richTextBox1.Text = ((IExponerFicha)cliente).MostrarFicha();
            }
            else if(libro is not null)
            {
                this.richTextBox1.Text = ((IExponerFicha)libro).MostrarFicha();
            }
            else if(libreria is not null)
            {
                libreria.MostrarListaReclamos();
            }
 
        }

        public void CargarListaReclamos(Reclamo r)
        {
            richTextBox1.Text+= r.ToString();
        }
    }
}
