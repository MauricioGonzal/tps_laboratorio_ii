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
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// Inicia el formulario llamando al metodo correspondiente
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Limpia los campos de los operandos, del resultado y coloca el combo box en la opcion vacio
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.lblResultado.Text = "";
            this.cmbOperador.Text = "";
        }

        /// <summary>
        /// Limpia el form invocando al metodo correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Limpiar();
            
        }

        /// <summary>
        /// Crea los objetos de tipo Operando necesarios y llama al metodo Operar de la clase calculadora
        /// </summary>
        /// <param name="numero1">el primer operando en formato string</param> 
        /// <param name="numero2">el segundo operando en formato string</param> 
        /// <param name="operador">el caracter de operador en formato string</param> 
        /// <returns>el retorno del metodo operar de la clase Calculadora, que sera el resultado de la operacion si todo fue valido</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);

            double resultado= Calculadora.Operar(operando1, operando2, char.Parse(operador));

            return resultado;
        }

        /// <summary>
        /// al hacer click en Operar se realiza la operacion y se coloca el resultado y la operacion en el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string operando1 = this.txtNumero1.Text;
            string operando2 = this.txtNumero2.Text;
            string operador;
            double resultado;

            if (cmbOperador.SelectedItem is null)
            {
                operador = "+";
            }
            else
            {
                operador = cmbOperador.Text;
            }

            if(operando1 == "")
            {
                operando1 = "0";
            }

            if (operando2 == "")
            {
                operando2 = "0";
            }

            resultado= Operar(operando1, operando2, operador);

            if (operando2.StartsWith('-'))
            {
                operando2 = $"({operando2})";
            }
            this.lblResultado.Text = resultado.ToString();
            this.lstOperaciones.Items.Add($"{operando1} {operador} {operando2} = {resultado}");


        }


        /// <summary>
        /// Al hacer click en Limpiar se limpia el form invocando al metodo Limpiar()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();

        }

        /// <summary>
        /// Al hacer click en Cerrar se cierra el formulario llevando a cabo el metodo de salida aplicado en el metodo FormClosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {   
               this.Close();
            
        }

        /// <summary>
        /// Al hacer click en Convertir a Binario se verifica si existe un resultado para trabajar, y si existe se asigna al espacio resultado convertido a binario si es posible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string resultadoStr = this.lblResultado.Text;

            if (string.IsNullOrEmpty(resultadoStr))
            {
                this.lblResultado.Text = "Debe existir un resultado para realizar la operacion";

            }
            else
            {
                Operando operando = new Operando(resultadoStr);
                this.lblResultado.Text = operando.DecimalBinario(resultadoStr);
                
            }

           

            
        }


        /// <summary>
        /// metodo de salida del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string mensaje = "Esta seguro de querer salir?";
            string titulo = "Salir";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            if (MessageBox.Show(mensaje, titulo, buttons, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Al hacer click en Convertir a Decimal se verifica si existe un resultado para trabajar, y si existe se asigna al espacio resultado convertido a decimal si es posible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string resultado= this.lblResultado.Text;
            if(string.IsNullOrEmpty(resultado))
            {
                this.lblResultado.Text = "Debe existir un resultado para realizar la operacion";
            }
            else
            {
                Operando operando= new Operando(resultado);
                this.lblResultado.Text = operando.BinarioDecimal(resultado);

            }

        }
    }
}
