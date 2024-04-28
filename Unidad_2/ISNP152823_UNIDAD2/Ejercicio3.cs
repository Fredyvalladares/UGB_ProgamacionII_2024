using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISNP152823_UNIDAD_2 {
    public partial class Ejercicio3 : Form {
        public Ejercicio3() {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e) {
            try {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                double respuesta = 0;
                
                if (rdbSuma.Checked) {
                    respuesta = num1 + num2;
                } else if (rdbResta.Checked) {
                    respuesta = num1 - num2;
                } else if (rdbMultiplicacion.Checked) {
                    respuesta = num1 * num2;
                } else if (rdbDivision.Checked) {
                    respuesta = num1 / num2;
                } else if (rdbPotencia.Checked) {
                    num1 = Convert.ToInt32(txtNum1.Text);
                    num2 = Convert.ToInt32(txtNum1.Text);
                    respuesta = Math.Pow(num1, num2);
                } else if (rdbRaiz.Checked) {
                    num1 = Convert.ToDouble(txtNum1.Text);
                    respuesta = Math.Sqrt(num1);

                 }

                lblResult.Text = Math.Round(respuesta, 4).ToString();
                               
            } catch (Exception) {
                MessageBox.Show("Error, Ingrese Datos Validos", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ejercicio3_Load(object sender, EventArgs e) {
            rdbSuma.Checked = true;
        }

        private void rdbSuma_CheckedChanged(object sender, EventArgs e) {
            txtNum2.Visible = true;
            lblNum2.Visible = true;
            lblRaiz.Text = string.Empty;
            lblResult.Text = string.Empty;
            txtNum2.Clear();
            txtNum1.Clear();
            lbloperador.Text = ("+");
            btnResultado.Text = ("Sumar");
        }

        private void rdbResta_CheckedChanged(object sender, EventArgs e) {
            txtNum2.Visible = true;
            lblNum2.Visible = true;
            lblRaiz.Text = string.Empty;
            lblResult.Text = string.Empty;
            txtNum2.Clear();
            txtNum1.Clear();
            lbloperador.Text = ("-");
            btnResultado.Text = ("Restar");
        }

        private void rdbMultiplicacion_CheckedChanged(object sender, EventArgs e) {
            txtNum2.Visible = true;
            lblNum2.Visible = true;
            lblRaiz.Text = string.Empty;
            lblResult.Text = string.Empty;
            txtNum2.Clear();
            txtNum1.Clear();
            lbloperador.Text = ("*");
            btnResultado.Text = ("Multiplicar");
        }

        private void rdbDivision_CheckedChanged(object sender, EventArgs e) {
            txtNum2.Visible = true;
            lblNum2.Visible = true;
            lblRaiz.Text = string.Empty;
            lblResult.Text = string.Empty;
            txtNum2.Clear();
            txtNum1.Clear();
            lbloperador.Text = ("/");
            btnResultado.Text = ("Dividir");
        }

        private void rdbPotencia_CheckedChanged(object sender, EventArgs e) {
            txtNum2.Visible = true;
            lblNum2.Visible = true;
            lblRaiz.Text = string.Empty;
            lblResult.Text = string.Empty;
            txtNum2.Clear();
            txtNum1.Clear();
            lbloperador.Text = ("^");
            btnResultado.Text = ("Potencia");
        }

        private void rdbRaiz_CheckedChanged(object sender, EventArgs e) {
            lblRaiz.Text = ("Calcular la Raiz Cuadrada");
            lbloperador.Text = string.Empty;
            lblResult.Text = string.Empty;
            txtNum2.Visible = false;
            lblNum2.Visible = false;
            txtNum1.Clear();
            txtNum2.Text = "0";
            btnResultado.Text = ("Calcular Raiz");
         }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            lblResult.Text = string.Empty;
            txtNum1.Clear();
            txtNum2.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
