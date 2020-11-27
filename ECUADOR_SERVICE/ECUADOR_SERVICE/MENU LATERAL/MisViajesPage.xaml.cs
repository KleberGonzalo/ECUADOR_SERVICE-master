﻿using ECUADOR_SERVICE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Movil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MisViajesPage : ContentPage
    {
        public MisViajesPage()
        {
            InitializeComponent();
            ListaViajes.ItemsSource = Datos.viajes;
            ListaHoteles.ItemsSource = Datos.hoteles;
           
        }
    }
}