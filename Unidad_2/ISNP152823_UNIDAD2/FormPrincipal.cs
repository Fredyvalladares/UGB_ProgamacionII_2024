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
    public partial class FormPrincipal : Form {
        public FormPrincipal() {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnsalir_Click(object sender, EventArgs e) {
            Close();
        }

        private void convertirToolStripMenuItem_Click(object sender, EventArgs e) {
            Ejercicio1 objconvertir = new Ejercicio1();
            objconvertir.ShowDialog();
        }

        private void operacioesBasicasToolStripMenuItem_Click(object sender, EventArgs e) {
            Ejercicio3 objconvertir = new Ejercicio3();
            objconvertir.ShowDialog();
        }

        private void btnOpbasicas_Click(object sender, EventArgs e) {
            Ejercicio3 objconvertir = new Ejercicio3();
            objconvertir.ShowDialog();
        }

        private void btnConvertirp_Click(object sender, EventArgs e) {
            Ejercicio1 objconvertir = new Ejercicio1();
            objconvertir.ShowDialog();
        }

        private void btnConvertirm_Click(object sender, EventArgs e) {
            Ejercicio2 objconvertir = new Ejercicio2();
            objconvertir.ShowDialog();
        }

        private void convertirDistanciaToolStripMenuItem_Click(object sender, EventArgs e) {
            Ejercicio2 objconvertir = new Ejercicio2();
            objconvertir.ShowDialog();
        }

        private void btnCalculoporcntaje_Click(object sender, EventArgs e) {
            Ejercicio4 objconvertir = new Ejercicio4();
            objconvertir.ShowDialog();
        }

        private void btnPromedio_Click(object sender, EventArgs e) {
            Ejercicio5 objconvertir = new Ejercicio5();
            objconvertir.ShowDialog();
        }

        private void btnNumerosromanos_Click(object sender, EventArgs e) {
            Ejercicio6 objconvertir = new Ejercicio6();
            objconvertir.ShowDialog();
        }

        private void btnSumnaturales_Click(object sender, EventArgs e) {
            Ejercicio7 objconvertir = new Ejercicio7();
            objconvertir.ShowDialog();
        }

        private void btnTablamultiplicar_Click(object sender, EventArgs e) {
            Ejercicio8 objconvertir = new Ejercicio8();
            objconvertir.ShowDialog();
        }

        private void btnNumeromayor_Click(object sender, EventArgs e) {
            Ejercicio9 objconvertir = new Ejercicio9();
            objconvertir.ShowDialog();
        }

        private void btnUsuariocontra_Click(object sender, EventArgs e) {
            Ejercicio10 objconvertir = new Ejercicio10();
            objconvertir.ShowDialog();
        }

        private void calculoDeCompraToolStripMenuItem_Click(object sender, EventArgs e) {
            Ejercicio4 objconvertir = new Ejercicio4();
            objconvertir.ShowDialog();
        }

        private void promedioFinalToolStripMenuItem_Click(object sender, EventArgs e) {
            Ejercicio5 objconvertir = new Ejercicio5();
            objconvertir.ShowDialog();
        }

        private void convertirNumerosARomanosToolStripMenuItem_Click(object sender, EventArgs e) {
            Ejercicio6 objconvertir = new Ejercicio6();
            objconvertir.ShowDialog();
        }

        private void sumaDeToolStripMenuItem_Click(object sender, EventArgs e) {
            Ejercicio7 objconvertir = new Ejercicio7();
            objconvertir.ShowDialog();
        }

        private void tablaDeMultiplicarToolStripMenuItem_Click(object sender, EventArgs e) {
            Ejercicio8 objconvertir = new Ejercicio8();
            objconvertir.ShowDialog();
        }

        private void encontrarElNumeroMayorToolStripMenuItem_Click(object sender, EventArgs e) {
            Ejercicio9 objconvertir = new Ejercicio9();
            objconvertir.ShowDialog();
        }

        private void solicitarUsuarioYContraseñaToolStripMenuItem_Click(object sender, EventArgs e) {
            Ejercicio10 objconvertir = new Ejercicio10();
            objconvertir.ShowDialog();
        }
    }
}
