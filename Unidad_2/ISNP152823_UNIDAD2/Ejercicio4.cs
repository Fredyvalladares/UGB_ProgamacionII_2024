using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISNP152823_UNIDAD_2 {
    public partial class Ejercicio4 : Form {
        public Ejercicio4() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void btnCalcular_Click(object sender, EventArgs e) {
            double cantidad, precioUnitario, totalSinDescuento, totalConDescuento, totalapagar;

            cantidad = double.Parse(txtCantidad.Text);
            precioUnitario = double.Parse(txtPrecio.Text);

            totalSinDescuento = precioUnitario * cantidad;


            if (totalSinDescuento <= 2000) {

                totalConDescuento = totalSinDescuento * 0.15;
                totalapagar = totalSinDescuento - totalConDescuento;

                MessageBox.Show("Gracias por su compra tiene un descuento del 15% " + totalConDescuento.ToString("C") + "   El total a pagar es: " + totalapagar.ToString("C"));

                //MessageBox.Show("El total a pagar es: " + totalapagar.ToString("C"));
            } else {
                totalConDescuento = totalSinDescuento * 0.35;
                totalapagar = totalSinDescuento - totalConDescuento;
                MessageBox.Show("Gracias por su compra tiene un descuento del 35% " + totalConDescuento.ToString("C") + "   El total a pagar es: " + totalapagar.ToString("C"));
            }

            txtCantidad.Text = string.Empty;
            txtPrecio.Text = string.Empty;

        }

        private void btnRegesar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
