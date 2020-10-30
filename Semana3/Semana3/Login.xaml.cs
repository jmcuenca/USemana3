using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}
        public  void btnIngresar_Clicked(object sender, EventArgs arg) {

            if (txtClave.Text.Equals("uisrael2020") && txtUsuario.Text.Equals("estudiante2020"))
            {
                abrirVentanaAsync();

            }
            else {
                DisplayAlert("Error", "Usuario o clave incorrecta", "Error");
                this.txtClave.Text = "";
                this.txtUsuario.Text = "";
            }
        }
        private async void abrirVentanaAsync() {
            Ejercicio ejercicio = new Ejercicio();
            await this.Navigation.PushAsync(ejercicio);
        }
    }
}