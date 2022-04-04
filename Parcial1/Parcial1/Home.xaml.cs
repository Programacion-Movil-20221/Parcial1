using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parcial1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Ir_Page_Factura(object sender, EventArgs e)
        {
            App.FlyoutObj.Detail.Navigation.PushAsync(new Factura());
            App.FlyoutObj.IsPresented = false;
        }
        private void Ir_Page_Products(object sender, EventArgs e)
        {
            App.FlyoutObj.Detail.Navigation.PushAsync(new ProductosList());
            App.FlyoutObj.IsPresented = false;
        }
    }
}