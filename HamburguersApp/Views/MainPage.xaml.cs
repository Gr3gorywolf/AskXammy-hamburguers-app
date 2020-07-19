﻿using HamburguersApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HamburguersApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage :  ContentPage
    {
        private static MainPage _instance = null;

        public MainPage()
        {
            InitializeComponent();
            

            btnHamburguersList.Clicked += delegate
            {
                Navigation.PushAsync(new HamburguersList());
            };

            btnHamburguersForm.Clicked += delegate
            {
                Navigation.PushAsync(new HamburguerForm());
            };
        }
    }
}
