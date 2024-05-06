using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET {
    public partial class Ejercicio6 : System.Web.UI.Page {
        protected void Button1_Click(object sender, EventArgs e) {
            double tempf = double.Parse(txtfahrenheit.Text);
            double tempc = 0;

            tempc = (tempf - 32) * 0.5556;

            lblMenaje.Text = "La temperatura es: " + Math.Round(tempc, 2) + " °C";

             }
    }
}