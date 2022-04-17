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
            if(flagTxtNumero1 == false || flagTxtNumero2 == false || flagComboBox1 == false)
            {
                this.btnOperar.Enabled = false;
            }
            else
            {
               this.btnOperar.Enabled = true;

            }

           
            string strOperando1 = this.txtNumero1.Text;
            string strOperando2 = this.txtNumero2.Text;
            string strComboBox = this.comboBox1.Text;
            

            Operando operando1 = new Operando();
            Operando operando2 = new Operando();

            operando1.Numero = strOperando1;
            operando2.Numero = strOperando2;

            double res =  Calculadora.Operar(operando1, operando2, '+');

           // this.richTextBox1.Text =$"{strOperando1} {strComboBox} {strOperando2} = {res}";
            
          

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

        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {

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
    }
}
