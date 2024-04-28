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
    public partial class Ejercicio2 : Form {
        public Ejercicio2() {
            InitializeComponent();
        }
        private void Ejercicio2_Load(object sender, EventArgs e) {
            rdbMetrosyardas.Checked = true;
        }

        private void rdbMetrosyardas_CheckedChanged(object sender, EventArgs e) {
            lblDee.Text = "Metros";
            lblRespuesta.Text = string.Empty;
        }

        private void rdbYardasmetros_CheckedChanged(object sender, EventArgs e) {
            lblDee.Text = "Yardas";
            lblRespuesta.Text = string.Empty;
        }

        private void rdbCentimetrosmilimetros_CheckedChanged(object sender, EventArgs e) {
            lblDee.Text = "Centimetros";
            lblRespuesta.Text = string.Empty;
        }

        private void rdbMilimetroscentimetros_CheckedChanged(object sender, EventArgs e) {
            lblDee.Text = "Milimetros";
            lblRespuesta.Text = string.Empty;

        }
        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void btnConvertir_Click(object sender, EventArgs e) {

            if (double.TryParse(txtPeso.Text, out double Longitud)) {


                if (rdbMetrosyardas.Checked) {
                    double yardas = Longitud / 0.9144;
                    lblRespuesta.Text = yardas.ToString() + " Yardas";
                }
                if (rdbYardasmetros.Checked) {
                    double metros = Longitud / 1.09361;
                    lblRespuesta.Text = metros.ToString() + " Metros";
                }
                if (rdbCentimetrosmilimetros.Checked) {
                    double milimetros = Longitud * 10;
                    lblRespuesta.Text = milimetros.ToString() + " Milimetros";
                }
                if (rdbMilimetroscentimetros.Checked) {
                    double centimetros = Longitud / 10;
                    lblRespuesta.Text = centimetros.ToString() + " Centimetros";
                }

                } else {
                MessageBox.Show("Ingrese un valor válido");
            }

        }

       
    }

}

