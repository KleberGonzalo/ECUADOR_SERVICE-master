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
    public partial class Busqueda_Hotel : ContentPage
    {
        public Busqueda_Hotel()
        {
            InitializeComponent();
        }

        private void Guadar_Clicked(object sender, EventArgs e)
        {
            Datos.hoteles.Add(new Hoteles
            {
                provincia = Provincia.SelectedItem.ToString(),
                hhotel = Hotel.SelectedItem.ToString(),
                fecha = fechaReserva.Date.ToString(),
                hora = horaReserva.Time.ToString()
            });
            DisplayAlert("Exito", "Hotel Reservado", "Ok");
        }
    }
}