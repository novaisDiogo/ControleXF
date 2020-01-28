﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();
            //ImageOne.IsLoading

            Image imgUSB = new Image();
            if (Device.RuntimePlatform == Device.UWP)
            {
                imgUSB.Source = ImageSource.FromFile("Imagens/Usb.jpg");
            }
            else
            {
                imgUSB.Source = ImageSource.FromFile("Usb.png");
            }
            Container.Children.Add(imgUSB);
        }
    }
}