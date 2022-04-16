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

namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.lblResultado.Text = "";
            this.cmbOperador.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Limpiar();
            
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);

            double resultado= Calculadora.Operar(operando1, operando2, char.Parse(operador));

            return resultado;
        }


        private void btnOperar_Click(object sender, EventArgs e)
        {
            string operando1 = this.txtNumero1.Text;
            string operando2 = this.txtNumero2.Text;
            string operador;

            if(cmbOperador.SelectedItem is null)
            {
                operador = "+";
            }
            else
            {
                operador = cmbOperador.Text;
            }

            
            
            
            double resultado= Operar(operando1, operando2, operador);
            this.lblResultado.Text = resultado.ToString();
            this.lstOperaciones.Items.Add($"{operando1} {operador} {operando2} = {resultado}");


        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {   
               this.Close();
            
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string mensaje = "Esta seguro de querer salir?";
            string titulo = "Cerrar aplicacion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            if (MessageBox.Show(mensaje, titulo, buttons) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
