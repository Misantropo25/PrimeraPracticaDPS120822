using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWebCS
{

    public partial class _Default : Page
    {
        ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_sumar_Click(object sender, EventArgs e)
        {
            double nro1 = Convert.ToDouble(tb_nro1.Text);
            double nro2 = Convert.ToDouble(tb_nro2.Text);
            tb_resultado.Text = service.Suma(nro1, nro2).ToString();
        }

        protected void btn_restar_Click(object sender, EventArgs e)
        {
            double nro1 = Convert.ToDouble(tb_nro1.Text);
            double nro2 = Convert.ToDouble(tb_nro2.Text);
            tb_resultado.Text = service.Resta(nro1, nro2).ToString();
        }

        protected void btn_multiplicar_Click(object sender, EventArgs e)
        {
            double nro1 = Convert.ToDouble(tb_nro1.Text);
            double nro2 = Convert.ToDouble(tb_nro2.Text);
            tb_resultado.Text = service.Multiplicar(nro1, nro2).ToString();
        }

        protected void btn_dividir_Click(object sender, EventArgs e)
        {
            double nro1 = Convert.ToDouble(tb_nro1.Text);
            double nro2 = Convert.ToDouble(tb_nro2.Text);
            tb_resultado.Text = service.Dividir(nro1, nro2).ToString();
        }

        protected void btn_potencia_Click(object sender, EventArgs e)
        {
            double nro1 = Convert.ToDouble(tb_nro1.Text);
            double nro2 = Convert.ToDouble(tb_nro2.Text);
            tb_resultado.Text = service.Potencia(nro1, nro2).ToString();
        }

        protected void btn_radicacion_Click(object sender, EventArgs e)
        {
            double nro1 = Convert.ToDouble(tb_nro1.Text);
            tb_resultado.Text = service.Radicacion(nro1).ToString();
        }

        protected void btn_factorial_Click(object sender, EventArgs e)
        {
            int nro1 = Convert.ToInt32(tb_nro1.Text);
            tb_resultado.Text = service.fact(nro1).ToString();
        }

        protected void btn_seno_Click(object sender, EventArgs e)
        {
            int nro1 = Convert.ToInt32(tb_nro1.Text);
            tb_resultado.Text = service.Seno(nro1).ToString();
        }

        protected void btn_coseno_Click(object sender, EventArgs e)
        {
            int nro1 = Convert.ToInt32(tb_nro1.Text);
            tb_resultado.Text = service.Coseno(nro1).ToString();
        }

        protected void btn_porcentaje_Click(object sender, EventArgs e)
        {
            int nro1 = Convert.ToInt32(tb_nro1.Text);
            tb_resultado.Text = service.Porcentaje(nro1).ToString();
        }

       
    }
}