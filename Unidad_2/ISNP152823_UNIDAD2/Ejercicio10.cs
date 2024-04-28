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
    public partial class Ejercicio10 : Form {
        public Ejercicio10() {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e) {
            string usuario = txtPassw.Text;
            string contraseña = txtUser.Text;

            if (usuario == "ugb" && contraseña == "ugb") {
                MessageBox.Show("Bienvenido a Programacion II con C#");
            } else {
                MessageBox.Show("Acceso Denegado");
            }

            txtPassw.Text = string.Empty;
            txtUser.Text = string.Empty;
        }
    }
    
}
