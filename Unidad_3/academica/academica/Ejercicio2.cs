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
    public partial class Ejercicio2 : Form {
        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        int posicion = 0;
        String accion = "nuevo";
        public Ejercicio2() {
            InitializeComponent();
        }

        private void Ejercicio2_Load(object sender, EventArgs e) {
        //    actualizarDsAgenda();
        //    grdDatosMateria.DataSource = dt.DefaultView;
        //}
        //private void actualizarDsAgenda() {
        //    ds.Clear();
        //    ds = objConexion.obtenerDatos();
        //    dt = ds.Tables["materias"];
        //    dt.PrimaryKey = new DataColumn[] { dt.Columns["idMateria"] };
        //    mostrarDatosMaterias();
        }
    }
}
