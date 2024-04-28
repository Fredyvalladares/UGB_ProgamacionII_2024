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
    public partial class Ejercicio9 : Form {
        public Ejercicio9() {
            InitializeComponent();
        }

        private void btnNmayor_Click(object sender, EventArgs e) {
            double num1, num2;

            if (double.TryParse(txtNum1.Text, out num1)) {

            } else {
                MessageBox.Show("Ingrese un numero en el Primer contenedor");
                return;
            }

            if (double.TryParse(txtNum2.Text, out num2)) {

            } else {
                MessageBox.Show("Ingrese un numero en el segundo contenedor");
                return;
            }

            if (num1 > num2) {
                MessageBox.Show("El Numero Mayor es: " + num1);
            } else {
                MessageBox.Show("El Numero Mayor es:" + num2);
            }

            txtNum1.Text = string.Empty;
            txtNum2.Text = string.Empty;
        }

        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }

}
