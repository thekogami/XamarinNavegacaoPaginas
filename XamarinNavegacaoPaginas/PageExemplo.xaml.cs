﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinNavegacaoPaginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageExemplo : ContentPage
    {
        public PageExemplo()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PopToRootAsync(); volta para a pagina raiz
            await Navigation.PopAsync();
        }
    }
}