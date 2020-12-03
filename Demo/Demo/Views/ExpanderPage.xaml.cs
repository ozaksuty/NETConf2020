using Demo.Models;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExpanderPage : ContentPage
    {
        public ExpanderPage()
        {
            InitializeComponent();
            this.BindingContext = new List<CategoryModel>
            {
                new CategoryModel
                {
                    Id = 1,
                    Name = "Başlangıçlar",
                    Products = new List<ProductModel>
                    {
                        new ProductModel
                        {
                            Id = 1,
                            Name = "Patates Kızartması",
                            Price = 15
                        },
                        new ProductModel
                        {
                            Id = 2,
                            Name = "Paçanga Böreği",
                            Price = 10
                        },
                    }
                },
                new CategoryModel
                {
                    Id = 2,
                    Name = "İçecekler",
                    Products = new List<ProductModel>
                    {
                        new ProductModel
                        {
                            Id = 1,
                            Name = "Ayran",
                            Price = 5
                        },
                        new ProductModel
                        {
                            Id = 2,
                            Name = "Sıkma Portakal Suyu",
                            Price = 10
                        },
                    }
                }
            };

        }
    }
}