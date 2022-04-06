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
    public partial class MostrarProductos : ContentPage
    {
        public MostrarProductos(string nombre, int precio, int cantidad, string tipo, string descripcion)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            lbl_nombre.Text = nombre;
            lbl_precio.Text = "$ " + precio;
            lbl_cantidad.Text = cantidad + " unidades";
            lbl_tipo.Text = tipo;
            lbl_descripcion.Text = descripcion;
        }

        private void ImageButton_Regresar(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}