using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Deber3GiovannyZ
{
    public partial class MainPage : ContentPage
    {
        public static String NombreUsuario = "Giovanny";

        public MainPage()
        {
            InitializeComponent();

        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string clave = txtPass.Text;

            if ((usuario == "Giovanny") && (clave == "Zaruma"))
            {
                await Navigation.PushAsync(new Pagina2(usuario, clave));
            }
            else
            {
                lblResultado.Text = "El usuario o contraseña es incorrecto";
            }




        }
    }
}
