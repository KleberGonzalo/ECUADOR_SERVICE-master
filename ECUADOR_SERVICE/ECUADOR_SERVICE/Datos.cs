using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ECUADOR_SERVICE
{
    public static class Datos
    {
        public  static ObservableCollection<Viajes> viajes = new ObservableCollection<Viajes>();
       public  static ObservableCollection<Hoteles> hoteles = new ObservableCollection<Hoteles>();
    }
}
