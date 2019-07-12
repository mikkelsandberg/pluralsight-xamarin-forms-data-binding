using System;
using System.ComponentModel;
using BethanysPieShopStockApp.Model;
using Xamarin.Forms;

namespace BethanysPieShopStockApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public Pie ApplePie { get; set; }

        public MainPage()
        {
            InitializeComponent();

            ApplePie = new Pie
            {
                Id = 1,
                PieName = "Apple Pie",
                PiePrice = 20
            };

            BindingContext = ApplePie;

            //Binding pieNameBinding = new Binding
            //{
            //    Source = pie,
            //    Path = "PieName"
            //};
            //PieNameEntry.SetBinding(Entry.TextProperty, pieNameBinding);

            //Binding piePriceBinding = new Binding
            //{
            //    Source = pie,
            //    Path = "PiePrice"
            //};
            //PiePriceEntry.SetBinding(Entry.TextProperty, piePriceBinding);
        }

        public void Button_OnClicked(object sender, EventArgs e)
        {
            ApplePie.PiePrice++;
        }
    }
}
