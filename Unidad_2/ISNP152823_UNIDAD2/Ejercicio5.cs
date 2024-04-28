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
    public partial class Ejercicio5 : Form {
        public Ejercicio5() {
            InitializeComponent();
        }

        private void btnPromedio_Click(object sender, EventArgs e) {
            double notalab1, notalab2, notalab3, notalab4, notaFinallab;
            double notaact1, notaact2, notaact3, notaact4, notaFinalAct, notaFinal;


            if (!double.TryParse(txtLab1.Text, out notalab1)) {
                MessageBox.Show("Ingresa una nota valida para el Primer Parcial");
                return;
            }
            if (!double.TryParse(txtLab2.Text, out notalab2)) {
                MessageBox.Show("Ingrese una nota valida para el Segundo Parcial");
                return;
            }
            if (!double.TryParse(txtLab3.Text, out notalab3)) {
                MessageBox.Show("Ingrese una nota valida para el Tercel Parcial");
                return;
            }
            if (!double.TryParse(txtLab4.Text, out notalab4)) {
                MessageBox.Show("Ingrese una nota valida para el Laboratorio");
                return;
            }
            if (!double.TryParse(txtAct1.Text, out notaact1)) {
                MessageBox.Show("Ingresa una nota valida para el Primer Parcial");
                return;
            }
            if (!double.TryParse(txtAct2.Text, out notaact2)) {
                MessageBox.Show("Ingrese una nota valida para el Segundo Parcial");
                return;
            }
            if (!double.TryParse(txtAct3.Text, out notaact3)) {
                MessageBox.Show("Ingrese una nota valida para el Tercel Parcial");
                return;
            }
            if (!double.TryParse(txtAct4.Text, out notaact4)) {
                MessageBox.Show("Ingrese una nota valida para el Laboratorio");
                return;
            }
            notaFinallab = (notalab1 + notalab2 + notalab3 + notalab4) / 4;
            notaFinalAct = (notaact1 + notaact2 + notaact3 + notaact4) / 4;
            notaFinal = (notaFinalAct + notaFinallab) / 2;

            MessageBox.Show("La nota final es: " + notaFinal.ToString());


            txtLab1.Text = "0";
            txtLab2.Text = "0";
            txtLab3.Text = "0";
            txtLab4.Text = "0";
            txtAct1.Text = "0";
            txtAct2.Text = "0";
            txtAct3.Text = "0";
            txtAct4.Text = "0";
        }

        private void Ejercicio5_Load(object sender, EventArgs e) {
            txtLab1.Text = "0";
            txtLab2.Text = "0";
            txtLab3.Text = "0";
            txtLab4.Text = "0";
            txtAct1.Text = "0";
            txtAct2.Text = "0";
            txtAct3.Text = "0";
            txtAct4.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
