using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academica {
    public partial class Formprincipal : Form {
        public Formprincipal() {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e) {
            alumnos objconvertir = new alumnos();
            objconvertir.ShowDialog();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e) {
            materias obj = new materias();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e) {
            Ejercicio2 objconvertir = new Ejercicio2();
            objconvertir.ShowDialog();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e) {
            alumnos objconvertir = new alumnos();
            objconvertir.ShowDialog();
        }

        private void btnEjercicio5_Click(object sender, EventArgs e) {
             
        }
    }
}
