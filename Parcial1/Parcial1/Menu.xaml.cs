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
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void Ir_Page_Factur(object sender, EventArgs e)
        {
            App.FlyoutObj.Detail.Navigation.PushAsync(new Factura());
            App.FlyoutObj.IsPresented = false;
        }
        private void Ir_Page_Product(object sender, EventArgs e)
        {
            App.FlyoutObj.Detail.Navigation.PushAsync(new ProductosList());
            App.FlyoutObj.IsPresented = false;
        }
    }
}