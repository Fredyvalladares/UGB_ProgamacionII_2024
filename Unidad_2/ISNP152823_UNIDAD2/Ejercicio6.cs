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
    public partial class Ejercicio6 : Form {
        public Ejercicio6() {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e) {

            
            int numero = int.Parse(txtNumeroentero.Text);

            if (numero < 1 || numero > 20) {
                MessageBox.Show("El número debe estar entre 1 y 20");
                return;
            }

            string[] txtNumeromano = { "I", "II", "III", "IV", "V",
                                              "VI", "VII", "VIII", "IX", "X",
                                              "XI", "XII", "XIII", "XIV", "XV",
                                              "XVI", "XVII", "XVIII", "XIX", "XX" };

            string equivalenciaRomana = txtNumeromano[numero - 1];


            MessageBox.Show("El numero en romano es : " + equivalenciaRomana);

            txtNumeroentero.Text = string.Empty;
        }

        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
