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
	public partial class Ejercicio : ContentPage
	{
		public Ejercicio ()
		{
			InitializeComponent ();
		}
        public void btnCalcular_Clicked(object sendr, EventArgs args)
        {
            decimal parcial1 = decimal.Parse(txtNota1.Text) * 0.3M + decimal.Parse(txtExamen1.Text) * 0.2M;
            decimal parcial2 = decimal.Parse(txtNota2.Text) * 0.3M + decimal.Parse(txtExamen2.Text) * 0.2M;
            decimal total = parcial1 + parcial2;
            txtResultado.Text = (total > 7) ? "APROBADO" : "REPROBADO";

        }
    }
}