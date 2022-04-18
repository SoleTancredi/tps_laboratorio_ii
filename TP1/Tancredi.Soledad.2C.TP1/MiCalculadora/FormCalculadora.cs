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
        #region AtributosFlag
        private bool flagTxtNumero1 = false;
        private bool flagTxtNumero2 = false;    
        private bool flagComboBox1 = false;

        #endregion

        public FormCalculadora()
        {
            
            InitializeComponent();

        }

        /// <summary>
        /// Borrará los datos de los TextBox, ComboBox y Label de la pantalla.
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.lblResultado.Text = "";
            this.comboBox1.SelectedIndex = this.comboBox1.FindStringExact(" ");
            this.lstOperaciones.Items.Clear();
        }

        /// <summary>
        /// Inicializa el formulario, llama al método Limpiar y deshabilita los botones de conversion y operacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
            this.btnOperar.Enabled = false;           
        }

        /// <summary>
        ///  Recibirá los dos números y el operador para luego llamar al método Operar de Calculadora
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="strOperador"></param>
        /// <returns> el resultado</returns>
        private static double Operar(string numero1, string numero2, string strOperador)
        {
            Operando num1 = new Operando();
            Operando num2 = new Operando();

            num1.Numero = numero1;
            num2.Numero = numero2;
            char.TryParse(strOperador, out char operador);

            double resultado = Calculadora.Operar(num1, num2, operador);

            return resultado;
        }

        /// <summary>
        /// LLama al método operar, y refleja el resultado en el Label, txtResultado.
        /// Además de dejar disponible el btn de conversion a binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string txtNumero1 = this.txtNumero1.Text;
            string txtNumero2 = this.txtNumero2.Text;
            string operador = this.comboBox1.Text;

            double resultado = Operar(txtNumero1, txtNumero2, operador);
            
            this.lblResultado.Text = resultado.ToString();
            this.lstOperaciones.Items.Add($" {txtNumero1} {operador} {txtNumero2} = {resultado}");  

            this.btnConvertirABinario.Enabled = true; 
           
        }

        /// <summary>
        /// Llama al método Limpiar() y deja fuera de disponibilidad los botones de conversion y operacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
            this.btnOperar.Enabled = false;
        }

        /// <summary>
        /// Llama al método Close() para cerrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Convierte a Binario un numero decimal. 
        /// Cambia el estado de disponibilidad del btnConvertirABinario a inactivo y el de convertirADecimal activo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if(this.lblResultado.Text != "")
            {
                Operando operador = new Operando();

                string binario = operador.DecimalBinario(lblResultado.Text);

                this.lblResultado.Text = binario;

                this.btnConvertirABinario.Enabled = false;
                this.btnConvertirADecimal.Enabled = true;
            }
        }

        /// <summary>
        /// Convierte a Decimal un numero binario. 
        /// Cambia el estado de disponibilidad del btnConvertirADecimal a inactivo y el de convertirABinario activo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "")
            {
                Operando operador = new Operando();

                string numeritoDecimal = operador.BinarioDecimal(lblResultado.Text);

                this.lblResultado.Text = numeritoDecimal;

                this.btnConvertirADecimal.Enabled = false;
                this.btnConvertirABinario.Enabled = true;

            }
        }

        /// <summary>
        /// Una vez utilizado cambia el estado del flag.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            if(txtNumero1.Text != "")
            {
                flagTxtNumero1 = true;
            }
        }

        /// <summary>
        /// Una vez utilizado cambia el estado del flag.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text != "")
            {
                flagComboBox1 = true;
            }
            
        }

        /// <summary>
        /// Una vez utilizado cambia el estado del flag a true. Y además deja disponible el btnOperar, si es que los flags 
        /// anteriores, de txt y comboBox tambien están en un estado true.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            if( txtNumero2.Text != "")
            {
                flagTxtNumero2 = true;
            }

            if(flagTxtNumero1 == true && flagComboBox1 == true && flagTxtNumero2 == true)
            {
                this.btnOperar.Enabled = true;
            }
        }

        /// <summary>
        ///Se encarga de cerrar el formulario, mostrandole al usuario una pregunta para la confirmacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {         
            if (e.CloseReason != CloseReason.UserClosing)
            {
                return;
            }
            
            string msjConfirmacion = "¿Está seguro de querer salir?";

            DialogResult respuesta = MessageBox.Show(msjConfirmacion, "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            
        }
    }
}
