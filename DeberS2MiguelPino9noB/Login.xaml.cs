using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DeberS2MiguelPino9noB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIngreso_Clicked(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                string contrasena = txtcontrasena.Text;
                if (usuario == "estudiante2021" && contrasena == "uisrael2021")
                {
                    await Navigation.PushAsync(new MainPage(usuario));
                }
                else
                {
                   await DisplayAlert("Identificación fallida", "Usuario o Contraseña incorrecta", "OK");
                }

            }
            catch(Exception ex)
            {
               await DisplayAlert("Error", ex.Message, "Ok");
            }

        }
    }
}