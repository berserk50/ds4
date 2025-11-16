using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_15_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String numero1 = Numero1.Text;
            String numero2 = Numero2.Text;

            int num1 = int.Parse(numero1);
            int num2 = int.Parse(numero2);
            int suma = num1 + num2;

            Resultado.Text = suma.ToString();
        }
    }
}