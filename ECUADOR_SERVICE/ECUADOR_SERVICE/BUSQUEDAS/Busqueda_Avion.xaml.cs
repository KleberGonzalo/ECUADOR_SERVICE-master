using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ECUADOR_SERVICE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Busqueda_Avion : ContentPage
    {
        public Busqueda_Avion()
        {
            InitializeComponent();
        }

        private void Guardar_Clicked(object sender, EventArgs e)
        {

            Datos.viajes.Add(new Viajes
            {
                desde = desde.SelectedItem.ToString(),
                hasta = hasta.SelectedItem.ToString(),
                fecha = fechaReserva.Date.ToString(),
                hora = horaReserva.Time.ToString(),
                tipo =tipo.SelectedItem.ToString()
            });
            DisplayAlert("Èxito", "Se ingresò correcamente", "ok");


        }
    }
}