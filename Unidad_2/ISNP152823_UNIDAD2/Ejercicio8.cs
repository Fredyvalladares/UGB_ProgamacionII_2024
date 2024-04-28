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
    public partial class Ejercicio8 : Form {
        public Ejercicio8() {
            InitializeComponent();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e) {

            int numero = int.Parse(txtTabla.Text);
            ltsMostrartabla.Items.Clear();

            for (int i = 1; i <= 10; i++) {
                ltsMostrartabla.Items.Add(numero.ToString() + "x" + i.ToString() + "=" + (numero * i).ToString());
            }

            txtTabla.Text = string.Empty;
        }

        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
