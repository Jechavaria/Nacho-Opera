using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NachoSuma;
using NachoResta;
using NachoMultiplica;
using NachoDivide;





namespace Nacho_Opera
{
    public partial class frmNachoOpera : Form
    {

        private TextBox activeTextBox;
        private double Resultado;


        public frmNachoOpera()
        {
            InitializeComponent();
            activeTextBox = txtPrimerNúmero;

            txtPrimerNúmero.Enter += TextBox_Enter;
            txtSegundoNúmero.Enter += TextBox_Enter;

            btn1.Click += btnNumero_Click;
            btn2.Click += btnNumero_Click;
            btn3.Click += btnNumero_Click;
            btn4.Click += btnNumero_Click;
            btn5.Click += btnNumero_Click;
            btn6.Click += btnNumero_Click;
            btn7.Click += btnNumero_Click;
            btn8.Click += btnNumero_Click;
            btn9.Click += btnNumero_Click;
            Btn0.Click += btnNumero_Click;
            btnComa.Click += btnComa_Click;
            txtPrimerNúmero.KeyPress += txtNumero_KeyPress;
            txtSegundoNúmero.KeyPress += txtNumero_KeyPress;
            txtPrimerNúmero.TextChanged += txtPrimerNúmero_TextChanged;
            txtSegundoNúmero.TextChanged += txtSegundoNúmero_TextChanged;

        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            activeTextBox = sender as TextBox;
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && activeTextBox != null)
            {
                activeTextBox.Text = activeTextBox.Text + btn.Text;
            }
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            if (activeTextBox != null && !activeTextBox.Text.Contains(","))
            {
                activeTextBox.Text = String.Concat(activeTextBox.Text, ",");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (activeTextBox != null && activeTextBox.Text.Length > 0)
            {
                activeTextBox.Text = activeTextBox.Text.Substring(0, activeTextBox.Text.Length - 1);
            }
        }

        private bool ValidarEntradas()
        {
            if (string.IsNullOrWhiteSpace(txtPrimerNúmero.Text) || string.IsNullOrWhiteSpace(txtSegundoNúmero.Text))
            {
                MessageBox.Show("Ingrese un número en ambos campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }


            if (e.KeyChar == 44 && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void txtPrimerNúmero_TextChanged(object sender, EventArgs e)
        {
            pbCheemsPrimerNumero.Visible = !string.IsNullOrWhiteSpace(txtPrimerNúmero.Text);
            pbCheemsFuerte.Visible = string.IsNullOrWhiteSpace(txtPrimerNúmero.Text);
        }

        private void txtSegundoNúmero_TextChanged(object sender, EventArgs e)
        {
            pbCheemsSegundoNumero.Visible = !string.IsNullOrWhiteSpace(txtSegundoNúmero.Text);
            pbCheemsFuerte.Visible = string.IsNullOrWhiteSpace(txtPrimerNúmero.Text);
        }
        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (!ValidarEntradas()) return;
            double num1 = Convert.ToDouble(txtPrimerNúmero.Text);
            double num2 = Convert.ToDouble(txtSegundoNúmero.Text);
            Resultado = Suma.Sumar(num1, num2);
            lblOperacion.Text = btnSumar.Text;
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (!ValidarEntradas()) return;
            double num1 = Convert.ToDouble(txtPrimerNúmero.Text);
            double num2 = Convert.ToDouble(txtSegundoNúmero.Text);
            Resultado = Resta.Restar(num1, num2);
            lblOperacion.Text = btnRestar.Text;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (!ValidarEntradas()) return;
            double num1 = Convert.ToDouble(txtPrimerNúmero.Text);
            double num2 = Convert.ToDouble(txtSegundoNúmero.Text);
            Resultado = Multiplicacion.Multiplicar(num1, num2);
            lblOperacion.Text = btnMultiplicar.Text;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (!ValidarEntradas()) return;
            double num1 = Convert.ToDouble(txtPrimerNúmero.Text);
            double num2 = Convert.ToDouble(txtSegundoNúmero.Text);

            if (num2 == 0)
            {
                MessageBox.Show("No es posible dividir por 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Resultado = Division.Dividir(num1, num2);
            lblOperacion.Text = btnDividir.Text;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            lblValorResultado.Text = Resultado.ToString();
            pbCheemsFuerte.Visible = true;
        }

    }


}

