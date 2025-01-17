﻿using AppHotelEtecNoturno.Model;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppHotelEtecNoturno
{
    public partial class App : Application
    {
        public List<Suite> lista_suites = new List<Suite>
        {
            new Suite()
            {
               Nome = "Super Luxo",
               DiariaAdulto = 110.0,
               DiariaCrianca = 55.0
            },
            new Suite()
            {
               Nome = "Executiva",
               DiariaAdulto = 90.0,
               DiariaCrianca = 45.0
            },
            new Suite()
            {
               Nome = "Crise",
               DiariaAdulto = 45.0,
               DiariaCrianca = 20.0
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.ContratacaoHospedagem());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
