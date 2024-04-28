using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISNP152823_UNIDAD_2 {
    public partial class Ejercicio1 : Form {
        public Ejercicio1() {
            InitializeComponent();
        }


        private void Ejercicio1_Load(object sender, EventArgs e) {
            rdbLibraskilo.Checked = true;
        }

        private void rdbLibraskilo_CheckedChanged(object sender, EventArgs e) {
            lblDee.Text = ("Libras");
            txtPeso.Clear();
            lblRespuesta.Text = string.Empty;
        }

        private void rdbKilolibras_CheckedChanged(object sender, EventArgs e) {
            lblDee.Text = ("Kilogramos");
            txtPeso.Clear();
            lblRespuesta.Text = string.Empty;
        }
        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void btnConvertir_Click(object sender, EventArgs e) {

            if (double.TryParse(txtPeso.Text, out double Peso)) {

                double kilogramos = Peso * 0.45359237;
                lblRespuesta.Text = Math.Round(kilogramos, 4) + " Kilogramos";

                if (rdbKilolibras.Checked) {
                    double Libras = Peso * 2.20462262;
                    lblRespuesta.Text = Math.Round(Libras, 4) + " Libras";


                }

            } else {
                MessageBox.Show("Ingrese un valor válido");
            }

        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e) {
            if( !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    { 
                e.Handled = true;
            }
                    
                    
        }
        
    }

}