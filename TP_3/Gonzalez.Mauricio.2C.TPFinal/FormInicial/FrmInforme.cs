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
 
        }
    }
}
