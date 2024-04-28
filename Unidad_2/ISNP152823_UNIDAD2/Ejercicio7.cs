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
    public partial class Ejercicio7 : Form {
        public Ejercicio7() {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e) {
            
            int num = int.Parse(txtNumero.Text);
            int contador = 1;
            int suma = 0;
            while (contador <= num) {
                suma += contador;
                contador += 1;
            }
            lblResutado.Text = suma.ToString();
            MessageBox.Show("El resultado de " + suma);
            txtNumero.Text = string.Empty;
            lblResutado.Text = string.Empty;
        }

        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }

}
