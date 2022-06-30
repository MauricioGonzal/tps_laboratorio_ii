using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class ProximosIngresos : Form
    {
        List<Libro> proximosIngresos;
        Cartelera c;
        public ProximosIngresos(Libreria libreria)
        {
            InitializeComponent();
            this.proximosIngresos = libreria.proximosIngresos;
            c= new Cartelera(proximosIngresos);
            c.emc += mostrarIngresos;

        }

        public void mostrarIngresos(string datos)
        {
            if (this.InvokeRequired)
            {
                Action<string> d = mostrarIngresos;
                this.Invoke(d, datos);
            }
            else
            {
                richTextBox1.Text = datos;
            }
            
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            c.cancellationTokenSource.Cancel();
            this.Close();
        }

        private void ProximosIngresos_MouseClick(object sender, MouseEventArgs e)
        {
            c.cancellationTokenSource.Cancel();
           // this.Close();
        }
    }
}
