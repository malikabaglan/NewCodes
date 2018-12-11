﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FirstClickApp
{
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();
           var imageSource= new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };
            imageSource.CachingEnabled = false;
            //imageSource.CacheValidity = TimeSpan.FromHours(1);

            image.Source=imageSource;
            //image.Source = "http://lorempixel.com image.Aspect = Aspect.Fill;
        }
    }
}
