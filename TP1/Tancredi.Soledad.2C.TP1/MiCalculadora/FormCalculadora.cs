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
        private bool flagTxtNumero1 = false;
        private bool flagTxtNumero2 = false;    
        private bool flagComboBox1 = false;
        public FormCalculadora()
        {
            
            InitializeComponent();

        }

        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.lblResultado.Text = "";
            this.comboBox1.SelectedIndex = this.comboBox1.FindStringExact(" ");
            this.lstOperaciones.Items.Clear();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
            this.btnOperar.Enabled = false;


        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Operando num1 = new Operando();
            Operando num2 = new Operando(); 
           
            num1.Numero = this.txtNumero1.Text;
            num2.Numero = this.txtNumero2.Text;
            char.TryParse(this.comboBox1.Text, out char operador);

            double resultado = Calculadora.Operar(num1, num2, operador);

            this.lblResultado.Text = resultado.ToString();

            this.btnConvertirABinario.Enabled = true;
            this.btnConvertirADecimal.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
            this.btnOperar.Enabled = false;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if(this.lblResultado.Text != "")
            {
                Operando operador = new Operando();

                string binario = operador.DecimalBinario(lblResultado.Text);

                this.lblResultado.Text = binario;   
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if(lblResultado.Text != "")
            {
                Operando operador = new Operando();

                string numeritoDecimal = operador.BinarioDecimal(lblResultado.Text);

                this.lblResultado.Text = numeritoDecimal;

            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            if(txtNumero1.Text != "")
            {
                flagTxtNumero1 = true;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text != "")
            {
                flagComboBox1 = true;
            }
        }

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

        private void FormCalculadora_FormClosed(object sender, FormClosedEventArgs e)
        {
          

        }
    }
}
