using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET {
    public partial class Ejercicio5 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnEnvia_Click(object sender, EventArgs e) {
            double edad = double.Parse(txtEdad.Text);
            
            if (edad >= 18) {
                lblMenaje.Text = "Es Mayor de Edad Puede Votar";
                
                
            }else  {
                lblMenaje.Text = "Es Menor de Edad NO Puede Votar";

            }


        }
               
    }
}