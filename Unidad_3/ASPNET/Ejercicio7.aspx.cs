using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET {
    public partial class Ejercicio7 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e) {
            try {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                double respuesta = 0;

                if (rdbSuma.Checked) {
                    respuesta = num1 + num2;
                } else if (rdbResta.Checked) {
                    respuesta = num1 - num2;
                } else if (rdbMultiplicacion.Checked) {
                    respuesta = num1 * num2;
                } else if (rdbDivision.Checked) {
                    respuesta = num1 / num2;
                
                }

                lblMenaje.Text = "El resultado de la operaciones : " + Math.Round(respuesta, 2);

            } catch (Exception) {
            }

        }
    }
}