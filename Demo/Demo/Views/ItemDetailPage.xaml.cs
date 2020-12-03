﻿using Demo.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Demo.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}