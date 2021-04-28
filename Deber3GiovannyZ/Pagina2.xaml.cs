using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Deber3GiovannyZ
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina2 : ContentPage
    {
        public Pagina2(string usuario, string clave)
        {
            InitializeComponent();
            //recibe el datos
            lblUser.Text = usuario;

        }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnTotal_Clicked(object sender, EventArgs e)
        {
            try
            {

                double s1 = Convert.ToDouble(TxtDato1.Text);
                double exs1 = Convert.ToDouble(TxtDato2.Text);
                double s2 = Convert.ToDouble(TxtDato3.Text);
                double ex2 = Convert.ToDouble(TxtDato4.Text);

                double total = ((s1 * 0.3) + (exs1 * 0.2)) + ((s2 * 0.3) + (ex2 * 0.2));

                TxtTotal.Text = total.ToString();
                if (total >= 7)
                {
                    DisplayAlert("Alerta", "Aprobado", "Gracias");
                }
                else
                {
                    DisplayAlert("Alerta", "Reprobado", "Gracias");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Gracias");
            }
        }
    }
}